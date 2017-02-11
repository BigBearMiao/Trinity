using System;
using Trinity.Components.Adventurer.Game.Actors;
using Trinity.Framework;
using Trinity.Framework.Helpers;
using Trinity.Framework.Objects;
using Trinity.Settings;
using Zeta.Bot;

namespace Trinity.Modules
{
    /// <summary>
    /// Stops the bot when certain conditions are met
    /// </summary>
    public class GameStopper : Module
    {
        protected override int UpdateIntervalMs => 1000;

        public const int RiftStoneSNO = 364715;
        public const int RiftEntryPortalSNO = 345935;
        public const int GreaterRiftEntryPortalSNO = 396751;
        public const int OrekSNO = 363744;
        public const int UrshiSNO = 398682;
        public const int TownstoneSNO = 135248;
        public const int HolyCowSNO = 209133;
        public const int GreaterRiftKeySNO = 408416;
        public const int DeathGateSNO = 328830;

        protected override void OnPulse()
        {
            if (!BotMain.IsRunning)
                return;

            if (ActorFinder.FindNearestDeathGate() != null)
                BotMain.Stop();

            var reasons = Core.Settings.Advanced.StopReasons;
            if (reasons != GameStopReasons.None)
            {
                foreach(var actor in Core.Actors.AllRActors)
                {
                    if (actor.IsTreasureGoblin && reasons.HasFlag(GameStopReasons.GoblinFound))
                        Stop("Goblin Found");

                    if (actor.ActorSnoId == UrshiSNO && reasons.HasFlag(GameStopReasons.UrshiFound))
                        Stop("Urshi Found");

                    if (actor.ActorSnoId == DeathGateSNO && reasons.HasFlag(GameStopReasons.DeathGateFound))
                        Stop("Death Gate Found");

                }
            }
        }

        private void Stop(string reason)
        {
            Logger.Warn($"Game Stopped: {reason}");
            BotMain.Stop();
        }
    }
}
