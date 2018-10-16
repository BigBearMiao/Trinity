﻿using System;
using Trinity.Framework.Actors.ActorTypes;
using Trinity.Framework.Objects;
using Trinity.Framework.Reference;
using Trinity.Settings;
using Zeta.Common;
using Zeta.Game;
using Zeta.Game.Internals.SNO;

namespace Trinity.Framework.Actors.Properties
{
    public class GizmoProperties
    {
        public static void Populate(TrinityActor actor)
        {
        }

        private static bool IsValidGizmo(TrinityActor actor)
        {
            if (actor.ActorType != ActorType.Gizmo)
                return false;

            if (!actor.IsAcdBased || !actor.IsAcdValid)
                return false;

            return true;
        }

        public static void Update(TrinityActor actor)
        {
        }

        public static ShrineTypes GetShrineType(TrinityActor cacheObject)
        {
            switch (cacheObject.ActorSnoId)
            {
                case (int)SNOActor.a4_Heaven_Shrine_Global_Fortune:
                case (int)SNOActor.Shrine_Global_Fortune:
                    return ShrineTypes.Fortune;

                case (int)SNOActor.a4_Heaven_Shrine_Global_Frenzied:
                case (int)SNOActor.Shrine_Global_Frenzied:
                    return ShrineTypes.Frenzied;

                case (int)SNOActor.a4_Heaven_Shrine_Global_Reloaded:
                case (int)SNOActor.Shrine_Global_Reloaded:
                    return ShrineTypes.RunSpeed;

                case (int)SNOActor.a4_Heaven_Shrine_Global_Enlightened:
                case (int)SNOActor.Shrine_Global_Enlightened:
                    return ShrineTypes.Enlightened;

                case (int)SNOActor.Shrine_Global_Glow:
                    return ShrineTypes.Glow;

                case (int)SNOActor.a4_Heaven_Shrine_Global_Hoarder:
                case (int)SNOActor.Shrine_Global_Hoarder:
                    return ShrineTypes.Hoarder;

                case (int)SNOActor.x1_LR_Shrine_Infinite_Casting:
                    return ShrineTypes.Casting;

                case (int)SNOActor.x1_LR_Shrine_Electrified_TieredRift:
                case (int)SNOActor.x1_LR_Shrine_Electrified:
                    return ShrineTypes.Conduit;

                case (int)SNOActor.x1_LR_Shrine_Invulnerable:
                case (int)SNOActor.x1_LR_Shrine_Run_Speed:
                    return ShrineTypes.Shield;

                case (int)SNOActor.x1_LR_Shrine_Damage:
                    return ShrineTypes.Damage;


                case (int)SNOActor.Shrine_TreasureGoblin:
                    return ShrineTypes.Goblin;

                default:
                    return ShrineTypes.None;
            }
        }

        public static ContainerTypes GetContainerType(TrinityActor cacheObject)
        {
            if (cacheObject.IsRareChest || cacheObject.IsChest)
                return ContainerTypes.NormalChest;

            if (cacheObject.IsWeaponRack)
                return ContainerTypes.WeaponRack;

            if (cacheObject.IsGroundClicky)
                return ContainerTypes.GroundClicky;

            if (cacheObject.IsCorpse)
                return ContainerTypes.Corpse;

            if (cacheObject.IsContainer)
                return ContainerTypes.Other;

            return ContainerTypes.None;
        }



        public static bool GetIsGizmoUsed(TrinityActor actor)
        {
            var attributes = actor.Attributes;
            if (attributes != null)
            {
                if (attributes.IsGizmoDisabledByScript)
                    return true;

                if (attributes.IsDoorLocked)
                    return true;

                if (attributes.GizmoCharges > 0)
                    return false;

                if (actor.IsUnit && attributes.GizmoState == 1 && !attributes.IsQuestMonster)
                    return true;

                if (attributes.GizmoOperatorACDId > 0)
                    return true;

                if (attributes.IsGizmoBeenOperated)
                    return true;

                // a3dun_Keep_Bridge_Switch-12283 (56686) Type=Interactable  is used with _open anim and gizmostate = 1
                if (actor.GizmoType == GizmoType.Switch && actor.AnimationNameLowerCase.Contains("_open") && attributes.GizmoState == 0)
                    return false;

                if (attributes.IsChestOpen)
                    return true;

                if (actor.IsChest && attributes.GizmoState == 1)
                    return false;

                if (actor.GizmoType == GizmoType.PowerUp && attributes.GizmoState == 1)
                    return true;

                //if (actor.GizmoType == GizmoType.Door && attributes.GizmoState == 1)
                //    return false;

                if (attributes.GizmoState == 1)
                    return true;

                if (actor.Type == TrinityObjectType.Barricade && attributes.IsNoDamage)
                    return true;

                if (actor.Type == TrinityObjectType.Destructible || actor.Type == TrinityObjectType.Barricade)
                {
                    if (actor.IsUntargetable || actor.IsInvulnerable || actor.HitPoints < double.Epsilon)
                        return true;

                    if (attributes.IsDeletedOnServer)
                        return true;
                }
            }

            if (actor.IsInteractableType && GameData.InteractEndAnimations.TryGetValue(actor.ActorSnoId, out var endAnimation)
                && endAnimation == (int)actor.Animation)
                return true;

            switch (actor.Type)
            {
                case TrinityObjectType.Door:
                case TrinityObjectType.Container:
                case TrinityObjectType.Interactable:
                case TrinityObjectType.Destructible:
                    var currentAnimation = actor.AnimationNameLowerCase;

                    if (currentAnimation.Contains("irongate") && currentAnimation.Contains("open"))
                        return false;

                    if (currentAnimation.Contains("_dead"))
                        return true;

                    if (currentAnimation.Contains("irongate") && currentAnimation.Contains("idle"))
                        return true;

                    if (currentAnimation.EndsWith("open") || currentAnimation.EndsWith("opening"))
                        return true;

                    break;
            }

            return false;
        }

    }
}




