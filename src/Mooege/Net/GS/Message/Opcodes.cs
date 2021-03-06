﻿/*
 * Copyright (C) 2011 - 2012 mooege project - http://www.mooege.org
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

namespace Mooege.Net.GS.Message
{
    public enum Opcodes : int
    {
        TryConsoleCommand1 = 1,
        TryConsoleCommand2 = 2,
        QuitGameMessage = 3, // len: 	12
        CreateBNetGameMessage = 4, // len: 	88
        CreateBNetGameResultMessage = 5, // len: 	40
        DWordDataMessage1 = 6, // len: 	12
        RequestJoinBNetGameMessage = 8, // len: 	56
        BNetJoinGameRequestResultMessage = 9, // len: 	72
        JoinBNetGameMessage = 10, // len: 	80
        JoinLANGameMessage = 11, // len: 	196
        VersionsMessage = 13, // len: 	48
        GenericBlobMessage1 = 14, // len: 	
        NetworkAddressMessage = 15, // len: 	16
        GameIdMessage = 17, // len: 	32
        UInt64DataMessage = 18, // len: 	16
        IntDataMessage1 = 20, // len: 	12
        EntityIdMessage = 22, // len: 	24
        CreateHeroMessage = 23, // len: 	68
        CreateHeroResultMessage = 24, // len: 	32
        SimpleMessage1 = 25, // len: 	8
        BlizzconCVarsMessage = 26, // len: 	20
        SimpleMessage2 = 27, // len: 	8
        GenericBlobMessage2 = 28, // len: 	
        GenericBlobMessage3 = 29, // len: 	
        GenericBlobMessage4 = 30, // len: 	
        GenericBlobMessage5 = 31, // len: 	
        OpenArtisanWindowMessage = 32, // len: 	12 former ANNDataMessage1
        ArtisanWindowClosedMessage = 33, // len: 	8 former SimpleMessage3
        OpenTradeWindow = 34, // len: 	12          former ANNDataMessage2
        RequestBuyItemMessage = 35, // len: 	12, former ANNDataMessage3
        RequestSellItemMessage = 36, // len: 	12, former ANNDataMessage4
        LogoutContextMessage1 = 37, // len: 	16
        LogoutTickTimeMessage = 38, // len: 	20
        LogoutComplete = 39, // len: 	8 formor SimpleMessage4
        LogoutContextMessage2 = 40, // len: 	16
        PlayerIndexMessage1 = 41, // len: 	12
        PlayerIndexMessage2 = 42, // len: 	12
        SimpleMessage5 = 43, // len: 	8
        SimpleMessage6 = 44, // len: 	8
        TutorialMessage = 45, //len:    former GenericBlobMessage6
        GenericBlobMessage15 = 46, //len:  added 8058
        Message = 47, //len: 36
        SimpleMessage48 = 48, //Len: 8  added 8058
        ConnectionEstablishedMessage = 49, // len: 	20
        GameSetupMessage = 50, // len: 	20
        SimpleMessage7 = 51, // len: 	8
        NewPlayerMessage = 52, // len: 	16916
        PlayerKickTimerMessage = 53, //len: 16
        PlayerBannerMessage = 54, // len: 	former GenericBlobMessage7
        EnterWorldMessage = 55, // len: 	28
        RevealSceneMessage = 56, // len: 	1292
        DestroySceneMessage = 57, // len: 	16
        SwapSceneMessage = 58, // len: 	20
        RevealWorldMessage = 59, // len: 	16
        RevealTeamMessage = 60, // len: 	20
        PlayerActorSetInitialMessage = 61, // len: 	16
        HeroStateMessage = 62, // len: 	16652
        ACDEnterKnownMessage = 63, // len: 	132
        ACDDestroyActorMessage = 64, // len: 	12 former ANNDataMessage6
        PlayerEnterKnownMessage = 65, // len: 	16
        ACDCreateActorMessage = 66, // len: 	12 former ANNDataMessage7
        ACDWorldPositionMessage = 67, // len: 	48
        ACDInventoryPositionMessage = 68, // len: 	32
        ACDInventoryUpdateActorSNO = 69, // len: 	16
        TrickleMessage = 70, // len: 	116
        ANNDataMessage8 = 71, // len: 	12
        MapRevealSceneMessage = 72, // len: 	52
        SavePointInfoMessage = 73, // len: 	12
        HearthPortalInfoMessage = 74, // len: 	16
        ReturnPointInfoMessage = 75, // len: 	12
        AffixMessage = 76, // len: 	148
        RareMonsterNamesMessage = 77, // len: 	52
        RareItemNameMessage = 78, // len: 	28
        PortalSpecifierMessage = 79, // len: 	24
        AttributeSetValueMessage = 80, // len: 	28
        AttributesSetValuesMessage = 81, // len: 	256
        VisualInventoryMessage = 82, // len: 	140
        ProjectileStickMessage = 83, // len: 	28
        TargetMessage = 84, // len: 	60
        SecondaryAnimationPowerMessage = 85, // len: 	28
        LoopingAnimationPowerMessage = 86, // len:  20
        DWordDataMessage2 = 87, // len: 	12
        DWordDataMessage3 = 88, // len: 	12
        DWordDataMessage4 = 89, // len: 	12
        DWordDataMessage5 = 90, // len: 	12
        TryChatMessage = 91, // len: 	528
        ChatMessage = 92, // len: 	528
        ANNDataMessage9 = 93, // len: 	12
        InventoryRequestMoveMessage1 = 94, // len: 	28
        InventoryRequestQuickMoveMessage = 95, // len:  28
        InventoryRequestSocketMessage = 96, // len: 	16
        InventoryRequestMoveMessage2 = 97, // len: 	28
        InventorySplitStackMessage = 98, // len: 	40
        InventoryDropStackPortionMessage = 99, //len:   24
        InventoryStackTransferMessage = 100, // len: 	24
        ANNDataMessage10 = 101, // len: 	12
        ANNDataMessageXX = 102, //len: 12
        SimpleMessage47 = 103, //len 8 added in 7841
        ANNDataMessage11 = 104, // len: 	12
        InventoryRequestUseMessage = 105, // len: 	36
        HelperDetachMessage = 106, // len: 	12
        AssignSkillMessage1 = 107, // len: 	16
        UnassignSkillMessage = 108, //len: 12
        AssignTraitsMessage = 109, // len: 20 added patch 13
        AssignSkillMessage2 = 110, // len: 	16
        AssignSkillMessage3 = 111, // len: 	16
        HirelingRequestLearnSkillMessage = 112, // len: 	20
        HotbarButtonData = 113, // len: 	12 former ANNDataMessage12
        GBIDDataMessage3 = 114, // len: 12 added patch 13
        IntDataMessage2 = 115, // len: 	12
        PlayAnimationMessage = 116, // len: 	72
        ANNDataMessage13 = 117, // len: 	12
        ACDTranslateNormalMessage = 118, // len: 	76 former ACDTranslateNormalMessage1
        ACDTranslateSnappedMessage = 119, // len: 	36
        ACDTranslateFacingMessage = 120, // len: 	20
        ACDTranslateFixedMessage = 121, // len: 	36
        ACDTranslateArcMessage = 122, // len: 	60
        ACDTranslateDetPathMessage = 123, // len: 	88
        ACDTranslateDetPathSinMessage = 124, // len: 	104
        ACDTranslateDetPathSpiralMessage = 125, // len: 	72
        ACDTranslateSyncMessage = 126, // len: 	32
        ACDTranslateFixedUpdateMessage = 127, // len: 	36
        ACDClientTranslateMessage = 128, //len: 44 (Added patch 8)
        PlayerTranslateFacingMessage = 129, // len: 	20 former ACDTranslateFacingMessage2
        ACDTranslateAckMessage = 130, //len: 12
        PlayEffectMessage = 131, // len: 	24
        PlayHitEffectMessage = 132, // len: 	24
        PlayHitEffectOverrideMessage = 133, // len: 	20
        PlayNonPositionalSoundMessage = 134, // len: 	12
        PlayErrorSoundMessage = 135, // len: 	12
        PlayMusicMessage = 136, // len: 	12
        PlayCutsceneMessage = 137, // len: 	12
        ComplexEffectAddMessage = 138, // len: 	36
        FlippyMessage = 139, // len: 	32
        WaypointActivatedMessage = 140, // len: 	20
        OpenWaypointSelectionWindowMessage = 141, // len: 	12 former ANNDataMessage14
        ANNDataMessage15 = 142, // len: 	12
        ANNDataMessage16 = 143, // len: 	12
        SimpleMessage49 = 144, // len: 8 added patch 13
        AimTargetMessage = 145, // len: 	36
        ACDChangeGBHandleMessage = 146, // len: 	20
        GameTickMessage = 147, // len: 	12  former DWordDataMessage6
        DataIDDataMessage1 = 148, // len: 	12
        DataIDDataMessage2 = 149, // len: 	12
        EndOfTickMessage = 150, // len: 	16
        TryWaypointMessage = 151, // len: 	16
        NPCInteractOptionsMessage = 152, // len: 	340
        ANNDataMessage17 = 153, // len: 	12
        ANNDataMessage18 = 154, // len: 	12
        SimpleMessage8 = 155, // len: 	8
        QuestUpdateMessage = 156, // len: 	28
        QuestMeterMessage = 157, // len: 	20
        QuestCounterMessage = 158, // len: 	20
        QuestStepCompleteMessage = 159, // len:  // former GenericBlobMessage8	
        PlayerIndexMessage3 = 160, // len: 	12
        PlayerLevel = 161, // len: 	16
        OpenSharedStashMessage = 162, // len: 	12, former ANNDataMessage19
        ACDPickupFailedMessage = 163, // len: 	16
        PetMessage = 164, // len: 	24
        PetDetachMessage = 165, // len: 16
        HirelingInfoUpdateMessage = 166, // len: 	24
        UIElementMessage = 167, // len: 	16
        PlayerBusyMessage = 168, // len: 	12      //  former: BoolDataMessage1
        TradeMessage1 = 169, // len: 	56
        TradeMessage2 = 170, // len: 	56
        PlayerIndexMessage4 = 171, // len: 	12
        SimpleMessage10 = 172, // len: 	8
        PlayerIndexMessage5 = 173, // len: 	12
        SetIdleAnimationMessage = 174, // len: 	16
        ACDCollFlagsMessage = 175, // len: 	16
        GoldModifiedMessage = 176, // len: 	12
        ActTransitionMessage = 177, // len: 	16
        InterstitialMessage = 178, // len: 	16
        EffectGroupACDToACDMessage = 179, // len: 	20
        RopeEffectMessageACDToACD = 180, // len: 	28
        RopeEffectMessageACDToPlace = 181, // len: 	36
        ANNDataMessage21 = 182, // len: 	12
        ShrineActivatedMessage = 183, // len: 	12   former ANNDataMessage22
        GameSyncedDataMessage = 184, // len: 	96
        ACDChangeActorMessage = 185, // len: 	16
        PlayerWarpedMessage = 186, // len: 	16
        VictimMessage = 187, // len: 	48
        KillCountMessage = 188, // len: 	24
        WorldStatusMessage = 189, // len: 	16
        WeatherOverrideMessage = 190, // len: 	16
        SimpleMessage11 = 191, // len: 	8
        ACDShearMessage = 192, // len: 	16
        ACDGroupMessage = 193, // len: 	20
        HeartbeatMessage = 194, // len: 	8 former SimpleMessage12
        PlayConvLineMessage = 195, // len: 	172
        StopConvLineMessage = 196, // len: 	16
        AdvanceConvMessage = 197, //len : 16
        UpdateConvAutoAdvanceMessage = 198, // len: 20
        RequestCloseConversationWindowMessage = 199, // len: 	8 former SimpleMessage13
        EndConversationMessage = 200, // len: 	20
        SNODataMessage2 = 201, // len: 	12
        FinishConversationMessage = 202, // len: 	12 former SNODataMessage3
        HirelingSwapMessage1 = 203, // len: 	12
        HirelingSwapMessage2 = 204, // len: 	12
        SimpleMessage14 = 205, // len: 	8
        DeathFadeTimeMessage = 206, // len: 	24
        ANNDataMessage23 = 207, // len: 	12
        ANNDataMessage24 = 208, // len: 	12
        DisplayGameTextMessage = 209, // len: 	536
        IntDataMessage4 = 210, // len: 	12
        DWordDataMessage7 = 211, // len: 	12
        GBIDDataMessage1 = 212, // len: 	12
        ANNDataMessage25 = 213, // len: 	12
        ANNDataMessage26 = 214, // len: 	12
        ACDLookAtMessage = 215, // len: 	16
        KillCounterUpdateMessage = 216, // len: 	24
        LowHealthCombatMessage = 217, // len: 	16
        SaviorMessage = 218, // len: 	16
        FloatingNumberMessage = 219, // len: 	20
        FloatingAmountMessage = 220, // len: 	40
        RemoveRagdollMessage = 221, // len: 	16
        SNONameDataMessage = 222, // len: 	16
        LoreMessage = 223, // len: 	16
        DWordDataMessage12 = 226, // len: 12 added 8059
        WorldDeletedMessage = 227, // len: 	12
        SimpleMessage16 = 228, // len: 	8
        IntDataMessage5 = 229, // len: 	12
        TimedEventStartedMessage = 230, // len: 	20
        SNODataMessage4 = 231, // len: 	12
        ActTransitionStartedMessage = 232, // len: 	16
        SimpleMessage17 = 233, // len: 	8 //added in 7728
        RequestBuySharedStashSlotsMessage = 234, // len: 	8   former SimpleMessage17
        PlayerQuestMessage1 = 235, // len: 	16
        PlayerQuestMessage2 = 236, // len: 	16
        PlayerDeSyncSnapMessage = 237, // len: 	28
        RequestUseNephalemCubeMessage = 238, // len: 	12  former ANNDataMessage27
        SalvageResultsMessage = 239, // len: 	60
        SimpleMessage18 = 240, // len: 	8
        MapMarkerInfoMessage = 241, // len: 	72
        BlacksmithDataProgressMessage = 242, // len: 	   former GenericBlobMessage9
        JewelerDataProgressMessage = 243, // len: 	   former GenericBlobMessage10
        MysticDataProgressMessage = 244, // len: 	former GenericBlobMessage11
        BlacksmithDataInitialMessage = 245, // len:   former genericBlobMessage 12	
        JewelerDataInitialMessage = 246, // len: 	former GenericBlobMessage13
        MysticDataInitialMessage = 247, // len: 	former GenericBlobMessage14 
        ANNDataMessage28 = 248, // len: 	12
        DebugActorTooltipMessage = 249, // len: 	524
        BossEncounterMessage1 = 250, // len: 	16
        SimpleMessage20 = 251, // len: 	8
        SimpleMessage21 = 252, // len: 	8
        BossEncounterMessage2 = 253, // len: 	16
        SimpleMessage22 = 254, // len: 	8
        SimpleMessage23 = 255, // len: 	8
        EncounterInviteStateMessage = 256, // len: 	12
        SimpleMessage24 = 257, // len: 	8
        SimpleMessage25 = 258, // len: 	8
        IntDataMessage3 = 259, // len: 12 added 8059
        SimpleMessage26 = 260, // len: 	8
        SimpleMessage27 = 261, // len: 	8
        SimpleMessage28 = 262, // len: 	8
        SimpleMessage29 = 263, // len: 	8
        CameraFocusMessage = 264, // len: 	20
        CameraZoomMessage = 265, // len: 	20
        CameraYawMessage = 266, // len: 	20
        SimpleMessage30 = 267, // len: 	8
        BoolDataMessage2 = 268, // len: 	12
        SimpleMessage50 = 269, // len: 8 added patch 13
        BossZoomMessage = 270, // len: 	16
        EnchantItemMessage = 271, // len: 	16
        ANNDataMessage29 = 272, // len: 	12
        SimpleMessage31 = 273, // len: 	8
        SimpleMessage32 = 274, // len: 	8
        RequestTrainArtisanMessage = 275, // len: 	8   former SimpleMessage33
        IntDataMessage6 = 276, // len: 	12
        DebugDrawPrimMessage = 277, // len: 	188
        GBIDDataMessage2 = 278, // len: 	12
        CraftingResultsMessage = 279, // len: 	20
        CrafterLevelUpMessage = 280, // len: 	20
        ANNDataMessage31 = 281, // len: 	12
        ANNDataMessage32 = 282, // len: 	12
        //ANNDataMessage33 = 280, // len: 	12
        IntDataMessage7 = 283, // len: 	12
        UnlockDifficultyMessage = 284, // len:  16 added patch 13
        IntDataMessage8 = 285, // len: 	12
        SimpleMessage35 = 286, // len: 	8
        SimpleMessage36 = 287, // len: 	8
        GameTestingSamplingStartMessage = 288, // len: 	16
        SimpleMessage37 = 289, // len: 	8
        TutorialShownMessage = 290, // len: 	12 former SNODataMessage5
        RequestBuffCancelMessage = 291, // len: 	16
        SimpleMessage38 = 292, // len: 	8
        PlayerIndexMessage7 = 293, // len: 	12
        SimpleMessage39 = 294, // len: 	8
        SimpleMessage40 = 295, // len: 	8
        DWordDataMessage8 = 296, // len: 	12
        DWordDataMessage9 = 297, // len: 	12
        DWordDataMessage10 = 298, // len: 	12
        DWordDataMessage11 = 299, // len: 	12
        BroadcastTextMessage = 300, // len: 	520
        LoadCompleteMessage = 301, // len: 	8 former SimpleMessage41
        SimpleMessage42 = 302, // len: 	8
        NPCSelectConversationMessage = 303, // len: 	12 former SNODataMessage6
        HirelingDismissMessage = 304, // len: 	12 former ANNDataMessage33
        CraftInteractionMessage = 305, // len: 	8 former SimpleMessage43
        HirelingHireMessage = 306, // len: 	8 former SimpleMessage44
        HirelingInventoryMessage = 307, // len: 	8 former SimpleMessage45
        SNODataMessage7 = 308, // len:  12
        ActTransitionStartedMessage2 = 309, //len:   16
        VoteKickMessage1 = 310, //len:   528
        PlayerIndexMessage8 = 311, // len: 	12
        PlayerIndexMessage9 = 312, // len: 	12
        VoteKickMessage2 = 313, //len:   528
        BoolDataMessage3 = 314, // len: 	12
        PlayerIndexMessage10 = 315, // len: 	12
        PlayerIndexMessage11 = 316, // len: 	12
        BoolDataMessage4 = 317, // len: 	12
        BoolDataMessage5 = 318, // len: 	12
        SimpleMessage51 = 319, //len: 8 added patch 13
        SimpleMessage52 = 320, //len: 8 added patch 14
    }
}