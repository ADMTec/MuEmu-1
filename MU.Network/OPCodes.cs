﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MU.Network
{
    public enum ConOpCode : ushort
    {
        CSWelcome = 0x0100,
        GSJoin = 0xFF10,
        GSKeep = 0xFF11,
        GSClientAdd = 0xFF12,
        GSClientChat = 0xFF13,
        GSClientRem = 0xFF14,
    }


    public enum GlobalOpCode : ushort
    {
        LiveClient = 0xFF0E,
    }

    public enum AHOpCode : ushort
    {
        AHCheck = 0x11FA,
    }

    public enum CSOpCode : ushort
    {
        JoinResult = 0x00F1,
        Login = 0x01F1,
        CharacterList = 0x00F3,
        CharacterCreate = 0x01F3,
        CharacterDelete = 0x02F3,
        JoinMap2 = 0x03F3,
        JoinMap = 0x15F3,
        ServerMove = 0x00B1,
        ServerMoveAuth = 0x01B1,


        ResetList = 0x0AFA,
        Resets = 0x0BFA,
        EnableCreate = 0x00DE,
    }

    public enum GameOpCode : ushort
    {
        MapMoveCheckSum = 0x018E,
        Warp = 0x028E,

        DuelRequest = 0x01AA,
        DuelAnswer = 0x02AA,
        DuelLeave = 0x03AA,
        DuelScoreBroadcast = 0x04AA,
        DuelHPBroadcast = 0x05AA,
        DuelChannelList = 0x06AA,
        DuelRoomJoin = 0x07AA,
        DuelRoomJoinBroadcast = 0x08AA,
        DuelRoomLeave = 0x09AA,
        DuelRoomLeaveBroadcast = 0x0AAA,
        DuelRoomObserversBroadcast = 0x0BAA,
        DuelResultBroadcast = 0x0CAA,
        DuelRoundBroadcast = 0x0DAA,

        Tax = 0x1AB2,
        KillCount = 0x01B8,
        ClientClose = 0x02F1,
        ClientMessage = 0x03F1,
        CharRegen = 0x04F3,
        LevelUp = 0x5F3,
        PointAdd = 0x06F3,
        Damage = 0x07F3,
        Inventory = 0x10F3,
        Spells = 0x11F3,
        DataLoadOK = 0x12F3,
        Equipament = 0x13F3,
        OneItemSend = 0x14F3,
        SkillKey = 0x30F3,
        Command = 0x40F3,

        MasterLevelInfo = 0x50F3,
        MasterLevelUp = 0x51F3,
        MasterLevelSkill = 0x52F3,

        NewQuestInfo = 0x1AF6,
        QuestDetails = 0x1BF6,
        QuestWindow = 0x01F9,
        JewelMix = 0x00BC,
        JewelUnMix = 0x01BC,
        GeneralChat0 = 0xFF00,
        GeneralChat1 = 0xFF01,
        WhisperChat = 0xFF02,
        GameSecurity = 0xFF03,
        ViewSkillState = 0xFF07,
        EventState = 0xFF0B,
        Notice = 0xFF0D,
        Weather = 0xFF0F,
        Beattack = 0xFF10,
        ViewPortCreate = 0xFF12,
        ViewPortMCreate = 0xFF13,
        ViewPortDestroy = 0xFF14,
        AttackResult = 0xFF15,
        KillPlayer = 0xFF16,
        DiePlayer = 0xFF17,
        Rotation = 0xFF18,
        MagicAttack = 0xFF19,
        Teleport = 0xFF1C,
        MagicDuration = 0xFF1E,
        ViewPortMCall = 0xFF1F,
        ViewPortItemCreate = 0xFF20,
        ViewPortItemDestroy = 0xFF21,
        ItemGet = 0xFF22,
        ItemThrow = 0xFF23,
        MoveItem = 0xFF24,
        HealthUpdate = 0xFF26,
        ManaUpdate = 0xFF27,
        InventoryItemDelete = 0xFF28,
        ItemUseSpecialTime = 0xFF29,
        InventoryItemDurUpdate = 0xFF2A,
        PeriodicEffect = 0xFF2D,
        Talk = 0xFF30,
        CloseWindow = 0xFF31,
        Buy = 0xFF32,
        Sell = 0xFF33,
        ItemModify = 0xFF34,
        TradeRequest = 0xFF36,
        TradeResponce = 0xFF37,
        TradeOtherAdd = 0xFF39,
        TradeMoney = 0xFF3A,
        TradeOtherMoney = 0xFF3B,
        TradeButtonOk = 0xFF3C,
        TradeButtonCancel = 0xFF3D,
        ViewPortPShop = 0x003F,
        PShopSetItemPrice = 0x013F,
        PShopRequestOpen = 0x023F,
        PShopRequestClose = 0x033F,
        PShopRequestList = 0x053F,
        PShopRequestBuy = 0x063F,
        PShopAlterVault = 0xA8FA,
        PShopCloseDeal = 0x073F,
        PShopRequestSold = 0x083F,
        PShopSearchItem = 0x31EC,
        PartyRequest = 0xFF40,
        PartyResult = 0xFF41,
        PartyList = 0xFF42,
        PartyDelUser = 0x0FF43,
        PartyLifeUpdate = 0x0FF44,
        ViewPortChange = 0xFF45,
        SetMapAtt = 0xFF46,
        Effect = 0xFF48,
        ViewPortGuildCreate = 0xFF65,
        WarehouseMoney = 0xFF81,
        WarehouseUseEnd = 0xFF82,
        ChaosBoxItemMixButtonClick = 0xFF86,
        ChaosBoxUseEnd = 0xFF87,
        EventEnterCount = 0xFF9F,
        QuestInfo = 0xFFA0,

        FriendList = 0xFFC0,
        FriendAdd = 0xFFC1,
        FriendAddWait = 0xFFC2,
        FriendDel = 0xC3,
        FriendState = 0xC4,
        LetterSend = 0xC5,
        AddLetter = 0xFFC6,
        LetterRead = 0xC7,
        LetterDel = 0xC8,
        LetterList = 0xC9,

        Move = 0xFFD3,
        MoveEng = 0xFFD4,
        Move12Eng = 0xFFD7,
        Attack = 0xFFD7,
        AttackEng = 0xFF11,
        Position = 0xFFDF,
        Position9Eng = 0xFF15,

        MiniMapNPC = 0x03E7,
        PeriodItemCount = 0x11D2,

        PentagramaJInfo = 0x01EE,
        UBFInfo = 0x01CD,
        PopUpType = 0x26F3,

        MemberPosInfoStart = 0x01E7,
        MemberPosInfoStop = 0x02E7,
        LifeInfo = 0x10EC,
        NPCJulia = 0x17BF,
        MuHelperSwitch = 0x51BF,
        MuHelper = 0xFFAE,
        AttackSpeed = 0x30EC,
        KillPlayerEXT = 0xFF9C,
        NPCDialog = 0x01F9,
        QuestExp = 0x30F6,
        ShadowBuff = 0x31F6,
        ChainMagic = 0x0ABF,

        GremoryCaseList = 0x004F,
        GremoryCaseReceive = 0x014F,
        GremoryCaseDelete = 0x034F,
        GremoryCaseNotice = 0x044F,
        GremoryCaseOpen = 0x054F,
        AcheronEnter = 0x20F8,
        RefineJewel = 0x02EC,
        PentagramaJewelIn = 0x00EC,
        PentagramaJewelInOut = 0x04EC,
        ElementDamage = 0xFFD8,
        NeedSpiritMap = 0x21F8,
        PetInfo = 0xFFA9,
        MasterLevelSkills = 0x53F3,
        ExpEventInfo = 0x52BF,

        MuunItemGet = 0x004E,
        MuunInventory = 0x024E,
        MuunItemUse = 0x084E,
        MuunItemSell = 0x094E,
        MuunItemRideSelect = 0x114E,
        MuunItemExchange = 0x134E,
        MuunRideViewPort = 0x144E,
        PetCommand = 0xFFA7,
        PetAttack = 0xFFA8,
        InventoryEquipament = 0x20BF,
        EquipamentChange = 0xFF25,
        Attack12Eng = 0xFFDF,
        SXUpPront = 0x25EC,
        SXInfo = 0x27EC,
        SXCharacterInfo = 0x29EC,
        NewQuestWorldLoad = 0x20F6,
        NewQuestWorldList = 0x50F6,
        PKLevel = 0x08F3,
        MonsterSkill = 0x0069,
    }

    public enum GensOpCode
    {
        RequestJoin = 0x01F8,
        RegMember = 0x02F8,
        RequestLeave = 0x03F8,
        ViewPortGens = 0x05F8,
        SendGensInfo = 0x07F8,
        RequestReward = 0x09F8,
        RemoveMember = 0x7F9,
        RewardSend = 0x0AF8,
        RequestMemberInfo = 0x0BF8,
    }

    public enum GuildOpCode
    {
        GuildRequest = 0xFF50,
        GuildResult = 0xFF51,
        GuildListAll = 0xFF52,
        RemoveUser = 0xFF53,
        MasterQuestion = 0xFF54,
        GuildSaveInfo = 0xFF55,
        GuildViewPort = 0xFF65,
        GuildReqViewport = 0xFF66,
        GuildSetStatus = 0xFFE1,
        GuildRelationShip = 0xFFE5,
        GuildRelationShipAns = 0xFFE6,
        GuildUnionList = 0xFFE9,
    }

    public enum EventOpCode
    {
        RemainTime = 0xFF91,
        LuckyCoinsCount = 0x0BBF,
        LuckyCoinsRegistre = 0x0CBF,

        DevilSquareMove = 0xFF90,
        DevilSquareSet = 0xFF92,

        BloodCastleReward = 0xFF93,

        EventChipInfo = 0xFF94,

        BloodCastleEnter = 0xFF9A,
        BloodCastleState = 0xFF9B,

        ChaosCastleMove = 0x01AF,

        CrywolfState = 0x00BD,
        CrywolfStatueAndAltarInfo = 0x02BD,
        CrywolfContract = 0x03BD,
        CrywolfLeftTime = 0x04BD,
        CrywolfBossMonsterInfo = 0x05BD,
        CrywolfStageEffect = 0x06BD,
        CrywolfPersonalRank = 0x07BD,
        CrywolfHeroList = 0x08BD,
        CrywolfBenefit = 0x09BD,

        KanturuState = 0x00D1,
        KanturuEnter = 0x01D1,
        KanturuStateChange = 0x03D1,
        KanturuBattleResult = 0x04D1,
        KanturuBattleTime = 0x05D1,
        KanturuWideAttack = 0x06D1,
        KanturuMonsterUserCount = 0x07D1,

        ImperialGuardianEnter = 0x01F7,
        ImperialGuardianEnterResult = 0x02F7,
        ImperialGuardianNotifyZoneTime = 0x04F7,
        ImperialGuardianNotifyZoneAllClear = 0x06F7,

        ArcaBattleState = 0x38F8,
        Banner = 0x184D,

        MuRummyOpen = 0x0F4D,
        EventItemGet = 0x004D,
        EventItemThrow = 0x014D,
        EventInventory = 0x024D,
        CastleSiegeLeftTimeAlarm = 0x1EB2,
        CastleSiegeState = 0x00B2,
        CastleSiegeRegiste = 0x01B2,
        CastleSiegeGuildInfo = 0x03B2,
        CastleSiegeRegisteMark = 0x04B2,
        CastleSiegeSwitchNotify = 0x14B2,
        CastleSiegeCrownState = 0x16B2,
        CastleSiegeNotifyStart = 0x17B2,
        CastleSiegejoinSide = 0x19B2,
        CastleSiegeNotifySwitchInfo = 0x20B2,
        CastleSiegeGuildMarkOfOwner = 0x02B9,
        CastleSiegeGuildList = 0xFFB4,
        CastleSiegeMinimap = 0xFFB6,
    }
    public enum CashOpCode : ushort
    {
        CashItems = 0x05D0,
        CashPoints = 0x04F5,

        CashInit = 0x00D2,
        CashPointsS9 = 0x01D2,
        CashOpen = 0x02D2,
        CashItemBuy = 0x03D2,
        CashItemGif = 0x04D2,
        CashInventoryCount = 0x05D2,
        CashItemList = 0x06D2,
        CashVersion = 0x0CD2,
        CashBanner = 0x15D2,
    }

    public enum PCPShopOpCode : ushort
    {
        PCPShopPoints = 0x04D0,
        PCPShopBuy = 0x05D0,
        PCPShopInfo = 0x06D0,
        PCPShopItems = 0xFF31,
    }

    public enum QuestOpCode : ushort
    {
        SetQuest = 0xFFA1,
        SetQuestState = 0xFFA2,
        QuestPrize = 0xFFA3,
        QuestExp = 0x00F6,
        QuestSwitchListNPC = 0x0AF6,
        QuestExpInfo = 0x0BF6,
        QuestExpInfoAsk = 0x0CF6,
        QuestExpComplete = 0x0DF6,
        QuestEXPProgress = 0x1BF6,
        QuestExpProgressList = 0x1AF6,
        QuestEXPEventItemEPList = 0x21F6,
        QuestSwitchListEvent = 0x03F6,
        QuestSwitchListItem = 0x04F6,
    }
}
