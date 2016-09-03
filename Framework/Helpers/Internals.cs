﻿using System;
using System.Collections.Generic;
using System.Linq;
using Trinity.Technicals;
using Zeta.Game;
using Zeta.Game.Internals;

namespace Trinity.Framework.Helpers
{
    public static class Internals
    {
        private class BuildMemoryInfo
        {
            public Version Version;
            public IntPtr ObjectManagerPtr;
            public IntPtr SymbolManagerPtr;
            public IntPtr SnoGroupsAddr;
            public IntPtr AttributeDescripterAddr;
            public int GlobalsOffset;
            public int StorageOffset;
        }

        private static BuildMemoryInfo _currentBuild;

        public static class DemonBuddyObjects
        {
            public static ACDManager AcdManager => _acdManager.Value;
            private static readonly StaticRouter<ACDManager> _acdManager = new StaticRouter<ACDManager>(typeof(ZetaDia));

            public static RActorManager RActorManager => _ractorManager.Value;
            private static readonly StaticRouter<RActorManager> _ractorManager = new StaticRouter<RActorManager>(typeof(ZetaDia));

            public static ActivePlayerData ActivePlayerData => _activePlayerData.Value;
            private static readonly StaticRouter<ActivePlayerData> _activePlayerData = new StaticRouter<ActivePlayerData>(typeof(ZetaDia));

            public static IntPtr ObjectManagerAddr => _storageAddr.Value - (int)ObjectManagerOffsets.Storage;
            private static readonly StaticRouter<IntPtr> _storageAddr = new StaticRouter<IntPtr>(typeof(ZetaDia), 0);
        }

        public static class Addresses
        {
            static Addresses()
            {
                // Use the memory info from the most recent version lower than current.
                var d3Version = new Version(ZetaDia.Memory.Process.MainModule.FileVersionInfo.FileVersion.Replace(", ", "."));
                _currentBuild = SupportedBuilds.Where(o => o.Version <= d3Version).OrderBy(o => o.Version).LastOrDefault();
                Logger.LogDebug($"D3: {d3Version}; Data: {_currentBuild?.Version}");
                test();
            }

            public static IntPtr ObjectManager => DemonBuddyObjects.ObjectManagerAddr;
            public static IntPtr RActorManager => DemonBuddyObjects.RActorManager.BaseAddress;
            public static IntPtr AcdManager => DemonBuddyObjects.AcdManager.BaseAddress;
            public static IntPtr ActivePlayerData => DemonBuddyObjects.ActivePlayerData.BaseAddress;
            public static IntPtr SymbolManager => ZetaDia.Memory.Read<IntPtr>(_currentBuild.SymbolManagerPtr);
            public static IntPtr Hero => ZetaDia.Service.Hero.BaseAddress;
            public static IntPtr Globals => ObjectManager + (int)ObjectManagerOffsets.Globals;
            public static IntPtr SnoGroups => _currentBuild.SnoGroupsAddr;
            public static IntPtr AttributeDescripters => _currentBuild.AttributeDescripterAddr;
            public static IntPtr Storage => ObjectManager + (int)ObjectManagerOffsets.Storage;
        }

        public static void test()
        {
            ZetaDia.Actors.Update();
            var t = typeof(Zeta.Game.ZetaDia).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            var v = t.Select(r => r.GetValue(null));

        }

        public enum ObjectManagerOffsets
        {
            Storage = 0x798,
            Globals = 0x790
        }

        private static readonly List<BuildMemoryInfo> SupportedBuilds = new List<BuildMemoryInfo>
        {

            new BuildMemoryInfo
            {
                Version = new Version("2.4.1.36595"),
                ObjectManagerPtr = (IntPtr)0x01E9F8EC,
                SymbolManagerPtr = (IntPtr)0x01EE7598,
                SnoGroupsAddr = (IntPtr)0x1EA0BC8,
                AttributeDescripterAddr = (IntPtr) 0x1EEFE70,
            },
            new BuildMemoryInfo
            {
                Version = new Version("2.4.2.37893"),
                ObjectManagerPtr = (IntPtr)0x1C8755B0,
                SymbolManagerPtr = (IntPtr)0x01F01900,
                SnoGroupsAddr = (IntPtr)0x01EA73A8,
                AttributeDescripterAddr = (IntPtr)0x01EBEB78,
            },
            new BuildMemoryInfo
            {
                Version = new Version("2.4.2.38247"),
                ObjectManagerPtr = (IntPtr)0x01EA60CC,
                SymbolManagerPtr = (IntPtr)0x01F01950,
                SnoGroupsAddr = (IntPtr)0x01EA73A8,
                AttributeDescripterAddr = (IntPtr)0x1EBF020,
            },
            new BuildMemoryInfo
            {
                Version = new Version("2.4.2.38682"),
                ObjectManagerPtr = (IntPtr)0x01EA60D4,
                SymbolManagerPtr = (IntPtr)0x01F01958,
                SnoGroupsAddr = (IntPtr)0x01EA73B0,
                AttributeDescripterAddr = (IntPtr)0x1EBF028,
            },
        };
    }

}