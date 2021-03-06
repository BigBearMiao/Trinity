﻿namespace Trinity.Framework.Objects.Enums
{
    /// <summary>
    /// GameBalanceName with value as NormalHash of GameBalanceName (used as id for string list groups)
    /// Excludes Quests and Conversations because there's like 5000 of them.
    /// </summary>
    public enum SnoStringListType
    {
        Bnet_ContextMenus = 120962,
        ItemSets = 123197,
        Bnet_Strings = 123631,
        RareNameStrings_Prefix_ArcaneResist = 130726,
        RareNameStrings_Prefix_Block = 130727,
        RareNameStrings_Prefix_ColdResist = 130729,
        RareNameStrings_Prefix_Critical = 130730,
        RareNameStrings_Prefix_Damage = 130731,
        RareNameStrings_Prefix_Intelligence = 130733,
        RareNameStrings_Prefix_Dex = 130734,
        RareNameStrings_Prefix_DamageReduction = 130735,
        RareNameStrings_Prefix_Experience = 130737,
        RareNameStrings_Prefix_FireResist = 130739,
        RareNameStrings_Prefix_HitLife = 130740,
        RareNameStrings_Prefix_Gold = 130742,
        RareNameStrings_Prefix_Haste = 130744,
        RareNameStrings_Prefix_HealthGlobe = 130745,
        RareNameStrings_Prefix_HolyDamage = 130746,
        RareNameStrings_Prefix_ArcaneDamage = 130747,
        RareNameStrings_Prefix_ColdDamage = 130748,
        RareNameStrings_Prefix_FireDamage = 130749,
        RareNameStrings_Prefix_Kings = 130752,
        RareNameStrings_Prefix_Life = 130753,
        RareNameStrings_Prefix_LightningDamage = 130755,
        RareNameStrings_Prefix_LightningResist = 130756,
        RareNameStrings_Prefix_PoisonDamage = 130758,
        RareNameStrings_Prefix_PoisonResist = 130759,
        RareNameStrings_Prefix_Regen = 130760,
        RareNameStrings_Prefix_CCReduction = 130761,
        RareNameStrings_Prefix_Run = 130762,
        RareNameStrings_Prefix_Sockets = 130763,
        RareNameStrings_Prefix_Strength = 130764,
        RareNameStrings_Prefix_Thorns = 130765,
        RareNameStrings_Prefix_Vit = 130766,
        LoreSignatures = 135049,
        HeroDetails = 135368,
        Hero = 135636,
        Bnet_Errors = 139797,
        Bnet_Tooltips = 140477,
        Inventory = 146584,
        Zones = 147808,
        Tutorials = 154991,
        Bnet_HeroSelect = 167219,
        Bnet_Login = 167227,
        Bnet_Footer = 167233,
        LoreUI = 168197,
        SkillsUI = 168315,
        Bnet_Profile = 184594,
        Bnet_AuctionHouse = 184599,
        Bnet_Toast = 189730,
        Bnet_Classes = 189790,
        Bnet_Social = 189867,
        Bnet_CallToArms = 189890,
        Bnet_GameMode = 190159,
        Bnet_HeroCreate = 190175,
        Bnet_InGameMenu = 190176,
        Bnet_Party = 190183,
        Bnet_Notifications = 190184,
        Bnet_Campaign = 192938,
        Bnet_PublicGamesList = 196628,
        Bnet_BannerCustomization = 197806,
        Achievements = 199505,
        Bnet_EscapeMenu = 202956,
        Bnet_MatchMaking = 203635,
        Bnet_GameAccess = 206126,
        Bnet_Chat = 206226,
        BannerColors = 213073,
        RareNameStrings_Suffix_ArcaneDamage = 213605,
        RareNameStrings_Suffix_ArcaneResist = 213606,
        RareNameStrings_Suffix_Strength = 213607,
        RareNameStrings_Suffix_Block = 213608,
        RareNameStrings_Suffix_ColdDamage = 213610,
        RareNameStrings_Suffix_ColdResist = 213611,
        RareNameStrings_Suffix_Critical = 213612,
        RareNameStrings_Suffix_Damage = 213613,
        RareNameStrings_Suffix_DamageReduction = 213614,
        RareNameStrings_Suffix_Intelligence = 213615,
        RareNameStrings_Suffix_Dex = 213617,
        RareNameStrings_Suffix_Experience = 213618,
        RareNameStrings_Suffix_FireDamage = 213619,
        RareNameStrings_Suffix_FireResist = 213621,
        RareNameStrings_Suffix_Gold = 213622,
        RareNameStrings_Suffix_Haste = 213623,
        RareNameStrings_Suffix_HealthGlobe = 213624,
        RareNameStrings_Suffix_HitLife = 213625,
        RareNameStrings_Suffix_HolyDamage = 213626,
        RareNameStrings_Suffix_Kings = 213628,
        RareNameStrings_Suffix_Life = 213629,
        RareNameStrings_Suffix_LightningDamage = 213631,
        RareNameStrings_Suffix_LightningResist = 213633,
        RareNameStrings_Suffix_PoisonDamage = 213635,
        RareNameStrings_Suffix_PoisonResist = 213636,
        RareNameStrings_Suffix_Regen = 213637,
        RareNameStrings_Suffix_CCReduction = 213638,
        RareNameStrings_Suffix_Run = 213639,
        RareNameStrings_Suffix_Sockets = 213640,
        RareNameStrings_Suffix_Thorns = 213641,
        RareNameStrings_Suffix_Vit = 213642,
        RareNameStrings_Prefix_Armor_Amulet = 213643,
        RareNameStrings_Prefix_Armor_Belt = 213644,
        RareNameStrings_Prefix_Armor_Boots = 213645,
        RareNameStrings_Prefix_Armor_Bracers = 213646,
        RareNameStrings_Prefix_Armor_Chest = 213647,
        RareNameStrings_Prefix_Armor_Gloves = 213648,
        RareNameStrings_Prefix_Armor_Helm = 213649,
        RareNameStrings_Prefix_Armor_Leg = 213650,
        RareNameStrings_Prefix_Armor_Shield = 213651,
        RareNameStrings_Prefix_Armor_Shoulder = 213652,
        RareNameStrings_Prefix_Weapon_Quiver = 213653,
        RareNameStrings_Prefix_Armor_Ring = 213654,
        RareNameStrings_Prefix_Weapon_Bow = 213655,
        RareNameStrings_Prefix_Weapon_Dagger = 213656,
        RareNameStrings_Prefix_Weapon_Fist = 213657,
        RareNameStrings_Prefix_Weapon_Orb = 213658,
        RareNameStrings_Prefix_Weapon_Spears = 213659,
        RareNameStrings_Prefix_Weapon_Staff = 213660,
        RareNameStrings_Prefix_Weapon_SwingBlade = 213661,
        RareNameStrings_Prefix_Weapon_SwingBlunt = 213662,
        RareNameStrings_Prefix_Weapon_Wand = 213663,
        RareNameStrings_Suffix_Armor_Amulet = 213664,
        RareNameStrings_Suffix_Armor_Belt = 213665,
        RareNameStrings_Suffix_Armor_Boots = 213666,
        RareNameStrings_Suffix_Armor_Bracers = 213667,
        RareNameStrings_Suffix_Armor_Chest = 213668,
        RareNameStrings_Suffix_Armor_Gloves = 213669,
        RareNameStrings_Suffix_Armor_Helm = 213670,
        RareNameStrings_Suffix_Armor_Leg = 213671,
        RareNameStrings_Suffix_Armor_Shield = 213672,
        RareNameStrings_Suffix_Armor_Shoulder = 213673,
        RareNameStrings_Suffix_Weapon_Quiver = 213674,
        RareNameStrings_Suffix_Armor_Ring = 213675,
        RareNameStrings_Suffix_Weapon_Bow = 213677,
        RareNameStrings_Suffix_Weapon_Dagger = 213678,
        RareNameStrings_Suffix_Weapon_Fist = 213679,
        RareNameStrings_Suffix_Weapon_Orb = 213680,
        RareNameStrings_Suffix_Weapon_Spears = 213681,
        RareNameStrings_Suffix_Weapon_Staff = 213682,
        RareNameStrings_Suffix_Weapon_SwingBlade = 213684,
        RareNameStrings_Suffix_Weapon_SwingBlunt = 213685,
        RareNameStrings_Suffix_Weapon_Wand = 213686,
        RareNameStrings_Suffix_Armor_Cloak = 213958,
        RareNameStrings_Prefix_Armor_Cloak = 213959,
        RareNameStrings_Prefix_Weapon_Mojo = 213972,
        RareNameStrings_Suffix_Weapon_Mojo = 213976,
        RareNameStrings_Prefix_Armor_Spiritstone = 214003,
        RareNameStrings_Suffix_Armor_Spiritstone = 214004,
        RareNameStrings_Prefix_Armor_WizardHat = 214005,
        RareNameStrings_Suffix_Armor_WizardHat = 214006,
        RareNameStrings_Prefix_Armor_VoodooMask = 214007,
        RareNameStrings_Suffix_Armor_VoodooMask = 214008,
        RareNameStrings_Prefix_MaxFury = 214088,
        RareNameStrings_Suffix_MaxFury = 214089,
        RareNameStrings_Prefix_FuryHeal = 214091,
        RareNameStrings_Suffix_FuryHeal = 214092,
        RareNameStrings_Prefix_HatredRegen = 214093,
        RareNameStrings_Suffix_HatredRegen = 214094,
        RareNameStrings_Prefix_MaxDis = 214102,
        RareNameStrings_Suffix_MaxDis = 214103,
        RareNameStrings_Prefix_SpiritRegen = 214106,
        RareNameStrings_Suffix_SpiritRegen = 214107,
        RareNameStrings_Prefix_SpiritHeal = 214108,
        RareNameStrings_Suffix_SpiritHeal = 214109,
        RareNameStrings_Prefix_ArcaneCrit = 214115,
        RareNameStrings_Suffix_ArcaneCrit = 214116,
        RareNameStrings_Prefix_ManaRegen = 214120,
        RareNameStrings_Suffix_ManaRegen = 214121,
        RareNameStrings_Prefix_HitMana = 214136,
        RareNameStrings_Suffix_HitMana = 214137,
        RareNameStrings_Prefix_ResistAll = 214189,
        RareNameStrings_Suffix_ResistAll = 214197,
        RareNameStrings_Prefix_StrengthDexterity = 214202,
        RareNameStrings_Suffix_StrengthDexterity = 214203,
        RareNameStrings_Prefix_StrengthIntelligence = 214206,
        RareNameStrings_Suffix_StrengthIntelligence = 214208,
        RareNameStrings_Prefix_StrengthVitality = 214209,
        RareNameStrings_Suffix_StrengthVitality = 214210,
        RareNameStrings_Prefix_DexterityIntelligence = 214211,
        RareNameStrings_Suffix_DexterityIntelligence = 214212,
        RareNameStrings_Prefix_DexterityVitality = 214213,
        RareNameStrings_Suffix_DexterityVitality = 214214,
        RareNameStrings_Prefix_IntelligenceVitality = 214215,
        RareNameStrings_Suffix_IntelligenceVitality = 214216,
        BannerPatterns = 216344,
        BannerShapes = 216345,
        BannerAccents = 216346,
        BannerSigils = 216347,
        BannerSigilPlacements = 216349,
        KeyNames = 216370,
        Bnet_Achievements = 217104,
        VoteKick = 217610,
        Emotes = 217715,
        GameOptions = 220538,
        RareNameStrings_Prefix_HitFear = 222658,
        RareNameStrings_Suffix_HitFear = 222659,
        RareNameStrings_Suffix_HitStun = 222660,
        RareNameStrings_Prefix_HitStun = 222661,
        FollowerDetails = 222903,
        RareNameStrings_Prefix_Armor_Follower = 225331,
        RareNameStrings_Suffix_Armor_Follower = 225332,
        Credits = 225559,
        MonsterTypes = 226433,
        ChatCommands = 226605,
        Bnet_PublicChat = 228114,
        SkillPane = 228363,
        Bnet_Cinematics = 230142,
        Accolades = 236318,
        Currency = 238392,
        ItemPassivePowerDescriptions = 244675,
        PvPLoadscreenTips = 255911,
        Mail = 260991,
        ColorPicker = 261482,
        Bnet_Rewards = 265885,
        Guild = 282306,
        x1_Credits = 287193,
        X1_CreditsUI = 305853,
        X1_RareNameStrings_Prefix_WrathRegen = 309399,
        X1_RareNameStrings_Suffix_WrathRegen = 309405,
        X1_Challenge = 311424,
        X1_Waypoint = 324348,
        X1_DevilsHand = 325548,
        Bnet_GameSettings = 333334,
        X1_DungeonFinderPrefixes = 340709,
        X1_DungeonFinderNouns = 340710,
        X1_OpenWorld = 343239,
        MonsterFamilies = 343465,
        WaypointMap = 346582,
        DemoVictory = 349364,
        X1_RareNameStrings_Suffix_CooldownReduction = 354662,
        X1_RareNameStrings_Prefix_CooldownReduction = 354665,
        Bnet_WhatsNew = 361279,
        RareNameStrings_Prefix_BonusFire = 368854,
        RareNameStrings_Prefix_BonusCold = 368855,
        RareNameStrings_Prefix_BonusHoly = 368856,
        RareNameStrings_Prefix_BonusLightning = 368857,
        RareNameStrings_Prefix_BonusPoison = 368858,
        RareNameStrings_Prefix_BonusArcane = 368859,
        X1_RareNameStrings_Prefix_SplashDamage = 368862,
        X1_RareNameStrings_Suffix_SplashDamage = 368863,
        X1_RareNameStrings_Prefix_ResourceCostReduction = 368864,
        X1_RareNameStrings_Suffix_ResourceCostReduction = 368865,
        RareNameStrings_Suffix_BonusFire = 368867,
        RareNameStrings_Suffix_BonusCold = 368868,
        RareNameStrings_Suffix_BonusHoly = 368869,
        RareNameStrings_Suffix_BonusLightning = 368870,
        RareNameStrings_Suffix_BonusPoison = 368871,
        RareNameStrings_Suffix_BonusArcane = 368872,
        RareNameStrings_Prefix_BonusPhysical = 374910,
        RareNameStrings_Suffix_BonusPhysical = 374912,
        Bnet_LeaderBoards = 389755,
        X1_ConsoleCallouts = 391647,
        NephalemRift = 402632,
        LoadscreenTips_Always = 409874,
        LoadscreenTips_LowLevel = 409875,
        LoadscreenTips_HighLevel = 409876,
        X1_LoadscreenTips_Always = 409877,
        X1_LoadscreenTips_LowLevel = 409878,
        X1_LoadscreenTips_HighLevel = 409879,
        Bnet_Store = 425936,
        p2_HQ_CursedRealm_Descriptions = 429696,
        Platinum_General = 430375,
        BnetStore_ItemDescriptions = 430668,
        LoadscreenTips_FreeToPlay = 433849,
        Kanais_Cube = 436001,
        MessagesBenchmarks = 437251,
        MessagesCursedSoul = 439198,
        KanaisRecipes = 439623,
        KanaisIngredients = 439624,
        Bnet_SeasonJourney = 439817,
        KanaisFlavorText = 440044,
        MessagesSetDungeons = 444233,
        p4_SetDung_Descriptions = 446322,
        p4_SetDung_Titles = 446337,
        p4_SetDung_Completion = 447307,
        p4_SetDung_Messages = 447367,
        Affixes = 51476,
        AttributeDescriptions = 51480,
        Invalid = 51482,
        BlizzCon = 51485,
        Callouts = 51490,
        DesignerDialog = 51996,
        Errors = 52001,
        General = 52002,
        Gizmos = 52003,
        H2OLayout = 52004,
        Followers = 52005,
        ItemDescriptions = 52006,
        ItemPowers = 52007,
        Items = 52008,
        ItemTypeNames = 52009,
        LevelAreaNames = 52014,
        Lore = 52015,
        Map = 52017,
        MonsterAffixNames = 52018,
        MonsterFlavors = 52019,
        MonsterNames = 52020,
        Monsters = 52021,
        NPCOptions = 52022,
        Pets = 52024,
        PlayerTitles = 52025,
        Powers = 52026,
        PvP = 52030,
        Recipes = 52092,
        RequiredAttributes = 52093,
        Shop = 52097,
        Stash = 52100,
        TimedEvents = 52103,
        UIPowers = 52104,
        UIToolTips = 52105,
        Salvage = 52659,
        Minimap = 61539,
        Messages = 61767,
        Trade = 72722,
        ItemInstructions = 76981,
        ItemQuality = 77010,
        ItemSlots = 77407,
        BuffTooltips = 77545,
        Vendor = 77570,
        Boss_Strings = 77865,
        ItemFlavor = 87075,
    }
}