﻿using System;
using Trinity.Framework;
using Trinity.Framework.Helpers;
using System.Collections.Generic;
using System.Linq;
using Trinity.Components.Adventurer.Game.Rift;
using Zeta.Bot;
using Zeta.Common;
using Zeta.Game;

namespace Trinity.Components.Adventurer.Game.Exploration.SceneMapping
{
    public static class DeathGates
    {
        public static Dictionary<SNOScene, DeathGateScene> SceneDefs = new Dictionary<SNOScene, DeathGateScene>();
        private static readonly Dictionary<string, DeathGateScene> _scenes = new Dictionary<string, DeathGateScene>();

        static DeathGates()
        {
            // The top of the d3 minimap is 0,0.
            // X axis increases from top right to bottom left,
            // Y axis increases from top left to bottom right.
            // Scene size of 240/240

            SceneDefs.Add(SNOScene.P6_Lost_Souls_x1_fortress_EW_05_soul_well, new DeathGateScene
            {
                Name = "P6_Lost_Souls_x1_fortress_EW_05_soul_well",
                SnoId = SNOScene.P6_Lost_Souls_x1_fortress_EW_05_soul_well,
                RelativeEnterPosition = new Vector3(186.25f, 76.25f, -74.9f),
                RelativeExitPosition = new Vector3(181.25f, 8.75f, -94.9f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(0, 160, 0, 150, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_island_NW_01, new DeathGateScene
            {
                Name = "x1_fortress_island_NW_01",
                SnoId = SNOScene.x1_fortress_island_NW_01,
                RelativeEnterPosition = new Vector3(87.62366f, 119.2921f, 20.28859f),
                RelativeExitPosition = new Vector3(92.89557f, 182.072f, 10.28859f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(0, 160, 0, 150, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_NE_05_soul_well, new DeathGateScene
            {
                Name = "x1_fortress_NE_05_soul_well",
                SnoId = SNOScene.x1_fortress_NE_05_soul_well,
                RelativeEnterPosition = new Vector3(13.75f, 201.25f, 0.09999714f),
                RelativeExitPosition = new Vector3(97.70514f, 195.0026f, 20.1f),
                Type = DeathGateType.EnterSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(0, 160, 50, 240, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_soul_grinder_A_W01_N01, new DeathGateScene
            {
                Name = "x1_fortress_soul_grinder_A_W01_N01",
                SnoId = SNOScene.x1_fortress_soul_grinder_A_W01_N01,
                RelativeEnterPosition = new Vector3(11.25f, 198.75f, 0.1f),
                RelativeExitPosition = new Vector3(87.75464f, 202.8271f, 0.1f),
                Type = DeathGateType.EnterSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(0, 160, 50, 240, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_island_EW_01, new DeathGateScene
            {
                Name = "x1_fortress_island_EW_01",
                SnoId = SNOScene.x1_fortress_island_EW_01,
                RelativeEnterPosition = new Vector3(87.11646f, 134.7203f, 0.100001f),
                RelativeExitPosition = new Vector3(42.62024f, 103.5811f, -9.899999f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(0, 115, 240, 240, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_island_NS_01, new DeathGateScene
            {
                Name = "x1_fortress_island_NS_01",
                SnoId = SNOScene.x1_fortress_island_NS_01,
                RelativeEnterPosition = new Vector3(158.75f, 151.25f, 10.28859f),
                RelativeExitPosition = new Vector3(96.25f, 118.75f, -9.899998f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(140, 110, 240, 240, CombineType.Subtract)
                }
            });

            //World: x1_fortress_level_02, Id: 271235, AnnId: 1999634434, IsGenerated: True
            //Scene: x1_fortress_island_NE_01, SnoId: 338583,
            //LevelArea: x1_fortress_level_02_islands, Id: 459863

            SceneDefs.Add(SNOScene.x1_fortress_island_NE_01, new DeathGateScene
            {
                Name = "x1_fortress_island_NE_01",
                SnoId = SNOScene.x1_fortress_island_NE_01,
                RelativeEnterPosition = new Vector3(163.245f, 109.2724f, 10.1f),
                RelativeExitPosition = new Vector3(104.1263f, 79.61856f, -9.9f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(140, 0, 240, 240, CombineType.Subtract)
                }
            });

            //World: x1_fortress_level_02, Id: 271235, AnnId: 1999634434, IsGenerated: True
            //Scene: x1_fortress_island_NW_01_Waypoint, SnoId: 459857,
            //LevelArea: x1_fortress_level_02_islands, Id: 459863

            SceneDefs.Add(SNOScene.x1_fortress_island_NW_01_Waypoint, new DeathGateScene
            {
                Name = "x1_fortress_island_NW_01_Waypoint",
                SnoId = SNOScene.x1_fortress_island_NW_01_Waypoint,
                RelativeEnterPosition = new Vector3(90.64246f, 180.9426f, 10.28859f),
                RelativeExitPosition = new Vector3(87.58826f, 118.2887f, 20.28859f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(0, 160, 240, 240, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_island_SW_01, new DeathGateScene
            {
                Name = "x1_fortress_island_SW_01",
                SnoId = SNOScene.x1_fortress_island_SW_01,
                RelativeEnterPosition = new Vector3(191.8892f, 162.4253f, 0.1f),
                RelativeExitPosition = new Vector3(141.25f, 91.25f, -9.9f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    new RectangularRegion(120, 140, 240, 240, CombineType.Subtract)
                }
            });

            SceneDefs.Add(SNOScene.x1_fortress_island_NS_02, new DeathGateScene
            {
                Name = "x1_fortress_island_NS_02",
                SnoId = SNOScene.x1_fortress_island_NS_02,
                RelativeEnterPosition = new Vector3(111.6139f, 55.86285f, -9.900001f),
                RelativeExitPosition = new Vector3(62.54431f, 57.38367f, 10.28859f),
                Type = DeathGateType.ExitSequence
            });

            SceneDefs.Add(SNOScene.x1_fortress_island_EW_02, new DeathGateScene
            {
                Name = "x1_fortress_island_EW_02",
                SnoId = SNOScene.x1_fortress_island_EW_02,
                RelativeEnterPosition = new Vector3(90.86368f, 86.26465f, 10.1f),
                RelativeExitPosition = new Vector3(148.1292f, 107.3582f, 10.1f),
                Type = DeathGateType.ExitSequence,
                Regions = new RegionGroup
                {
                    //new RectangularRegion(120,0,240,160, CombineType.Add),
                    new RectangularRegion(0, 0, 120, 240, CombineType.Subtract),
                    new RectangularRegion(0, 160, 240, 240, CombineType.Subtract)
                }
            });

            GameEvents.OnWorldChanged += GameEventsOnOnWorldChanged;
            Core.Scenes.ScenesAdded += ScenesStorageOnScenesAdded;
            BuildGateScenes(Core.Scenes.CurrentWorldScenes);
        }

        private static void GameEventsOnOnWorldChanged(object sender, EventArgs eventArgs)
        {
            Core.Logger.Verbose("World changed: Scanning for death gates");
            _scenes.RemoveAll(s => s.WorldScene.DynamicWorldId != ZetaDia.Globals.WorldId);
            BuildGateScenes(Core.Scenes.CurrentWorldScenes);
        }

        private static void ScenesStorageOnScenesAdded(List<WorldScene> worldScenes)
        {
            Core.Logger.Verbose("Scenes Updated: Scanning for death gates");
            BuildGateScenes(worldScenes);
        }

        private static void BuildGateScenes(IEnumerable<WorldScene> worldScenes)
        {
            foreach (var scene in worldScenes)
            {
                if (!SceneDefs.ContainsKey(scene.SnoId) || _scenes.ContainsKey(scene.HashName))
                    continue;

                _scenes.Add(scene.HashName, SceneDefs[scene.SnoId].Build(scene));
            }
        }

        public static IEnumerable<DeathGateScene> Scenes => _scenes.Values;
        public static IEnumerable<DeathGateScene> ExitScenes => Scenes.Where(z => z.Type == DeathGateType.ExitSequence && z.IsValid);
        public static IEnumerable<DeathGateScene> EnterScenes => Scenes.Where(z => z.Type == DeathGateType.EnterSequence && z.IsValid);

        /// <summary>
        /// Dynamically create a box around the death gate scenes near the level exit
        /// It can be used to determine if the bot wants to go into a death gated region.
        /// </summary>
        public static RegionGroup ExitRegion
        {
            get
            {
                var gateScenes = ExitScenes.ToList();
                if (!gateScenes.Any())
                    return new RegionGroup();

                var entranceScene = gateScenes.OrderByDescending(s => s.Depth).FirstOrDefault();
                if (entranceScene == null)
                    return new RegionGroup();

                var portalScene = entranceScene.WorldScene;
                var maxX = portalScene.Max.X;
                var maxY = portalScene.Max.Y;

                var mainRegion = new RectangularRegion
                {
                    Min = new Vector2(0, 0),
                    Max = new Vector2(maxX, maxY)
                };

                var group = new RegionGroup { mainRegion };

                foreach (var region in entranceScene.Regions)
                {
                    group.Add(region.GetOffset(portalScene.Min));
                }

                return group;
            }
        }

        public static RegionGroup EnterRegion
        {
            get
            {
                var gateScenes = EnterScenes.ToList();
                if (!gateScenes.Any())
                    return new RegionGroup();

                var entranceScene = gateScenes.OrderBy(s => s.Depth).FirstOrDefault();
                if (entranceScene == null)
                    return new RegionGroup();

                var worldScene = entranceScene.WorldScene;
                var grid = ExplorationGrid.Instance;
                var minX = worldScene.Min.X;
                var minY = worldScene.Min.Y;

                var mainRegion = new RectangularRegion
                {
                    Min = new Vector2(minX, minY),
                    Max = new Vector2(grid.MaxX * grid.BoxSize, grid.MaxY * grid.BoxSize)
                };

                var group = new RegionGroup { mainRegion };

                foreach (var region in entranceScene.Regions)
                {
                    group.Add(region.GetOffset(worldScene.Min));
                }

                return group;
            }
        }

        //public static DeathGateScene CurrentGateScene => CreateSequence().CurrentOrDefault;

        public static DeathGateScene CurrentGateScene
        {
            get
            {
                var scene = Scenes.FirstOrDefault(s => s.WorldScene.IsInScene(AdvDia.MyPosition));
                if (scene != null)
                    return scene;

                return NearestGateEntranceScene(AdvDia.MyPosition);
                //return NearestGateSceneToPosition(AdvDia.MyPosition);
            }
        }

        public static DeathGateScene NextGateScene
        {
            get
            {
                var sequence = CreateSequence();
                return sequence.Next() ? sequence.CurrentOrDefault : null;
            }
        }

        public static DeathGateScene PreviousGateScene
        {
            get
            {
                var sequence = CreateSequence();
                return sequence.Previous() ? sequence.CurrentOrDefault : null;
            }
        }

        public static bool IsInDeathGateWorld => ExplorationData.FortressLevelAreaIds.Contains(AdvDia.CurrentLevelAreaId) || ExplorationData.FortressWorldIds.Contains(AdvDia.CurrentWorldId);
        public static bool IsInOutsideRegion => !IsInExitRegion && !IsInEnterRegion;
        public static bool IsInExitRegion => ExitRegion.Contains(AdvDia.MyPosition);
        public static bool IsInEnterRegion => EnterRegion.Contains(AdvDia.MyPosition);

        public static IEnumerable<DeathGateScene> CurrentRegionScenes
        {
            get
            {
                switch (CurrentGateScene.Type)
                {
                    case DeathGateType.EnterSequence:
                        return EnterScenes;

                    case DeathGateType.ExitSequence:
                        return ExitScenes;
                }
                return null;
            }
        }

        public static DeathGateScene NearestGateScene
        {
            get
            {
                return Scenes.Where(s => s.IsValid)
                    .OrderByDescending(s => s.SnoId == AdvDia.CurrentWorldScene.SnoId)
                    .ThenBy(s => s.WorldScene.Center.Distance(AdvDia.MyPosition.ToVector2())).FirstOrDefault();
            }
        }

        /// <summary>
        /// Order all of the portal scenes and work out where we are within that sequence.
        /// </summary>
        public static IndexedList<DeathGateScene> CreateSequence()
        {
            var gateScene = NearestGateScene;
            if (gateScene == null || gateScene.Distance > 800)
                return new IndexedList<DeathGateScene>();

            var sequence = new IndexedList<DeathGateScene>(CurrentRegionScenes.OrderByDescending(p => p.Depth));

            while (sequence.CurrentOrDefault != null && sequence.Current.SnoId != gateScene.SnoId)
            {
                sequence.Next();
            }

            Core.Logger.Debug($"Current Scene {AdvDia.CurrentWorldScene.Name} ({AdvDia.CurrentWorldScene.SnoId})");
            Core.Logger.Debug($"Closest gate Scene {gateScene.WorldScene.Name} ({gateScene.WorldScene.SnoId}), Sequence={sequence.Index + 1}/{sequence.Count}");
            return sequence;
        }

        public static DeathGateScene NearestGateSceneToPosition(Vector3 position)
        {
            return Scenes.Where(s => s.IsValid).OrderBy(s => s.WorldScene.Center.Distance(position.ToVector2())).FirstOrDefault();
        }

        public static DeathGateScene NearestGateEntranceScene(Vector3 position)
        {
            // Find the first scene connected to a non-death gate scene.
            return Scenes.Where(s => s.IsValid)
                .OrderBy(s => s.WorldScene.Center.Distance(position.ToVector2()))
                .FirstOrDefault(g => g.WorldScene.ConnectedScenes()
                    .Any(s => !SceneDefs.ContainsKey(s.Scene.SnoId)));
        }

        public static Vector3 NearestGateToPosition(Vector3 position)
        {
            return NearestGateSceneToPosition(position).PortalPositions.OrderBy(g => g.Distance(position)).FirstOrDefault();
        }

        public static SceneDepth CompareDepth(Vector3 position, Vector3 targetPosition)
        {
            var myScene = NearestGateSceneToPosition(targetPosition);
            return CompareDepth(myScene, targetPosition);
        }

        public static SceneDepth CompareDepth(DeathGateScene thisScene, Vector3 targetPosition)
        {
            var targetScene = NearestGateSceneToPosition(targetPosition);
            return CompareDepth(thisScene, targetScene);
        }

        public static SceneDepth CompareDepth(DeathGateScene thisScene, DeathGateScene otherScene)
        {
            var sequence = CreateSequence();
            var index = sequence.IndexOf(otherScene);
            if (index >= 0)
            {
                if (index > sequence.Index)
                    return SceneDepth.Deeper;
                if (index < sequence.Index)
                    return SceneDepth.Shallower;
                if (index == sequence.Index)
                    return SceneDepth.Same;
            }
            return SceneDepth.NotFound;
        }

        public static GateSide MySide
            => GetSide(NearestGateSceneToPosition(AdvDia.MyPosition), AdvDia.MyPosition);

        public static GateSide GetSide(DeathGateScene scene, Vector3 position)
        {
            if (scene == null || !scene.IsValid) return GateSide.None;
            var exitIsCloser = scene.DeepPortalPosition.Distance(position) < scene.ShallowPortalPosition.Distance(position);
            return exitIsCloser ? GateSide.DeepSide : GateSide.ShallowSide;
        }

        /// <summary>
        /// Get the position of the closest death gate that must be used to reach a destination.
        /// </summary>
        public static Vector3 GetBestGatePosition(Vector3 destination)
        {
            var enterRegion = EnterRegion;
            var exitRegion = ExitRegion;
            var playerInExitRegion = exitRegion.Contains(AdvDia.MyPosition);
            var playerInEnterRegion = enterRegion.Contains(AdvDia.MyPosition);

            var destinationInExitRegion = exitRegion.Contains(destination);
            if (destinationInExitRegion)
                Core.Logger.Debug("Destination inside exit region");

            var destinationInEnterRegion = enterRegion.Contains(destination);
            if (destinationInEnterRegion)
                Core.Logger.Debug("Destination inside enter region");

            var currentScene = CurrentGateScene;
            var targetScene = NearestGateSceneToPosition(destination);

            // rifts are not so predictable, and they can have normal scenes between death gate scenes.
            if (AdvDia.RiftQuest.Step != RiftStep.NotStarted)
            {
                // handle target destinations that are within a death gate scene.
                var sceneClickedInside = Scenes.FirstOrDefault(s => s.WorldScene != null && s.WorldScene.IsInScene(destination));
                if (sceneClickedInside != null)
                {
                    // handle player within death gate scene wanting to go to the other side.
                    var playerInScene = sceneClickedInside.WorldScene.IsInScene(AdvDia.MyPosition);
                    if (playerInScene)
                    {
                        var myCurrentSide = GetSide(sceneClickedInside, AdvDia.MyPosition);
                        return myCurrentSide == GateSide.DeepSide ? sceneClickedInside.DeepPortalPosition : sceneClickedInside.ShallowPortalPosition;
                    }

                    Core.Logger.Debug("Selecting closest death gate to player. (In Rift)");
                    return sceneClickedInside.ClosestGateToPosition(AdvDia.MyPosition);
                }

                // closest portal to destination.
                return Scenes.SelectMany(s => s.PortalPositions).OrderBy(p => p.Distance(destination)).FirstOrDefault();
            }

            // go into entrance region
            if (!playerInEnterRegion && destinationInEnterRegion && !playerInExitRegion)
            {
                var regionEnterScene = EnterScenes.OrderBy(s => s.Depth).FirstOrDefault();
                if (regionEnterScene != null)
                    return regionEnterScene.ShallowPortalPosition;
            }

            // go into exit region
            if (!playerInExitRegion && destinationInExitRegion && !playerInEnterRegion)
            {
                var regionEnterScene = ExitScenes.OrderByDescending(s => s.Depth).FirstOrDefault();
                if (regionEnterScene != null)
                    return regionEnterScene.ShallowPortalPosition;
            }

            var targetDepth = CompareDepth(currentScene, targetScene);
            var mySide = GetSide(currentScene, AdvDia.MyPosition);

            if (playerInExitRegion && mySide == GateSide.DeepSide && targetDepth == SceneDepth.Same)
                return Vector3.Zero;

            var leaveEntranceRegion = playerInEnterRegion && !destinationInEnterRegion;
            var leaveExitRegion = playerInExitRegion && !destinationInExitRegion;
            var withinExitRegion = playerInExitRegion && destinationInExitRegion;
            var withinEntranceRegion = playerInEnterRegion && destinationInEnterRegion;

            if (leaveEntranceRegion || leaveExitRegion || withinExitRegion || withinEntranceRegion)
            {
                Vector3 bestGatePosition;
                if (TrySelectGate(mySide, targetDepth, out bestGatePosition))
                    return bestGatePosition;
            }

            return Vector3.Zero;
        }

        public static Vector3 SelectGate(DeathGateScene fromScene, DeathGateScene toScene)
        {
            Vector3 bestGatePosition;
            return TrySelectGate(MySide, CompareDepth(fromScene, toScene), out bestGatePosition)
                ? bestGatePosition
                : Vector3.Zero;
        }

        /// <summary>
        /// Pick the correct gate from the current sequence for a given target direction and current position.
        /// </summary>
        /// <param name="mySide">indicates which side of a death gate devide the player is currently, DeepSide is towards 0,0/exit; ShallowSide is towards the world entrance</param>
        /// <param name="targetDepth">indicates which direction the destination is in, Deeper is towards 0,0/exit; Shallower is towards the world entrance</param>
        /// <param name="bestGatePosition">the position of the gate that is required to reach the destination</param>
        /// <returns></returns>
        public static bool TrySelectGate(GateSide mySide, SceneDepth targetDepth, out Vector3 bestGatePosition)
        {
            Core.Logger.Debug($"TrySelectGate MyCurrentSide={mySide} TargetDepth={targetDepth}");

            if (mySide == GateSide.DeepSide)
            {
                switch (targetDepth)
                {
                    case SceneDepth.Deeper:
                        bestGatePosition = NextGateScene.ShallowPortalPosition;
                        return true;

                    case SceneDepth.Same:
                        bestGatePosition = CurrentGateScene.DeepPortalPosition;
                        return true;

                    case SceneDepth.Shallower:
                        bestGatePosition = CurrentGateScene.DeepPortalPosition;
                        return true;

                    case SceneDepth.NotFound:
                        bestGatePosition = CurrentGateScene.DeepPortalPosition;
                        return true;
                }
            }

            if (mySide == GateSide.ShallowSide)
            {
                switch (targetDepth)
                {
                    case SceneDepth.Deeper:
                        bestGatePosition = CurrentGateScene.ShallowPortalPosition;
                        return true;

                    case SceneDepth.Same:
                        bestGatePosition = CurrentGateScene.ShallowPortalPosition;
                        return true;

                    case SceneDepth.Shallower:
                        bestGatePosition = PreviousGateScene.DeepPortalPosition;
                        return true;

                    case SceneDepth.NotFound:
                        bestGatePosition = CurrentGateScene.ShallowPortalPosition;
                        return true;
                }
            }
            bestGatePosition = Vector3.Zero;
            return false;
        }

        public static bool TryCurrentSidePortalPosition(GateSide mySide, out Vector3 bestGatePosition)
        {
            switch (mySide)
            {
                case GateSide.DeepSide:
                    bestGatePosition = CurrentGateScene.DeepPortalPosition;
                    return true;

                case GateSide.ShallowSide:
                    bestGatePosition = CurrentGateScene.ShallowPortalPosition;
                    return true;
            }

            bestGatePosition = Vector3.Zero;
            return false;
        }
    }
}