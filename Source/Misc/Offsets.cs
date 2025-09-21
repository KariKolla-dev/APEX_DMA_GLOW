namespace Offsets
{
    public struct Miscellaneous
    {
        public const uint LevelName = 0x1b99724; //[Miscellaneous]->LevelName
        public const uint Gamemode = 0x26dbd10 + 0x50;    //mp_gamemode
        public const uint LocalPlayer = 0x26a2578; //[Miscellaneous]->LocalPlayer
        public const uint EntityList = 0x6190778; //[Miscellaneous]->cl_entitylist
        public const uint NameList = 0x8bc2790; //[Miscellaneous]->NameList
        public const uint ViewRender = 0x3c81f10; //[Miscellaneous]->ViewRender
        public const uint ViewMatrix = 0x11A350; //[Miscellaneous]->ViewMatrix
    }
    
    public struct NameList
    {
        public const uint Index = 0x38; //nameIndex
    }

    public struct Player
    {
        public const uint Model = 0x0030; //m_ModelName
        public const uint WeaponHandle = 0x19b4; //[RecvTable.DT_BaseCombatCharacter]->m_latestPrimaryWeapons
        public const uint OffWeaponHandle = 0x19c4; //[RecvTable.DT_BaseCombatCharacter]->m_latestNonOffhandWeapons
        public const uint LastVisibleTime = 0x1a54; //[Miscellaneous]->CPlayer!lastVisibleTime
        public const uint LastAimedAtTime = 0x19a8; //[Miscellaneous]->CWeaponX!lastCrosshairTargetTime
        public const uint TimeBase = 0x2150; //[DataMap.C_Player]->m_currentFramePlayer.timeBase
        public const uint LifeState = 0x690; //[RecvTable.DT_Player]->m_lifeState
        public const uint Health = 0x324; //[RecvTable.DT_Player]->m_iHealth
        public const uint MaxHealth = 0x468; //[RecvTable.DT_Player]->m_iMaxHealth
        public const uint Shield = 0x1a0; //[RecvTable.DT_TitanSoul]->m_shieldHealth
        public const uint MaxShield = 0x1a4; //[RecvTable.DT_TitanSoul]->m_shieldHealthMax
        public const uint Name = 0x479; //[RecvTable.DT_BaseEntity]->m_iName
        public const uint BleedoutState = 0x2820; //[RecvTable.DT_Player]->m_bleedoutState
        public const uint XP = 0x3874; //[RecvTable.DT_Player]->m_xp
        public const uint Yaw = 0x2304 - 0x8; //[DataMap.C_Player]->m_currentFramePlayer.m_ammoPoolCount - 0x8
        public const uint ViewAngles = 0x25fc - 0x14; //[DataMap.C_Player]->m_ammoPoolCapacity - 0x14
        public const uint SkyDiveStatus = 0x48b4; //m_skydiveState
        public const uint ViewModel = 0x2e50;   //m_hViewModels
    }

    public struct Weapon
    {
        public const uint Index = 0x15e0; //[RecvTable.DT_WeaponX]->m_weaponNameIndex
        public const uint Skin = 0x0d68; //m_nSkin
    }

    public struct BaseEntity
    {
        public const uint Position = 0x17c; //[DataMap.C_BaseEntity]->m_vecAbsOrigin
        public const uint TeamID = 0x334; //[RecvTable.DT_BaseEntity]->m_iTeamNum
        public const uint SquadID = 0x340; //[RecvTable.DT_BaseEntity]->m_squadID
        public const uint Name = 0x0481; //[RecvTable.DT_BaseEntity]->m_iName
    }

    public struct Glow
    {
        public const uint HighlightTypeSize = 0x34; //OFFSET_HIGHLIGHT_TYPE_SIZe
        public const uint ThroughWall = 0x29C; //Script_Highlight_SetVisibilityType
        public const uint Fix = 0x298;
        public const uint Highlight_ID = 0x298; //[DT_HighlightSettings].m_highlightServerActiveStates
        public const uint Highlights = 0x68da420; //HighlightSettings
        public const uint Enable = 0x28C; //Script_Highlight_GetCurrentContext
    }

    public struct Spectator
    {
        public const uint List = 0x01f60fa0 + 0x20C8; //IDA signature >> [48 8B 0D ? ? ? ? 48 85 C9 74 ? 48 8B 01 FF ? ? 48 85 C0 74 ? 48 63 4E 38]
        public const uint Aux = 0x974;
    }
}