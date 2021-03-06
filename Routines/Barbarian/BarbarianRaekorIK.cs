﻿using Trinity.Framework;
using Trinity.Framework.Helpers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using Trinity.Components.Combat.Resources;
using Trinity.Framework.Actors.ActorTypes;
using Trinity.Framework.Objects;
using Trinity.Framework.Reference;
using Trinity.UI;
using Zeta.Common;
using Zeta.Game.Internals.Actors;
using Zeta.Game;
using Trinity.Framework.Avoidance.Structures;

namespace Trinity.Routines.Barbarian
{
    public sealed class BarbarianRaekorIK : BarbarianBase, IRoutine
    {
        #region Definition

        public string DisplayName => "Barbarian Raekor IK";

        public string Description =>
            "Build that uses full IK set for damage bonus and Raekor's for Furious Charge damage";

        public string Author => "jubisman";
        public string Version => "0.2.4";
        public string Url => "http://www.diablofans.com/builds/88896-ik-raekor-charge-v2-0-gr100";

        public Build BuildRequirements => new Build
        {
            Sets = new Dictionary<Set, SetBonus>
            {
                {Sets.ImmortalKingsCall, SetBonus.Third},
                {Sets.TheLegacyOfRaekor, SetBonus.First},
            },
            Skills = new Dictionary<Skill, Rune>
            {
                {Skills.Barbarian.FuriousCharge, null},
                {Skills.Barbarian.WrathOfTheBerserker, null},
                {Skills.Barbarian.CallOfTheAncients, null},
            }
        };

        #endregion
        
        public TrinityPower GetBuffPower()
        {
            if (ShouldIgnorePain())
                return IgnorePain();

            if (ShouldSprint())
                return Sprint();

            if (ShouldBattleRage())
                return BattleRage();

            if (ShouldWarCry())
                return WarCry();

            if (ShouldCallOfTheAncients())
                return CallOfTheAncients();

            if (ShouldWrathOfTheBerserker())
                return WrathOfTheBerserker();

            return null;
        }


        public TrinityPower GetOffensivePower()
        {
            Vector3 position;
            TrinityActor target;
            TrinityPower power;

            if (ShouldWalkToTarget(out target))
                return Walk(target);

            if (ShouldAncientSpear(out target))
                return AncientSpear(target);

            if (ShouldFuriousCharge(out position))
                return FuriousCharge(position);

            if (TrySecondaryPower(out power))
                return power;

            if (TryPrimaryPower(out power))
                return power;

            //Core.Logger.Log("walking to safespot because all other powers failed");
            Core.Avoidance.Avoider.TryGetSafeSpot(out position, 15f, 40f, Player.Position,
                node => !TargetUtil.AnyMobsInRangeOfPosition(node.NavigableCenter));
            return Walk(position);
        }

        private static bool ShouldWalkToTarget(out TrinityActor target)
        {
            target = null;

            if (CurrentTarget.Distance > 60f)
            {
                Core.Logger.Log("Target too far away to attack. Walking closer");
                target = CurrentTarget;
                return target != null;
            }

            return false;
        }

        protected override bool ShouldAncientSpear(out TrinityActor target)
        {
            target = null;

            if (Player.IsInTown)
                return false;

            if (!Skills.Barbarian.AncientSpear.CanCast())
                return false;

            // No use casting AS if we don't have a lot of Fury
            if (Player.PrimaryResourcePct < 0.9f)
                return false;

            // Fury dumping is useful as a way of healing (if you have Life Per Fury Spent on your gear), or as a means of keeping WotB up
            if (Player.CurrentHealthPct < Settings.DumpHealthPct ||
                Skills.Barbarian.WrathOfTheBerserker.TimeSinceUse > 5000 &&
                !Skills.Barbarian.WrathOfTheBerserker.CanCast())
            {
                //Core.Logger.Log("Casting AncientSpear to Restore Health/Reduce Cooldowns");
                target = TargetUtil.GetBestClusterUnit();
            }

            return target != null;
        }

        protected override bool ShouldFuriousCharge(out Vector3 position)
        {
            position = Vector3.Zero;

            if (!Skills.Barbarian.FuriousCharge.CanCast())
                return false;

            if (!TargetUtil.AnyMobsInRange(60f))
                return false;

            if (Core.Avoidance.Grid.IsIntersectedByFlags(ZetaDia.Me.Position, position, AvoidanceFlags.CriticalAvoidance))
                return false;

            if (Legendary.AncientParthanDefenders.IsEquipped)
                position = TargetUtil.FreezePiercePoint(60f, 6f, true);
            position = TargetUtil.GetBestPiercePoint(60f, 6f);

            return position != Vector3.Zero;
        }

        public TrinityPower GetDefensivePower() => GetBuffPower();

        public TrinityPower GetDestructiblePower() => DefaultDestructiblePower();

        protected override bool ShouldWrathOfTheBerserker()
        {
            if (Player.IsInTown)
                return false;

            // Don't Recast WotB unless the buff is about to end
            if (Core.Buffs.HasBuff(SNOPower.Barbarian_WrathOfTheBerserker) &&
                Core.Buffs.GetBuffTimeRemainingMilliseconds(SNOPower.Barbarian_WrathOfTheBerserker) > 1000)
                return false;

            return base.ShouldWrathOfTheBerserker();
        }

        protected override bool ShouldSprint()
        {
            if (!Skills.Barbarian.Sprint.CanCast())
                return false;

            if (Skills.Barbarian.Sprint.TimeSinceUse < 3750)
                return false;

            return true;
        }

        public TrinityPower GetMovementPower(Vector3 destination)
        {
            var shouldAvoid = Core.Avoidance.Avoider.ShouldAvoid;
            if (CanChargeTo(destination) && (AllowedToUse(Settings.FuriousCharge, Skills.Barbarian.FuriousCharge) || shouldAvoid))
            {
                if (IsBlocked && Skills.Barbarian.FuriousCharge.Charges > 0)
                    return FuriousCharge(destination);

                var chargeRange = Player.Position.Distance(destination);
                if (TargetUtil.TargetsInFrontOfMe(chargeRange, 6f).Count > 3 &&
                    Skills.Barbarian.FuriousCharge.Charges > 0)
                {
                    Core.Logger.Log("Charging through enemy/destructible since it refunds a charge.");
                    return FuriousCharge(destination);
                }

                if (!IsBlocked && Skills.Barbarian.FuriousCharge.Charges > 1)
                    return FuriousCharge(destination);
            } 

            return Walk(destination);
        }

        #region Settings

        public override int ClusterSize => Settings.ClusterSize;
        public override float EmergencyHealthPct => Settings.EmergencyHealthPct;

        IDynamicSetting IRoutine.RoutineSettings => Settings;
        public BarbarianRaekorIKSettings Settings { get; } = new BarbarianRaekorIKSettings();

        public sealed class BarbarianRaekorIKSettings : NotifyBase, IDynamicSetting
        {
            private int _clusterSize;
            private float _emergencyHealthPct;
            private float  _dumpHealthPct;

            [DefaultValue(8)]
            public int ClusterSize
            {
                get => _clusterSize;
                set => SetField(ref _clusterSize, value);
            }

            [DefaultValue(0.4f)]
            public float EmergencyHealthPct
            {
                get => _emergencyHealthPct;
                set => SetField(ref _emergencyHealthPct, value);
            }

            #region FuriousCharge

            public SkillSettings FuriousCharge
            {
                get => _furiousCharge;
                set => SetField(ref _furiousCharge, value);
            }

            private static readonly SkillSettings VaultDefaults = new SkillSettings
            {
                UseMode = UseTime.Default,
                RecastDelayMs = 500,
                Reasons = UseReasons.Blocked
            };

            private SkillSettings _furiousCharge;

            public override void LoadDefaults()
            {
                base.LoadDefaults();
                FuriousCharge = VaultDefaults.Clone();
            }

            #endregion

            #region AncientSpear

            [DefaultValue(0.8f)]
            public float DumpHealthPct
            {
                get => _dumpHealthPct;
                set => SetField(ref _dumpHealthPct, value);
            }

            #endregion

            #region IDynamicSetting

            public string GetName() => GetType().Name;
            public UserControl GetControl() => UILoader.LoadXamlByFileName<UserControl>(GetName() + ".xaml");
            public object GetDataContext() => this;
            public string GetCode() => JsonSerializer.Serialize(this);
            public void ApplyCode(string code) => JsonSerializer.Deserialize(code, this, true);
            public void Reset() => LoadDefaults();

            public void Save()
            {
            }

            #endregion
        }

        #endregion
    }
}
