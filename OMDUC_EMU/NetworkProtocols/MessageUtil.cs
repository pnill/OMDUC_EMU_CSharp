using System;

namespace NetworkProtocols
{
	// Token: 0x020006E1 RID: 1761
	public static class MessageUtil
	{
		// Token: 0x06003EF5 RID: 16117 RVA: 0x001178E0 File Offset: 0x00115AE0
		public static BotNetMessage Deserialize(byte[] data)
		{
			uint num = BitConverter.ToUInt32(data, 0);
			uint num2 = num;
			if (num2 == 106595167u)
			{
				RequestSendGuildInvite requestSendGuildInvite = new RequestSendGuildInvite();
				requestSendGuildInvite.DeserializeMessage(data);
				return requestSendGuildInvite;
			}
			if (num2 == 120933977u)
			{
				RequestGetIncomingGuildInvites requestGetIncomingGuildInvites = new RequestGetIncomingGuildInvites();
				requestGetIncomingGuildInvites.DeserializeMessage(data);
				return requestGetIncomingGuildInvites;
			}
			if (num2 == 128836524u)
			{
				RequestSkipPrologue requestSkipPrologue = new RequestSkipPrologue();
				requestSkipPrologue.DeserializeMessage(data);
				return requestSkipPrologue;
			}
			if (num2 == 138217706u)
			{
				LeftChatRoomPush leftChatRoomPush = new LeftChatRoomPush();
				leftChatRoomPush.DeserializeMessage(data);
				return leftChatRoomPush;
			}
			if (num2 == 140578634u)
			{
				FriendPresenceChanged friendPresenceChanged = new FriendPresenceChanged();
				friendPresenceChanged.DeserializeMessage(data);
				return friendPresenceChanged;
			}
			if (num2 == 141406647u)
			{
				RequestVirtualCurrencyTransaction requestVirtualCurrencyTransaction = new RequestVirtualCurrencyTransaction();
				requestVirtualCurrencyTransaction.DeserializeMessage(data);
				return requestVirtualCurrencyTransaction;
			}
			if (num2 == 160435844u)
			{
				RequestRejectGuildInvite requestRejectGuildInvite = new RequestRejectGuildInvite();
				requestRejectGuildInvite.DeserializeMessage(data);
				return requestRejectGuildInvite;
			}
			if (num2 == 164379719u)
			{
				PushPlayerRotatingStore pushPlayerRotatingStore = new PushPlayerRotatingStore();
				pushPlayerRotatingStore.DeserializeMessage(data);
				return pushPlayerRotatingStore;
			}
			if (num2 == 168718057u)
			{
				PushActiveChallenge pushActiveChallenge = new PushActiveChallenge();
				pushActiveChallenge.DeserializeMessage(data);
				return pushActiveChallenge;
			}
			if (num2 == 182542086u)
			{
				ServerAckInviteToParty serverAckInviteToParty = new ServerAckInviteToParty();
				serverAckInviteToParty.DeserializeMessage(data);
				return serverAckInviteToParty;
			}
			if (num2 == 185325717u)
			{
				RequestSendChat requestSendChat = new RequestSendChat();
				requestSendChat.DeserializeMessage(data);
				return requestSendChat;
			}
			if (num2 == 193026692u)
			{
				ResponseKeystoneReroll responseKeystoneReroll = new ResponseKeystoneReroll();
				responseKeystoneReroll.DeserializeMessage(data);
				return responseKeystoneReroll;
			}
			if (num2 == 197131932u)
			{
				PS4LoginUserRequest ps4LoginUserRequest = new PS4LoginUserRequest();
				ps4LoginUserRequest.DeserializeMessage(data);
				return ps4LoginUserRequest;
			}
			if (num2 == 199016344u)
			{
				RequestUpdatePlayerKeystoneLeaderboardInfo requestUpdatePlayerKeystoneLeaderboardInfo = new RequestUpdatePlayerKeystoneLeaderboardInfo();
				requestUpdatePlayerKeystoneLeaderboardInfo.DeserializeMessage(data);
				return requestUpdatePlayerKeystoneLeaderboardInfo;
			}
			if (num2 == 204538625u)
			{
				PushDailyLoginReward pushDailyLoginReward = new PushDailyLoginReward();
				pushDailyLoginReward.DeserializeMessage(data);
				return pushDailyLoginReward;
			}
			if (num2 == 206523056u)
			{
				RequestStartCampaignMission requestStartCampaignMission = new RequestStartCampaignMission();
				requestStartCampaignMission.DeserializeMessage(data);
				return requestStartCampaignMission;
			}
			if (num2 == 240668635u)
			{
				ResponseToggleGuildAcceptingApplications responseToggleGuildAcceptingApplications = new ResponseToggleGuildAcceptingApplications();
				responseToggleGuildAcceptingApplications.DeserializeMessage(data);
				return responseToggleGuildAcceptingApplications;
			}
			if (num2 == 248680754u)
			{
				RequestGetGuildDetail requestGetGuildDetail = new RequestGetGuildDetail();
				requestGetGuildDetail.DeserializeMessage(data);
				return requestGetGuildDetail;
			}
			if (num2 == 252364934u)
			{
				UserLogoutResponse userLogoutResponse = new UserLogoutResponse();
				userLogoutResponse.DeserializeMessage(data);
				return userLogoutResponse;
			}
			if (num2 == 257278965u)
			{
				RequestStoreData requestStoreData = new RequestStoreData();
				requestStoreData.DeserializeMessage(data);
				return requestStoreData;
			}
			if (num2 == 261889549u)
			{
				ResponseStoreTransaction responseStoreTransaction = new ResponseStoreTransaction();
				responseStoreTransaction.DeserializeMessage(data);
				return responseStoreTransaction;
			}
			if (num2 == 269093686u)
			{
				PartyClosed partyClosed = new PartyClosed();
				partyClosed.DeserializeMessage(data);
				return partyClosed;
			}
			if (num2 == 282448013u)
			{
				PlayerLeftParty playerLeftParty = new PlayerLeftParty();
				playerLeftParty.DeserializeMessage(data);
				return playerLeftParty;
			}
			if (num2 == 296893264u)
			{
				RequestCreateFriendRequestByAccountSUID requestCreateFriendRequestByAccountSUID = new RequestCreateFriendRequestByAccountSUID();
				requestCreateFriendRequestByAccountSUID.DeserializeMessage(data);
				return requestCreateFriendRequestByAccountSUID;
			}
			if (num2 == 305536938u)
			{
				BroadcastChatToRoom broadcastChatToRoom = new BroadcastChatToRoom();
				broadcastChatToRoom.DeserializeMessage(data);
				return broadcastChatToRoom;
			}
			if (num2 == 305794315u)
			{
				ResponseDemoteGuildMember responseDemoteGuildMember = new ResponseDemoteGuildMember();
				responseDemoteGuildMember.DeserializeMessage(data);
				return responseDemoteGuildMember;
			}
			if (num2 == 320512202u)
			{
				PushUnrealGameRestarting pushUnrealGameRestarting = new PushUnrealGameRestarting();
				pushUnrealGameRestarting.DeserializeMessage(data);
				return pushUnrealGameRestarting;
			}
			if (num2 == 320520079u)
			{
				ResponseInitiateSteamTransaction responseInitiateSteamTransaction = new ResponseInitiateSteamTransaction();
				responseInitiateSteamTransaction.DeserializeMessage(data);
				return responseInitiateSteamTransaction;
			}
			if (num2 == 349583411u)
			{
				ResponseLobbyRequest responseLobbyRequest = new ResponseLobbyRequest();
				responseLobbyRequest.DeserializeMessage(data);
				return responseLobbyRequest;
			}
			if (num2 == 357572140u)
			{
				RequestValidatePassword requestValidatePassword = new RequestValidatePassword();
				requestValidatePassword.DeserializeMessage(data);
				return requestValidatePassword;
			}
			if (num2 == 357701359u)
			{
				PushLimitedTimeOffers pushLimitedTimeOffers = new PushLimitedTimeOffers();
				pushLimitedTimeOffers.DeserializeMessage(data);
				return pushLimitedTimeOffers;
			}
			if (num2 == 375865500u)
			{
				ResponseDenyFriendRequest responseDenyFriendRequest = new ResponseDenyFriendRequest();
				responseDenyFriendRequest.DeserializeMessage(data);
				return responseDenyFriendRequest;
			}
			if (num2 == 394845444u)
			{
				DataStartGame dataStartGame = new DataStartGame();
				dataStartGame.DeserializeMessage(data);
				return dataStartGame;
			}
			if (num2 == 420224718u)
			{
				RequestDemoteGuildMember requestDemoteGuildMember = new RequestDemoteGuildMember();
				requestDemoteGuildMember.DeserializeMessage(data);
				return requestDemoteGuildMember;
			}
			if (num2 == 423210044u)
			{
				RequestPartyStatus requestPartyStatus = new RequestPartyStatus();
				requestPartyStatus.DeserializeMessage(data);
				return requestPartyStatus;
			}
			if (num2 == 445162848u)
			{
				RequestSubmitConfirmationCode requestSubmitConfirmationCode = new RequestSubmitConfirmationCode();
				requestSubmitConfirmationCode.DeserializeMessage(data);
				return requestSubmitConfirmationCode;
			}
			if (num2 == 448084762u)
			{
				ResponseTutorialRewards responseTutorialRewards = new ResponseTutorialRewards();
				responseTutorialRewards.DeserializeMessage(data);
				return responseTutorialRewards;
			}
			if (num2 == 451289441u)
			{
				PushGuildDisbanded pushGuildDisbanded = new PushGuildDisbanded();
				pushGuildDisbanded.DeserializeMessage(data);
				return pushGuildDisbanded;
			}
			if (num2 == 487879128u)
			{
				RequestGetOutgoingGuildApplications requestGetOutgoingGuildApplications = new RequestGetOutgoingGuildApplications();
				requestGetOutgoingGuildApplications.DeserializeMessage(data);
				return requestGetOutgoingGuildApplications;
			}
			if (num2 == 491869017u)
			{
				RequestDenyFriendRequest requestDenyFriendRequest = new RequestDenyFriendRequest();
				requestDenyFriendRequest.DeserializeMessage(data);
				return requestDenyFriendRequest;
			}
			if (num2 == 514742386u)
			{
				ResponseFinalizeSteamTransaction responseFinalizeSteamTransaction = new ResponseFinalizeSteamTransaction();
				responseFinalizeSteamTransaction.DeserializeMessage(data);
				return responseFinalizeSteamTransaction;
			}
			if (num2 == 519804164u)
			{
				FriendRequestReceived friendRequestReceived = new FriendRequestReceived();
				friendRequestReceived.DeserializeMessage(data);
				return friendRequestReceived;
			}
			if (num2 == 528372036u)
			{
				RequestLobbyJoin requestLobbyJoin = new RequestLobbyJoin();
				requestLobbyJoin.DeserializeMessage(data);
				return requestLobbyJoin;
			}
			if (num2 == 539378151u)
			{
				ResponseCurrentChallengeLeaderboardInfo responseCurrentChallengeLeaderboardInfo = new ResponseCurrentChallengeLeaderboardInfo();
				responseCurrentChallengeLeaderboardInfo.DeserializeMessage(data);
				return responseCurrentChallengeLeaderboardInfo;
			}
			if (num2 == 549982933u)
			{
				RequestGetGuildInvitesForGuild requestGetGuildInvitesForGuild = new RequestGetGuildInvitesForGuild();
				requestGetGuildInvitesForGuild.DeserializeMessage(data);
				return requestGetGuildInvitesForGuild;
			}
			if (num2 == 561375384u)
			{
				RequestCheckGuildTag requestCheckGuildTag = new RequestCheckGuildTag();
				requestCheckGuildTag.DeserializeMessage(data);
				return requestCheckGuildTag;
			}
			if (num2 == 562925610u)
			{
				RequestFullPlayerAccountPush requestFullPlayerAccountPush = new RequestFullPlayerAccountPush();
				requestFullPlayerAccountPush.DeserializeMessage(data);
				return requestFullPlayerAccountPush;
			}
			if (num2 == 564608164u)
			{
				NotifySurvivalUnlocked notifySurvivalUnlocked = new NotifySurvivalUnlocked();
				notifySurvivalUnlocked.DeserializeMessage(data);
				return notifySurvivalUnlocked;
			}
			if (num2 == 584935640u)
			{
				ResponseAchievementsProto responseAchievementsProto = new ResponseAchievementsProto();
				responseAchievementsProto.DeserializeMessage(data);
				return responseAchievementsProto;
			}
			if (num2 == 588538868u)
			{
				PushActiveQuests pushActiveQuests = new PushActiveQuests();
				pushActiveQuests.DeserializeMessage(data);
				return pushActiveQuests;
			}
			if (num2 == 608189841u)
			{
				ResponseJoinDiscordChannel responseJoinDiscordChannel = new ResponseJoinDiscordChannel();
				responseJoinDiscordChannel.DeserializeMessage(data);
				return responseJoinDiscordChannel;
			}
			if (num2 == 618274097u)
			{
				UserLogoutRequest userLogoutRequest = new UserLogoutRequest();
				userLogoutRequest.DeserializeMessage(data);
				return userLogoutRequest;
			}
			if (num2 == 636653740u)
			{
				StartMatchmakingParty startMatchmakingParty = new StartMatchmakingParty();
				startMatchmakingParty.DeserializeMessage(data);
				return startMatchmakingParty;
			}
			if (num2 == 665343859u)
			{
				ResponsePlayerChangePortraitIndex responsePlayerChangePortraitIndex = new ResponsePlayerChangePortraitIndex();
				responsePlayerChangePortraitIndex.DeserializeMessage(data);
				return responsePlayerChangePortraitIndex;
			}
			if (num2 == 690075486u)
			{
				ResponseUnsubscribeFromLobbyList responseUnsubscribeFromLobbyList = new ResponseUnsubscribeFromLobbyList();
				responseUnsubscribeFromLobbyList.DeserializeMessage(data);
				return responseUnsubscribeFromLobbyList;
			}
			if (num2 == 706845900u)
			{
				PushPlayerKeystone pushPlayerKeystone = new PushPlayerKeystone();
				pushPlayerKeystone.DeserializeMessage(data);
				return pushPlayerKeystone;
			}
			if (num2 == 715169555u)
			{
				RequestResetTutorial requestResetTutorial = new RequestResetTutorial();
				requestResetTutorial.DeserializeMessage(data);
				return requestResetTutorial;
			}
			if (num2 == 715640203u)
			{
				ChatRoomClosed chatRoomClosed = new ChatRoomClosed();
				chatRoomClosed.DeserializeMessage(data);
				return chatRoomClosed;
			}
			if (num2 == 727990549u)
			{
				ResponsePlayerAddDeck responsePlayerAddDeck = new ResponsePlayerAddDeck();
				responsePlayerAddDeck.DeserializeMessage(data);
				return responsePlayerAddDeck;
			}
			if (num2 == 759795849u)
			{
				ResponseDashboardConfigs responseDashboardConfigs = new ResponseDashboardConfigs();
				responseDashboardConfigs.DeserializeMessage(data);
				return responseDashboardConfigs;
			}
			if (num2 == 790618283u)
			{
				RequestReplaceQuest requestReplaceQuest = new RequestReplaceQuest();
				requestReplaceQuest.DeserializeMessage(data);
				return requestReplaceQuest;
			}
			if (num2 == 804381683u)
			{
				ResponseBattlegroundBuckets responseBattlegroundBuckets = new ResponseBattlegroundBuckets();
				responseBattlegroundBuckets.DeserializeMessage(data);
				return responseBattlegroundBuckets;
			}
			if (num2 == 811023263u)
			{
				PushHeroStats pushHeroStats = new PushHeroStats();
				pushHeroStats.DeserializeMessage(data);
				return pushHeroStats;
			}
			if (num2 == 822708925u)
			{
				MatchmakingStarted matchmakingStarted = new MatchmakingStarted();
				matchmakingStarted.DeserializeMessage(data);
				return matchmakingStarted;
			}
			if (num2 == 846706495u)
			{
				PushGuildApplicationAccepted pushGuildApplicationAccepted = new PushGuildApplicationAccepted();
				pushGuildApplicationAccepted.DeserializeMessage(data);
				return pushGuildApplicationAccepted;
			}
			if (num2 == 856260801u)
			{
				RequestAcceptGuildApplication requestAcceptGuildApplication = new RequestAcceptGuildApplication();
				requestAcceptGuildApplication.DeserializeMessage(data);
				return requestAcceptGuildApplication;
			}
			if (num2 == 856668671u)
			{
				ResponseValidateAccountForSteam responseValidateAccountForSteam = new ResponseValidateAccountForSteam();
				responseValidateAccountForSteam.DeserializeMessage(data);
				return responseValidateAccountForSteam;
			}
			if (num2 == 857812130u)
			{
				PushPlayerMessages pushPlayerMessages = new PushPlayerMessages();
				pushPlayerMessages.DeserializeMessage(data);
				return pushPlayerMessages;
			}
			if (num2 == 875959173u)
			{
				ResponseRemoveNewInventoryFlag responseRemoveNewInventoryFlag = new ResponseRemoveNewInventoryFlag();
				responseRemoveNewInventoryFlag.DeserializeMessage(data);
				return responseRemoveNewInventoryFlag;
			}
			if (num2 == 878073396u)
			{
				RequestSecurityHandshake requestSecurityHandshake = new RequestSecurityHandshake();
				requestSecurityHandshake.DeserializeMessage(data);
				return requestSecurityHandshake;
			}
			if (num2 == 884509234u)
			{
				RequestRegisterEUPlayer requestRegisterEUPlayer = new RequestRegisterEUPlayer();
				requestRegisterEUPlayer.DeserializeMessage(data);
				return requestRegisterEUPlayer;
			}
			if (num2 == 897501723u)
			{
				ResponseStartCampaignMission responseStartCampaignMission = new ResponseStartCampaignMission();
				responseStartCampaignMission.DeserializeMessage(data);
				return responseStartCampaignMission;
			}
			if (num2 == 910358206u)
			{
				ResponseLeaderboardInfo responseLeaderboardInfo = new ResponseLeaderboardInfo();
				responseLeaderboardInfo.DeserializeMessage(data);
				return responseLeaderboardInfo;
			}
			if (num2 == 929024488u)
			{
				RequestCreateFriendRequest requestCreateFriendRequest = new RequestCreateFriendRequest();
				requestCreateFriendRequest.DeserializeMessage(data);
				return requestCreateFriendRequest;
			}
			if (num2 == 931374413u)
			{
				PushGuildTransactionLogEntryAdded pushGuildTransactionLogEntryAdded = new PushGuildTransactionLogEntryAdded();
				pushGuildTransactionLogEntryAdded.DeserializeMessage(data);
				return pushGuildTransactionLogEntryAdded;
			}
			if (num2 == 938897425u)
			{
				ServerInviteToParty serverInviteToParty = new ServerInviteToParty();
				serverInviteToParty.DeserializeMessage(data);
				return serverInviteToParty;
			}
			if (num2 == 943052253u)
			{
				RequestDiscordAuthentication requestDiscordAuthentication = new RequestDiscordAuthentication();
				requestDiscordAuthentication.DeserializeMessage(data);
				return requestDiscordAuthentication;
			}
			if (num2 == 947528557u)
			{
				RequestMapList requestMapList = new RequestMapList();
				requestMapList.DeserializeMessage(data);
				return requestMapList;
			}
			if (num2 == 964010505u)
			{
				RequestStarAwardsEarned requestStarAwardsEarned = new RequestStarAwardsEarned();
				requestStarAwardsEarned.DeserializeMessage(data);
				return requestStarAwardsEarned;
			}
			if (num2 == 998536513u)
			{
				ClientPingResponse clientPingResponse = new ClientPingResponse();
				clientPingResponse.DeserializeMessage(data);
				return clientPingResponse;
			}
			if (num2 == 1009527074u)
			{
				MatchmakingUserUpdate matchmakingUserUpdate = new MatchmakingUserUpdate();
				matchmakingUserUpdate.DeserializeMessage(data);
				return matchmakingUserUpdate;
			}
			if (num2 == 1010552243u)
			{
				RequestResendConfirmationCode requestResendConfirmationCode = new RequestResendConfirmationCode();
				requestResendConfirmationCode.DeserializeMessage(data);
				return requestResendConfirmationCode;
			}
			if (num2 == 1016889151u)
			{
				RequestLobbySetVisibility requestLobbySetVisibility = new RequestLobbySetVisibility();
				requestLobbySetVisibility.DeserializeMessage(data);
				return requestLobbySetVisibility;
			}
			if (num2 == 1035154563u)
			{
				RequestSceneContent requestSceneContent = new RequestSceneContent();
				requestSceneContent.DeserializeMessage(data);
				return requestSceneContent;
			}
			if (num2 == 1044700862u)
			{
				ResponseServerInviteToParty responseServerInviteToParty = new ResponseServerInviteToParty();
				responseServerInviteToParty.DeserializeMessage(data);
				return responseServerInviteToParty;
			}
			if (num2 == 1050787770u)
			{
				RequestLobbySwitchOwner requestLobbySwitchOwner = new RequestLobbySwitchOwner();
				requestLobbySwitchOwner.DeserializeMessage(data);
				return requestLobbySwitchOwner;
			}
			if (num2 == 1063273969u)
			{
				ResponseSecurityHandshake responseSecurityHandshake = new ResponseSecurityHandshake();
				responseSecurityHandshake.DeserializeMessage(data);
				return responseSecurityHandshake;
			}
			if (num2 == 1086350166u)
			{
				RequestSetHeroSelectedSkin requestSetHeroSelectedSkin = new RequestSetHeroSelectedSkin();
				requestSetHeroSelectedSkin.DeserializeMessage(data);
				return requestSetHeroSelectedSkin;
			}
			if (num2 == 1109727550u)
			{
				RequestLeaderboardInfo requestLeaderboardInfo = new RequestLeaderboardInfo();
				requestLeaderboardInfo.DeserializeMessage(data);
				return requestLeaderboardInfo;
			}
			if (num2 == 1111650129u)
			{
				PushPlayerBucketProgress pushPlayerBucketProgress = new PushPlayerBucketProgress();
				pushPlayerBucketProgress.DeserializeMessage(data);
				return pushPlayerBucketProgress;
			}
			if (num2 == 1116757033u)
			{
				ResponseDeleteFriend responseDeleteFriend = new ResponseDeleteFriend();
				responseDeleteFriend.DeserializeMessage(data);
				return responseDeleteFriend;
			}
			if (num2 == 1133738214u)
			{
				RequestLobbyStartGame requestLobbyStartGame = new RequestLobbyStartGame();
				requestLobbyStartGame.DeserializeMessage(data);
				return requestLobbyStartGame;
			}
			if (num2 == 1165618225u)
			{
				RequestValidateReferralCode requestValidateReferralCode = new RequestValidateReferralCode();
				requestValidateReferralCode.DeserializeMessage(data);
				return requestValidateReferralCode;
			}
			if (num2 == 1170143662u)
			{
				RequestLobbyBotJoin requestLobbyBotJoin = new RequestLobbyBotJoin();
				requestLobbyBotJoin.DeserializeMessage(data);
				return requestLobbyBotJoin;
			}
			if (num2 == 1173273169u)
			{
				GameMapList gameMapList = new GameMapList();
				gameMapList.DeserializeMessage(data);
				return gameMapList;
			}
			if (num2 == 1205638919u)
			{
				RequestKeystoneLeaderboardInfo requestKeystoneLeaderboardInfo = new RequestKeystoneLeaderboardInfo();
				requestKeystoneLeaderboardInfo.DeserializeMessage(data);
				return requestKeystoneLeaderboardInfo;
			}
			if (num2 == 1206447194u)
			{
				ResponseClaimMessageItems responseClaimMessageItems = new ResponseClaimMessageItems();
				responseClaimMessageItems.DeserializeMessage(data);
				return responseClaimMessageItems;
			}
			if (num2 == 1215711276u)
			{
				ResponseMergeEUPlayer responseMergeEUPlayer = new ResponseMergeEUPlayer();
				responseMergeEUPlayer.DeserializeMessage(data);
				return responseMergeEUPlayer;
			}
			if (num2 == 1215984841u)
			{
				ResponsePlayerChangeDeckMeta responsePlayerChangeDeckMeta = new ResponsePlayerChangeDeckMeta();
				responsePlayerChangeDeckMeta.DeserializeMessage(data);
				return responsePlayerChangeDeckMeta;
			}
			if (num2 == 1225680865u)
			{
				ResponseAcceptKeystoneRollResult responseAcceptKeystoneRollResult = new ResponseAcceptKeystoneRollResult();
				responseAcceptKeystoneRollResult.DeserializeMessage(data);
				return responseAcceptKeystoneRollResult;
			}
			if (num2 == 1226402870u)
			{
				PushPlayerInventoryUpdate pushPlayerInventoryUpdate = new PushPlayerInventoryUpdate();
				pushPlayerInventoryUpdate.DeserializeMessage(data);
				return pushPlayerInventoryUpdate;
			}
			if (num2 == 1229156781u)
			{
				ResponseCancelGuildApplication responseCancelGuildApplication = new ResponseCancelGuildApplication();
				responseCancelGuildApplication.DeserializeMessage(data);
				return responseCancelGuildApplication;
			}
			if (num2 == 1244073833u)
			{
				RequestPlayerMessages requestPlayerMessages = new RequestPlayerMessages();
				requestPlayerMessages.DeserializeMessage(data);
				return requestPlayerMessages;
			}
			if (num2 == 1289682847u)
			{
				RequestClaimMessageItems requestClaimMessageItems = new RequestClaimMessageItems();
				requestClaimMessageItems.DeserializeMessage(data);
				return requestClaimMessageItems;
			}
			if (num2 == 1292321742u)
			{
				StopMatchmaking stopMatchmaking = new StopMatchmaking();
				stopMatchmaking.DeserializeMessage(data);
				return stopMatchmaking;
			}
			if (num2 == 1315871696u)
			{
				ResponseChallengeLeaderboardInfo responseChallengeLeaderboardInfo = new ResponseChallengeLeaderboardInfo();
				responseChallengeLeaderboardInfo.DeserializeMessage(data);
				return responseChallengeLeaderboardInfo;
			}
			if (num2 == 1334854673u)
			{
				ServerAckInviteToLobby serverAckInviteToLobby = new ServerAckInviteToLobby();
				serverAckInviteToLobby.DeserializeMessage(data);
				return serverAckInviteToLobby;
			}
			if (num2 == 1350491743u)
			{
				RequestChatFilterOptionChange requestChatFilterOptionChange = new RequestChatFilterOptionChange();
				requestChatFilterOptionChange.DeserializeMessage(data);
				return requestChatFilterOptionChange;
			}
			if (num2 == 1374619617u)
			{
				RequestStreamerAPIStateChange requestStreamerAPIStateChange = new RequestStreamerAPIStateChange();
				requestStreamerAPIStateChange.DeserializeMessage(data);
				return requestStreamerAPIStateChange;
			}
			if (num2 == 1398724449u)
			{
				ResponseSubscribeToLobbyList responseSubscribeToLobbyList = new ResponseSubscribeToLobbyList();
				responseSubscribeToLobbyList.DeserializeMessage(data);
				return responseSubscribeToLobbyList;
			}
			if (num2 == 1407420368u)
			{
				RequestSetGuildMOTD requestSetGuildMOTD = new RequestSetGuildMOTD();
				requestSetGuildMOTD.DeserializeMessage(data);
				return requestSetGuildMOTD;
			}
			if (num2 == 1411369296u)
			{
				RequestLobbyMap requestLobbyMap = new RequestLobbyMap();
				requestLobbyMap.DeserializeMessage(data);
				return requestLobbyMap;
			}
			if (num2 == 1456395410u)
			{
				ResponseGetApplicationsForGuild responseGetApplicationsForGuild = new ResponseGetApplicationsForGuild();
				responseGetApplicationsForGuild.DeserializeMessage(data);
				return responseGetApplicationsForGuild;
			}
			if (num2 == 1471400544u)
			{
				AuthLoginUserResponse authLoginUserResponse = new AuthLoginUserResponse();
				authLoginUserResponse.DeserializeMessage(data);
				return authLoginUserResponse;
			}
			if (num2 == 1473617704u)
			{
				RequestLeaveDiscordChannel requestLeaveDiscordChannel = new RequestLeaveDiscordChannel();
				requestLeaveDiscordChannel.DeserializeMessage(data);
				return requestLeaveDiscordChannel;
			}
			if (num2 == 1536792188u)
			{
				PushPartyLeaderViewSync pushPartyLeaderViewSync = new PushPartyLeaderViewSync();
				pushPartyLeaderViewSync.DeserializeMessage(data);
				return pushPartyLeaderViewSync;
			}
			if (num2 == 1542079736u)
			{
				PushPlayerBoostStatus pushPlayerBoostStatus = new PushPlayerBoostStatus();
				pushPlayerBoostStatus.DeserializeMessage(data);
				return pushPlayerBoostStatus;
			}
			if (num2 == 1544099622u)
			{
				PacketTutorialRewards packetTutorialRewards = new PacketTutorialRewards();
				packetTutorialRewards.DeserializeMessage(data);
				return packetTutorialRewards;
			}
			if (num2 == 1556993237u)
			{
				ResponseInsertPartIntoSlot responseInsertPartIntoSlot = new ResponseInsertPartIntoSlot();
				responseInsertPartIntoSlot.DeserializeMessage(data);
				return responseInsertPartIntoSlot;
			}
			if (num2 == 1564432359u)
			{
				RequestMatchmakingGameFoundSetReady requestMatchmakingGameFoundSetReady = new RequestMatchmakingGameFoundSetReady();
				requestMatchmakingGameFoundSetReady.DeserializeMessage(data);
				return requestMatchmakingGameFoundSetReady;
			}
			if (num2 == 1585384496u)
			{
				PushBaseSabotageItems pushBaseSabotageItems = new PushBaseSabotageItems();
				pushBaseSabotageItems.DeserializeMessage(data);
				return pushBaseSabotageItems;
			}
			if (num2 == 1601419097u)
			{
				RequestDirectLobbyCreate requestDirectLobbyCreate = new RequestDirectLobbyCreate();
				requestDirectLobbyCreate.DeserializeMessage(data);
				return requestDirectLobbyCreate;
			}
			if (num2 == 1612224104u)
			{
				SendWhisper sendWhisper = new SendWhisper();
				sendWhisper.DeserializeMessage(data);
				return sendWhisper;
			}
			if (num2 == 1635088610u)
			{
				RequestAcceptGuildInvite requestAcceptGuildInvite = new RequestAcceptGuildInvite();
				requestAcceptGuildInvite.DeserializeMessage(data);
				return requestAcceptGuildInvite;
			}
			if (num2 == 1681602214u)
			{
				ResponseBotList responseBotList = new ResponseBotList();
				responseBotList.DeserializeMessage(data);
				return responseBotList;
			}
			if (num2 == 1694706661u)
			{
				RequestCreateLobbyKeystoneParty requestCreateLobbyKeystoneParty = new RequestCreateLobbyKeystoneParty();
				requestCreateLobbyKeystoneParty.DeserializeMessage(data);
				return requestCreateLobbyKeystoneParty;
			}
			if (num2 == 1699053877u)
			{
				ResponseGuildCreationRequirements responseGuildCreationRequirements = new ResponseGuildCreationRequirements();
				responseGuildCreationRequirements.DeserializeMessage(data);
				return responseGuildCreationRequirements;
			}
			if (num2 == 1702958271u)
			{
				RequestRefreshQuests requestRefreshQuests = new RequestRefreshQuests();
				requestRefreshQuests.DeserializeMessage(data);
				return requestRefreshQuests;
			}
			if (num2 == 1709635275u)
			{
				ResponseLeaveDiscordChannel responseLeaveDiscordChannel = new ResponseLeaveDiscordChannel();
				responseLeaveDiscordChannel.DeserializeMessage(data);
				return responseLeaveDiscordChannel;
			}
			if (num2 == 1710476665u)
			{
				RequestGetPlayerProfile requestGetPlayerProfile = new RequestGetPlayerProfile();
				requestGetPlayerProfile.DeserializeMessage(data);
				return requestGetPlayerProfile;
			}
			if (num2 == 1747317513u)
			{
				PushSabotageRankingDefinition pushSabotageRankingDefinition = new PushSabotageRankingDefinition();
				pushSabotageRankingDefinition.DeserializeMessage(data);
				return pushSabotageRankingDefinition;
			}
			if (num2 == 1750828980u)
			{
				ResponsePlayerDeleteDeck responsePlayerDeleteDeck = new ResponsePlayerDeleteDeck();
				responsePlayerDeleteDeck.DeserializeMessage(data);
				return responsePlayerDeleteDeck;
			}
			if (num2 == 1763839624u)
			{
				RequestRejectGuildApplication requestRejectGuildApplication = new RequestRejectGuildApplication();
				requestRejectGuildApplication.DeserializeMessage(data);
				return requestRejectGuildApplication;
			}
			if (num2 == 1764966259u)
			{
				ResponseApplyToGuild responseApplyToGuild = new ResponseApplyToGuild();
				responseApplyToGuild.DeserializeMessage(data);
				return responseApplyToGuild;
			}
			if (num2 == 1779119402u)
			{
				ResponseCreateSpecialLobby responseCreateSpecialLobby = new ResponseCreateSpecialLobby();
				responseCreateSpecialLobby.DeserializeMessage(data);
				return responseCreateSpecialLobby;
			}
			if (num2 == 1781460956u)
			{
				RequestRemovePartFromSlot requestRemovePartFromSlot = new RequestRemovePartFromSlot();
				requestRemovePartFromSlot.DeserializeMessage(data);
				return requestRemovePartFromSlot;
			}
			if (num2 == 1782803239u)
			{
				ResponseAcceptGuildInvite responseAcceptGuildInvite = new ResponseAcceptGuildInvite();
				responseAcceptGuildInvite.DeserializeMessage(data);
				return responseAcceptGuildInvite;
			}
			if (num2 == 1785681866u)
			{
				RequestSubscribeToLobbyList requestSubscribeToLobbyList = new RequestSubscribeToLobbyList();
				requestSubscribeToLobbyList.DeserializeMessage(data);
				return requestSubscribeToLobbyList;
			}
			if (num2 == 1788117334u)
			{
				ResponseCreateFriendRequestByAccountSUID responseCreateFriendRequestByAccountSUID = new ResponseCreateFriendRequestByAccountSUID();
				responseCreateFriendRequestByAccountSUID.DeserializeMessage(data);
				return responseCreateFriendRequestByAccountSUID;
			}
			if (num2 == 1796795828u)
			{
				SteamLoginRequest steamLoginRequest = new SteamLoginRequest();
				steamLoginRequest.DeserializeMessage(data);
				return steamLoginRequest;
			}
			if (num2 == 1825981010u)
			{
				ResponseValidateNickname responseValidateNickname = new ResponseValidateNickname();
				responseValidateNickname.DeserializeMessage(data);
				return responseValidateNickname;
			}
			if (num2 == 1834887503u)
			{
				NotifyCampaignStarted notifyCampaignStarted = new NotifyCampaignStarted();
				notifyCampaignStarted.DeserializeMessage(data);
				return notifyCampaignStarted;
			}
			if (num2 == 1835714875u)
			{
				RequestPlayerDecks requestPlayerDecks = new RequestPlayerDecks();
				requestPlayerDecks.DeserializeMessage(data);
				return requestPlayerDecks;
			}
			if (num2 == 1843771463u)
			{
				RequestCreateChatRoom requestCreateChatRoom = new RequestCreateChatRoom();
				requestCreateChatRoom.DeserializeMessage(data);
				return requestCreateChatRoom;
			}
			if (num2 == 1859310746u)
			{
				RequestTutorialRewards requestTutorialRewards = new RequestTutorialRewards();
				requestTutorialRewards.DeserializeMessage(data);
				return requestTutorialRewards;
			}
			if (num2 == 1866800103u)
			{
				ResponseValidateEmail responseValidateEmail = new ResponseValidateEmail();
				responseValidateEmail.DeserializeMessage(data);
				return responseValidateEmail;
			}
			if (num2 == 1900803170u)
			{
				RequestPlayerChangeDeckMeta requestPlayerChangeDeckMeta = new RequestPlayerChangeDeckMeta();
				requestPlayerChangeDeckMeta.DeserializeMessage(data);
				return requestPlayerChangeDeckMeta;
			}
			if (num2 == 1916628191u)
			{
				ResponseSendGuildInvite responseSendGuildInvite = new ResponseSendGuildInvite();
				responseSendGuildInvite.DeserializeMessage(data);
				return responseSendGuildInvite;
			}
			if (num2 == 1921477382u)
			{
				ServerInviteToLobby serverInviteToLobby = new ServerInviteToLobby();
				serverInviteToLobby.DeserializeMessage(data);
				return serverInviteToLobby;
			}
			if (num2 == 1928530613u)
			{
				ResponseSetHeroSelectedSkin responseSetHeroSelectedSkin = new ResponseSetHeroSelectedSkin();
				responseSetHeroSelectedSkin.DeserializeMessage(data);
				return responseSetHeroSelectedSkin;
			}
			if (num2 == 1931475128u)
			{
				PushUserRegionStore pushUserRegionStore = new PushUserRegionStore();
				pushUserRegionStore.DeserializeMessage(data);
				return pushUserRegionStore;
			}
			if (num2 == 1943499147u)
			{
				RequestLobbyList requestLobbyList = new RequestLobbyList();
				requestLobbyList.DeserializeMessage(data);
				return requestLobbyList;
			}
			if (num2 == 1956461478u)
			{
				RequestLobbySelectReady requestLobbySelectReady = new RequestLobbySelectReady();
				requestLobbySelectReady.DeserializeMessage(data);
				return requestLobbySelectReady;
			}
			if (num2 == 1956477434u)
			{
				RequestCreateFriendRequestByName requestCreateFriendRequestByName = new RequestCreateFriendRequestByName();
				requestCreateFriendRequestByName.DeserializeMessage(data);
				return requestCreateFriendRequestByName;
			}
			if (num2 == 1957759188u)
			{
				RequestPartyChatID requestPartyChatID = new RequestPartyChatID();
				requestPartyChatID.DeserializeMessage(data);
				return requestPartyChatID;
			}
			if (num2 == 1962576938u)
			{
				ResponseStoreData responseStoreData = new ResponseStoreData();
				responseStoreData.DeserializeMessage(data);
				return responseStoreData;
			}
			if (num2 == 1963338851u)
			{
				DataLobbyEvent dataLobbyEvent = new DataLobbyEvent();
				dataLobbyEvent.DeserializeMessage(data);
				return dataLobbyEvent;
			}
			if (num2 == 1964942180u)
			{
				PingCharacter pingCharacter = new PingCharacter();
				pingCharacter.DeserializeMessage(data);
				return pingCharacter;
			}
			if (num2 == 1971254749u)
			{
				RequestToggleGuildAcceptingApplications requestToggleGuildAcceptingApplications = new RequestToggleGuildAcceptingApplications();
				requestToggleGuildAcceptingApplications.DeserializeMessage(data);
				return requestToggleGuildAcceptingApplications;
			}
			if (num2 == 1983900715u)
			{
				DataGameResults dataGameResults = new DataGameResults();
				dataGameResults.DeserializeMessage(data);
				return dataGameResults;
			}
			if (num2 == 1989657788u)
			{
				ResponsePlayerDeckDetail responsePlayerDeckDetail = new ResponsePlayerDeckDetail();
				responsePlayerDeckDetail.DeserializeMessage(data);
				return responsePlayerDeckDetail;
			}
			if (num2 == 1990053639u)
			{
				ResponseEventChestContents responseEventChestContents = new ResponseEventChestContents();
				responseEventChestContents.DeserializeMessage(data);
				return responseEventChestContents;
			}
			if (num2 == 2000782293u)
			{
				PlayerPresenceChanged playerPresenceChanged = new PlayerPresenceChanged();
				playerPresenceChanged.DeserializeMessage(data);
				return playerPresenceChanged;
			}
			if (num2 == 2003965106u)
			{
				ResponseStarAwardsEarnedList responseStarAwardsEarnedList = new ResponseStarAwardsEarnedList();
				responseStarAwardsEarnedList.DeserializeMessage(data);
				return responseStarAwardsEarnedList;
			}
			if (num2 == 2024685958u)
			{
				ResponseCreateGuild responseCreateGuild = new ResponseCreateGuild();
				responseCreateGuild.DeserializeMessage(data);
				return responseCreateGuild;
			}
			if (num2 == 2030660920u)
			{
				RequestDisbandGuild requestDisbandGuild = new RequestDisbandGuild();
				requestDisbandGuild.DeserializeMessage(data);
				return requestDisbandGuild;
			}
			if (num2 == 2031261405u)
			{
				ResponsePlayerStats responsePlayerStats = new ResponsePlayerStats();
				responsePlayerStats.DeserializeMessage(data);
				return responsePlayerStats;
			}
			if (num2 == 2043110444u)
			{
				RequestLobbyDeckList requestLobbyDeckList = new RequestLobbyDeckList();
				requestLobbyDeckList.DeserializeMessage(data);
				return requestLobbyDeckList;
			}
			if (num2 == 2057406401u)
			{
				RequestLobbySelectPlayerSkin requestLobbySelectPlayerSkin = new RequestLobbySelectPlayerSkin();
				requestLobbySelectPlayerSkin.DeserializeMessage(data);
				return requestLobbySelectPlayerSkin;
			}
			if (num2 == 2067121577u)
			{
				ResponseServerInviteToLobby responseServerInviteToLobby = new ResponseServerInviteToLobby();
				responseServerInviteToLobby.DeserializeMessage(data);
				return responseServerInviteToLobby;
			}
			if (num2 == 2076770114u)
			{
				RequestLobbyUpdateDeck requestLobbyUpdateDeck = new RequestLobbyUpdateDeck();
				requestLobbyUpdateDeck.DeserializeMessage(data);
				return requestLobbyUpdateDeck;
			}
			if (num2 == 2077932908u)
			{
				RequestReportTutorialProgressAnalytics requestReportTutorialProgressAnalytics = new RequestReportTutorialProgressAnalytics();
				requestReportTutorialProgressAnalytics.DeserializeMessage(data);
				return requestReportTutorialProgressAnalytics;
			}
			if (num2 == 2078895210u)
			{
				RequestGuildListSearchByName requestGuildListSearchByName = new RequestGuildListSearchByName();
				requestGuildListSearchByName.DeserializeMessage(data);
				return requestGuildListSearchByName;
			}
			if (num2 == 2082863735u)
			{
				RequestPostLoginPackets requestPostLoginPackets = new RequestPostLoginPackets();
				requestPostLoginPackets.DeserializeMessage(data);
				return requestPostLoginPackets;
			}
			if (num2 == 2085121178u)
			{
				ResponseValidateReferralCode responseValidateReferralCode = new ResponseValidateReferralCode();
				responseValidateReferralCode.DeserializeMessage(data);
				return responseValidateReferralCode;
			}
			if (num2 == 2109342607u)
			{
				ServerPromoteNewLeader serverPromoteNewLeader = new ServerPromoteNewLeader();
				serverPromoteNewLeader.DeserializeMessage(data);
				return serverPromoteNewLeader;
			}
			if (num2 == 2134158244u)
			{
				RequestLobbySelectTeam requestLobbySelectTeam = new RequestLobbySelectTeam();
				requestLobbySelectTeam.DeserializeMessage(data);
				return requestLobbySelectTeam;
			}
			if (num2 == 2144674986u)
			{
				ResponsePromoteGuildMember responsePromoteGuildMember = new ResponsePromoteGuildMember();
				responsePromoteGuildMember.DeserializeMessage(data);
				return responsePromoteGuildMember;
			}
			if (num2 == 2162058774u)
			{
				RequestAcceptFriendRequest requestAcceptFriendRequest = new RequestAcceptFriendRequest();
				requestAcceptFriendRequest.DeserializeMessage(data);
				return requestAcceptFriendRequest;
			}
			if (num2 == 2165191942u)
			{
				RequestCreateSpecialLobby requestCreateSpecialLobby = new RequestCreateSpecialLobby();
				requestCreateSpecialLobby.DeserializeMessage(data);
				return requestCreateSpecialLobby;
			}
			if (num2 == 2166007453u)
			{
				RequestValidateNickname requestValidateNickname = new RequestValidateNickname();
				requestValidateNickname.DeserializeMessage(data);
				return requestValidateNickname;
			}
			if (num2 == 2167140336u)
			{
				ResponseRemovePartFromSlot responseRemovePartFromSlot = new ResponseRemovePartFromSlot();
				responseRemovePartFromSlot.DeserializeMessage(data);
				return responseRemovePartFromSlot;
			}
			if (num2 == 2176573297u)
			{
				ForceReconnectPush forceReconnectPush = new ForceReconnectPush();
				forceReconnectPush.DeserializeMessage(data);
				return forceReconnectPush;
			}
			if (num2 == 2221870570u)
			{
				RequestUpdateNameplate requestUpdateNameplate = new RequestUpdateNameplate();
				requestUpdateNameplate.DeserializeMessage(data);
				return requestUpdateNameplate;
			}
			if (num2 == 2231136327u)
			{
				RequestValidateEmail requestValidateEmail = new RequestValidateEmail();
				requestValidateEmail.DeserializeMessage(data);
				return requestValidateEmail;
			}
			if (num2 == 2241291131u)
			{
				RequestPlayerDeleteDeck requestPlayerDeleteDeck = new RequestPlayerDeleteDeck();
				requestPlayerDeleteDeck.DeserializeMessage(data);
				return requestPlayerDeleteDeck;
			}
			if (num2 == 2260294134u)
			{
				ResponseHeroLevelRewards responseHeroLevelRewards = new ResponseHeroLevelRewards();
				responseHeroLevelRewards.DeserializeMessage(data);
				return responseHeroLevelRewards;
			}
			if (num2 == 2285840822u)
			{
				ResponseGetPlayerProfile responseGetPlayerProfile = new ResponseGetPlayerProfile();
				responseGetPlayerProfile.DeserializeMessage(data);
				return responseGetPlayerProfile;
			}
			if (num2 == 2287934850u)
			{
				ResponseServerAckInviteToLobby responseServerAckInviteToLobby = new ResponseServerAckInviteToLobby();
				responseServerAckInviteToLobby.DeserializeMessage(data);
				return responseServerAckInviteToLobby;
			}
			if (num2 == 2303525649u)
			{
				RecipientRequestInviteToLobby recipientRequestInviteToLobby = new RecipientRequestInviteToLobby();
				recipientRequestInviteToLobby.DeserializeMessage(data);
				return recipientRequestInviteToLobby;
			}
			if (num2 == 2308775205u)
			{
				ResponseGuildListInfo responseGuildListInfo = new ResponseGuildListInfo();
				responseGuildListInfo.DeserializeMessage(data);
				return responseGuildListInfo;
			}
			if (num2 == 2310662297u)
			{
				RequestResendSteamConfirmationCode requestResendSteamConfirmationCode = new RequestResendSteamConfirmationCode();
				requestResendSteamConfirmationCode.DeserializeMessage(data);
				return requestResendSteamConfirmationCode;
			}
			if (num2 == 2330897222u)
			{
				ResponseSceneContent responseSceneContent = new ResponseSceneContent();
				responseSceneContent.DeserializeMessage(data);
				return responseSceneContent;
			}
			if (num2 == 2344008563u)
			{
				RequestLobbySelectCharacter requestLobbySelectCharacter = new RequestLobbySelectCharacter();
				requestLobbySelectCharacter.DeserializeMessage(data);
				return requestLobbySelectCharacter;
			}
			if (num2 == 2357170998u)
			{
				RequestValidateAccountForSteam requestValidateAccountForSteam = new RequestValidateAccountForSteam();
				requestValidateAccountForSteam.DeserializeMessage(data);
				return requestValidateAccountForSteam;
			}
			if (num2 == 2373787869u)
			{
				RemovePlayerFromPartyLeftGameEarly removePlayerFromPartyLeftGameEarly = new RemovePlayerFromPartyLeftGameEarly();
				removePlayerFromPartyLeftGameEarly.DeserializeMessage(data);
				return removePlayerFromPartyLeftGameEarly;
			}
			if (num2 == 2376677189u)
			{
				ResponsePlayerDecks responsePlayerDecks = new ResponsePlayerDecks();
				responsePlayerDecks.DeserializeMessage(data);
				return responsePlayerDecks;
			}
			if (num2 == 2376855915u)
			{
				RequestPartyLeaderViewSync requestPartyLeaderViewSync = new RequestPartyLeaderViewSync();
				requestPartyLeaderViewSync.DeserializeMessage(data);
				return requestPartyLeaderViewSync;
			}
			if (num2 == 2408005643u)
			{
				RecipientResponseInviteToLobby recipientResponseInviteToLobby = new RecipientResponseInviteToLobby();
				recipientResponseInviteToLobby.DeserializeMessage(data);
				return recipientResponseInviteToLobby;
			}
			if (num2 == 2413974151u)
			{
				ResponseAddTutorialProgress responseAddTutorialProgress = new ResponseAddTutorialProgress();
				responseAddTutorialProgress.DeserializeMessage(data);
				return responseAddTutorialProgress;
			}
			if (num2 == 2448266203u)
			{
				UserRegisterResponse userRegisterResponse = new UserRegisterResponse();
				userRegisterResponse.DeserializeMessage(data);
				return userRegisterResponse;
			}
			if (num2 == 2457735052u)
			{
				ResponseLobbyDeckList responseLobbyDeckList = new ResponseLobbyDeckList();
				responseLobbyDeckList.DeserializeMessage(data);
				return responseLobbyDeckList;
			}
			if (num2 == 2459401689u)
			{
				SteamLoginResponse steamLoginResponse = new SteamLoginResponse();
				steamLoginResponse.DeserializeMessage(data);
				return steamLoginResponse;
			}
			if (num2 == 2464273229u)
			{
				PushPlayerCommunityEventsListForNetwork pushPlayerCommunityEventsListForNetwork = new PushPlayerCommunityEventsListForNetwork();
				pushPlayerCommunityEventsListForNetwork.DeserializeMessage(data);
				return pushPlayerCommunityEventsListForNetwork;
			}
			if (num2 == 2470600690u)
			{
				ResponseAcceptGuildApplication responseAcceptGuildApplication = new ResponseAcceptGuildApplication();
				responseAcceptGuildApplication.DeserializeMessage(data);
				return responseAcceptGuildApplication;
			}
			if (num2 == 2490562218u)
			{
				ResponsePartyChatID responsePartyChatID = new ResponsePartyChatID();
				responsePartyChatID.DeserializeMessage(data);
				return responsePartyChatID;
			}
			if (num2 == 2491272374u)
			{
				RequestRemoveNewInventoryFlag requestRemoveNewInventoryFlag = new RequestRemoveNewInventoryFlag();
				requestRemoveNewInventoryFlag.DeserializeMessage(data);
				return requestRemoveNewInventoryFlag;
			}
			if (num2 == 2496668806u)
			{
				RequestPromoteGuildMember requestPromoteGuildMember = new RequestPromoteGuildMember();
				requestPromoteGuildMember.DeserializeMessage(data);
				return requestPromoteGuildMember;
			}
			if (num2 == 2501474871u)
			{
				RequestCancelGuildInvite requestCancelGuildInvite = new RequestCancelGuildInvite();
				requestCancelGuildInvite.DeserializeMessage(data);
				return requestCancelGuildInvite;
			}
			if (num2 == 2523278831u)
			{
				RequestDirectLobbyCreateParty requestDirectLobbyCreateParty = new RequestDirectLobbyCreateParty();
				requestDirectLobbyCreateParty.DeserializeMessage(data);
				return requestDirectLobbyCreateParty;
			}
			if (num2 == 2533259941u)
			{
				ResponseClientHandshake responseClientHandshake = new ResponseClientHandshake();
				responseClientHandshake.DeserializeMessage(data);
				return responseClientHandshake;
			}
			if (num2 == 2535039156u)
			{
				RequestMatchmakingGameFoundSetDeclined requestMatchmakingGameFoundSetDeclined = new RequestMatchmakingGameFoundSetDeclined();
				requestMatchmakingGameFoundSetDeclined.DeserializeMessage(data);
				return requestMatchmakingGameFoundSetDeclined;
			}
			if (num2 == 2538380145u)
			{
				RequestGetFriendRequests requestGetFriendRequests = new RequestGetFriendRequests();
				requestGetFriendRequests.DeserializeMessage(data);
				return requestGetFriendRequests;
			}
			if (num2 == 2554349678u)
			{
				ResponseLevelUnlocks responseLevelUnlocks = new ResponseLevelUnlocks();
				responseLevelUnlocks.DeserializeMessage(data);
				return responseLevelUnlocks;
			}
			if (num2 == 2554494830u)
			{
				ResponseReplaceQuest responseReplaceQuest = new ResponseReplaceQuest();
				responseReplaceQuest.DeserializeMessage(data);
				return responseReplaceQuest;
			}
			if (num2 == 2556482078u)
			{
				PushLobbyJoined pushLobbyJoined = new PushLobbyJoined();
				pushLobbyJoined.DeserializeMessage(data);
				return pushLobbyJoined;
			}
			if (num2 == 2557329400u)
			{
				RequestCreateGuild requestCreateGuild = new RequestCreateGuild();
				requestCreateGuild.DeserializeMessage(data);
				return requestCreateGuild;
			}
			if (num2 == 2558117204u)
			{
				PushPartyMemberUpdate pushPartyMemberUpdate = new PushPartyMemberUpdate();
				pushPartyMemberUpdate.DeserializeMessage(data);
				return pushPartyMemberUpdate;
			}
			if (num2 == 2567433079u)
			{
				PushDiscordAccessToken pushDiscordAccessToken = new PushDiscordAccessToken();
				pushDiscordAccessToken.DeserializeMessage(data);
				return pushDiscordAccessToken;
			}
			if (num2 == 2573065639u)
			{
				PlayerAwardNotification playerAwardNotification = new PlayerAwardNotification();
				playerAwardNotification.DeserializeMessage(data);
				return playerAwardNotification;
			}
			if (num2 == 2580637859u)
			{
				RequestPlayerStats requestPlayerStats = new RequestPlayerStats();
				requestPlayerStats.DeserializeMessage(data);
				return requestPlayerStats;
			}
			if (num2 == 2583444957u)
			{
				PushPlayerAchievements pushPlayerAchievements = new PushPlayerAchievements();
				pushPlayerAchievements.DeserializeMessage(data);
				return pushPlayerAchievements;
			}
			if (num2 == 2599956064u)
			{
				RequestPreviousChallengeLeaderboardInfo requestPreviousChallengeLeaderboardInfo = new RequestPreviousChallengeLeaderboardInfo();
				requestPreviousChallengeLeaderboardInfo.DeserializeMessage(data);
				return requestPreviousChallengeLeaderboardInfo;
			}
			if (num2 == 2606440563u)
			{
				RequestPlayerDeckDetail requestPlayerDeckDetail = new RequestPlayerDeckDetail();
				requestPlayerDeckDetail.DeserializeMessage(data);
				return requestPlayerDeckDetail;
			}
			if (num2 == 2618024601u)
			{
				ResponsePlayerPostDeckUpdate responsePlayerPostDeckUpdate = new ResponsePlayerPostDeckUpdate();
				responsePlayerPostDeckUpdate.DeserializeMessage(data);
				return responsePlayerPostDeckUpdate;
			}
			if (num2 == 2618955242u)
			{
				ResponsePlayerMessages responsePlayerMessages = new ResponsePlayerMessages();
				responsePlayerMessages.DeserializeMessage(data);
				return responsePlayerMessages;
			}
			if (num2 == 2624349486u)
			{
				PushMatchmakingGameFoundPlayerDeclined pushMatchmakingGameFoundPlayerDeclined = new PushMatchmakingGameFoundPlayerDeclined();
				pushMatchmakingGameFoundPlayerDeclined.DeserializeMessage(data);
				return pushMatchmakingGameFoundPlayerDeclined;
			}
			if (num2 == 2624590464u)
			{
				ResponseResendConfirmationCode responseResendConfirmationCode = new ResponseResendConfirmationCode();
				responseResendConfirmationCode.DeserializeMessage(data);
				return responseResendConfirmationCode;
			}
			if (num2 == 2625276084u)
			{
				ResponseGetFriendRequests responseGetFriendRequests = new ResponseGetFriendRequests();
				responseGetFriendRequests.DeserializeMessage(data);
				return responseGetFriendRequests;
			}
			if (num2 == 2627607225u)
			{
				RequestLeaveChatRoom requestLeaveChatRoom = new RequestLeaveChatRoom();
				requestLeaveChatRoom.DeserializeMessage(data);
				return requestLeaveChatRoom;
			}
			if (num2 == 2633880644u)
			{
				PlayerJoinedParty playerJoinedParty = new PlayerJoinedParty();
				playerJoinedParty.DeserializeMessage(data);
				return playerJoinedParty;
			}
			if (num2 == 2639488929u)
			{
				RequestLobbyLockTeams requestLobbyLockTeams = new RequestLobbyLockTeams();
				requestLobbyLockTeams.DeserializeMessage(data);
				return requestLobbyLockTeams;
			}
			if (num2 == 2653907442u)
			{
				ResponseCancelGuildInvite responseCancelGuildInvite = new ResponseCancelGuildInvite();
				responseCancelGuildInvite.DeserializeMessage(data);
				return responseCancelGuildInvite;
			}
			if (num2 == 2660770430u)
			{
				ResponseCampaignDefinitions responseCampaignDefinitions = new ResponseCampaignDefinitions();
				responseCampaignDefinitions.DeserializeMessage(data);
				return responseCampaignDefinitions;
			}
			if (num2 == 2679650332u)
			{
				ResponseGetGuildInvitesForGuild responseGetGuildInvitesForGuild = new ResponseGetGuildInvitesForGuild();
				responseGetGuildInvitesForGuild.DeserializeMessage(data);
				return responseGetGuildInvitesForGuild;
			}
			if (num2 == 2690842427u)
			{
				PushPlayerCampaignProgress pushPlayerCampaignProgress = new PushPlayerCampaignProgress();
				pushPlayerCampaignProgress.DeserializeMessage(data);
				return pushPlayerCampaignProgress;
			}
			if (num2 == 2710198925u)
			{
				FriendRequestAccepted friendRequestAccepted = new FriendRequestAccepted();
				friendRequestAccepted.DeserializeMessage(data);
				return friendRequestAccepted;
			}
			if (num2 == 2725020781u)
			{
				ClearChatIDForGuild clearChatIDForGuild = new ClearChatIDForGuild();
				clearChatIDForGuild.DeserializeMessage(data);
				return clearChatIDForGuild;
			}
			if (num2 == 2733645551u)
			{
				PushGuildApplicationAdded pushGuildApplicationAdded = new PushGuildApplicationAdded();
				pushGuildApplicationAdded.DeserializeMessage(data);
				return pushGuildApplicationAdded;
			}
			if (num2 == 2734367319u)
			{
				CurrentWeeklyChallengeViewed currentWeeklyChallengeViewed = new CurrentWeeklyChallengeViewed();
				currentWeeklyChallengeViewed.DeserializeMessage(data);
				return currentWeeklyChallengeViewed;
			}
			if (num2 == 2748261260u)
			{
				RequestMergeEUPlayer requestMergeEUPlayer = new RequestMergeEUPlayer();
				requestMergeEUPlayer.DeserializeMessage(data);
				return requestMergeEUPlayer;
			}
			if (num2 == 2772066866u)
			{
				RequestPlayerPostDeckUpdate requestPlayerPostDeckUpdate = new RequestPlayerPostDeckUpdate();
				requestPlayerPostDeckUpdate.DeserializeMessage(data);
				return requestPlayerPostDeckUpdate;
			}
			if (num2 == 2789833521u)
			{
				RequestGuildListSearchByTag requestGuildListSearchByTag = new RequestGuildListSearchByTag();
				requestGuildListSearchByTag.DeserializeMessage(data);
				return requestGuildListSearchByTag;
			}
			if (num2 == 2795266388u)
			{
				NotifyWorkshopTaskComplete notifyWorkshopTaskComplete = new NotifyWorkshopTaskComplete();
				notifyWorkshopTaskComplete.DeserializeMessage(data);
				return notifyWorkshopTaskComplete;
			}
			if (num2 == 2803163958u)
			{
				UserRegisterRequest userRegisterRequest = new UserRegisterRequest();
				userRegisterRequest.DeserializeMessage(data);
				return userRegisterRequest;
			}
			if (num2 == 2806149680u)
			{
				PS4LoginUserResponse ps4LoginUserResponse = new PS4LoginUserResponse();
				ps4LoginUserResponse.DeserializeMessage(data);
				return ps4LoginUserResponse;
			}
			if (num2 == 2843582931u)
			{
				ResponseVirtualCurrencyTransaction responseVirtualCurrencyTransaction = new ResponseVirtualCurrencyTransaction();
				responseVirtualCurrencyTransaction.DeserializeMessage(data);
				return responseVirtualCurrencyTransaction;
			}
			if (num2 == 2858233215u)
			{
				RequestPushGuildMOTD requestPushGuildMOTD = new RequestPushGuildMOTD();
				requestPushGuildMOTD.DeserializeMessage(data);
				return requestPushGuildMOTD;
			}
			if (num2 == 2869521887u)
			{
				RequestAcceptKeystoneRollResult requestAcceptKeystoneRollResult = new RequestAcceptKeystoneRollResult();
				requestAcceptKeystoneRollResult.DeserializeMessage(data);
				return requestAcceptKeystoneRollResult;
			}
			if (num2 == 2885615105u)
			{
				PushUnrealGameRestartData pushUnrealGameRestartData = new PushUnrealGameRestartData();
				pushUnrealGameRestartData.DeserializeMessage(data);
				return pushUnrealGameRestartData;
			}
			if (num2 == 2892599790u)
			{
				RequestChallengeLeaderboardInfo requestChallengeLeaderboardInfo = new RequestChallengeLeaderboardInfo();
				requestChallengeLeaderboardInfo.DeserializeMessage(data);
				return requestChallengeLeaderboardInfo;
			}
			if (num2 == 2901968593u)
			{
				ServerLeaveParty serverLeaveParty = new ServerLeaveParty();
				serverLeaveParty.DeserializeMessage(data);
				return serverLeaveParty;
			}
			if (num2 == 2902685399u)
			{
				ResponseDailyLoginRewards responseDailyLoginRewards = new ResponseDailyLoginRewards();
				responseDailyLoginRewards.DeserializeMessage(data);
				return responseDailyLoginRewards;
			}
			if (num2 == 2928865514u)
			{
				GuildPresenceChanged guildPresenceChanged = new GuildPresenceChanged();
				guildPresenceChanged.DeserializeMessage(data);
				return guildPresenceChanged;
			}
			if (num2 == 2937563507u)
			{
				PlayerCommunityEventsUpdatePush playerCommunityEventsUpdatePush = new PlayerCommunityEventsUpdatePush();
				playerCommunityEventsUpdatePush.DeserializeMessage(data);
				return playerCommunityEventsUpdatePush;
			}
			if (num2 == 2952920753u)
			{
				ResponseSabotageBuckets responseSabotageBuckets = new ResponseSabotageBuckets();
				responseSabotageBuckets.DeserializeMessage(data);
				return responseSabotageBuckets;
			}
			if (num2 == 2968550505u)
			{
				ResponseSkipPrologue responseSkipPrologue = new ResponseSkipPrologue();
				responseSkipPrologue.DeserializeMessage(data);
				return responseSkipPrologue;
			}
			if (num2 == 2981829448u)
			{
				PushCompletedQuests pushCompletedQuests = new PushCompletedQuests();
				pushCompletedQuests.DeserializeMessage(data);
				return pushCompletedQuests;
			}
			if (num2 == 2986645097u)
			{
				RequestLobbyBotLeave requestLobbyBotLeave = new RequestLobbyBotLeave();
				requestLobbyBotLeave.DeserializeMessage(data);
				return requestLobbyBotLeave;
			}
			if (num2 == 2990657820u)
			{
				DataLobbyDetail dataLobbyDetail = new DataLobbyDetail();
				dataLobbyDetail.DeserializeMessage(data);
				return dataLobbyDetail;
			}
			if (num2 == 3001880565u)
			{
				ResponseAcceptFriendRequest responseAcceptFriendRequest = new ResponseAcceptFriendRequest();
				responseAcceptFriendRequest.DeserializeMessage(data);
				return responseAcceptFriendRequest;
			}
			if (num2 == 3017243260u)
			{
				PushGuildMemberEntryAdded pushGuildMemberEntryAdded = new PushGuildMemberEntryAdded();
				pushGuildMemberEntryAdded.DeserializeMessage(data);
				return pushGuildMemberEntryAdded;
			}
			if (num2 == 3026339892u)
			{
				ReadyToReconnectRequest readyToReconnectRequest = new ReadyToReconnectRequest();
				readyToReconnectRequest.DeserializeMessage(data);
				return readyToReconnectRequest;
			}
			if (num2 == 3030360695u)
			{
				CommunityEventDataResponse communityEventDataResponse = new CommunityEventDataResponse();
				communityEventDataResponse.DeserializeMessage(data);
				return communityEventDataResponse;
			}
			if (num2 == 3038667611u)
			{
				ResponseCreateFriendRequestByName responseCreateFriendRequestByName = new ResponseCreateFriendRequestByName();
				responseCreateFriendRequestByName.DeserializeMessage(data);
				return responseCreateFriendRequestByName;
			}
			if (num2 == 3040623127u)
			{
				PushLeftGuild pushLeftGuild = new PushLeftGuild();
				pushLeftGuild.DeserializeMessage(data);
				return pushLeftGuild;
			}
			if (num2 == 3082283309u)
			{
				RequestCurrentChallengeLeaderboardInfo requestCurrentChallengeLeaderboardInfo = new RequestCurrentChallengeLeaderboardInfo();
				requestCurrentChallengeLeaderboardInfo.DeserializeMessage(data);
				return requestCurrentChallengeLeaderboardInfo;
			}
			if (num2 == 3083392249u)
			{
				RequestInsertPartIntoSlot requestInsertPartIntoSlot = new RequestInsertPartIntoSlot();
				requestInsertPartIntoSlot.DeserializeMessage(data);
				return requestInsertPartIntoSlot;
			}
			if (num2 == 3084580504u)
			{
				StoreTransactionComplete storeTransactionComplete = new StoreTransactionComplete();
				storeTransactionComplete.DeserializeMessage(data);
				return storeTransactionComplete;
			}
			if (num2 == 3091527972u)
			{
				PushGuildMemberEntryUpdated pushGuildMemberEntryUpdated = new PushGuildMemberEntryUpdated();
				pushGuildMemberEntryUpdated.DeserializeMessage(data);
				return pushGuildMemberEntryUpdated;
			}
			if (num2 == 3091555472u)
			{
				ResponseGetIncomingGuildInvites responseGetIncomingGuildInvites = new ResponseGetIncomingGuildInvites();
				responseGetIncomingGuildInvites.DeserializeMessage(data);
				return responseGetIncomingGuildInvites;
			}
			if (num2 == 3118710813u)
			{
				PushStarAwardEarnedEntry pushStarAwardEarnedEntry = new PushStarAwardEarnedEntry();
				pushStarAwardEarnedEntry.DeserializeMessage(data);
				return pushStarAwardEarnedEntry;
			}
			if (num2 == 3125105559u)
			{
				PushCanceledQuests pushCanceledQuests = new PushCanceledQuests();
				pushCanceledQuests.DeserializeMessage(data);
				return pushCanceledQuests;
			}
			if (num2 == 3133373011u)
			{
				ResponseSubmitConfirmationCode responseSubmitConfirmationCode = new ResponseSubmitConfirmationCode();
				responseSubmitConfirmationCode.DeserializeMessage(data);
				return responseSubmitConfirmationCode;
			}
			if (num2 == 3136810884u)
			{
				CommunityEventDataRequest communityEventDataRequest = new CommunityEventDataRequest();
				communityEventDataRequest.DeserializeMessage(data);
				return communityEventDataRequest;
			}
			if (num2 == 3151536836u)
			{
				ResponseCreateChatRoom responseCreateChatRoom = new ResponseCreateChatRoom();
				responseCreateChatRoom.DeserializeMessage(data);
				return responseCreateChatRoom;
			}
			if (num2 == 3183014289u)
			{
				RequestSubmitSteamConfirmationCode requestSubmitSteamConfirmationCode = new RequestSubmitSteamConfirmationCode();
				requestSubmitSteamConfirmationCode.DeserializeMessage(data);
				return requestSubmitSteamConfirmationCode;
			}
			if (num2 == 3184606052u)
			{
				RequestAddTutorialProgress requestAddTutorialProgress = new RequestAddTutorialProgress();
				requestAddTutorialProgress.DeserializeMessage(data);
				return requestAddTutorialProgress;
			}
			if (num2 == 3190542750u)
			{
				PushGuildDetailUpdate pushGuildDetailUpdate = new PushGuildDetailUpdate();
				pushGuildDetailUpdate.DeserializeMessage(data);
				return pushGuildDetailUpdate;
			}
			if (num2 == 3222202674u)
			{
				RequestReconcileSteamDLC requestReconcileSteamDLC = new RequestReconcileSteamDLC();
				requestReconcileSteamDLC.DeserializeMessage(data);
				return requestReconcileSteamDLC;
			}
			if (num2 == 3231795318u)
			{
				RequestGuildListFindByName requestGuildListFindByName = new RequestGuildListFindByName();
				requestGuildListFindByName.DeserializeMessage(data);
				return requestGuildListFindByName;
			}
			if (num2 == 3232994734u)
			{
				PushGuildMemberEntryRemoved pushGuildMemberEntryRemoved = new PushGuildMemberEntryRemoved();
				pushGuildMemberEntryRemoved.DeserializeMessage(data);
				return pushGuildMemberEntryRemoved;
			}
			if (num2 == 3235719861u)
			{
				RequestPlayerAddDeck requestPlayerAddDeck = new RequestPlayerAddDeck();
				requestPlayerAddDeck.DeserializeMessage(data);
				return requestPlayerAddDeck;
			}
			if (num2 == 3239703731u)
			{
				ResponseResetTutorial responseResetTutorial = new ResponseResetTutorial();
				responseResetTutorial.DeserializeMessage(data);
				return responseResetTutorial;
			}
			if (num2 == 3239978574u)
			{
				ResponseSetGuildDescription responseSetGuildDescription = new ResponseSetGuildDescription();
				responseSetGuildDescription.DeserializeMessage(data);
				return responseSetGuildDescription;
			}
			if (num2 == 3255014965u)
			{
				ResponseRemoveGuildMember responseRemoveGuildMember = new ResponseRemoveGuildMember();
				responseRemoveGuildMember.DeserializeMessage(data);
				return responseRemoveGuildMember;
			}
			if (num2 == 3272185746u)
			{
				PushPlayerMMR pushPlayerMMR = new PushPlayerMMR();
				pushPlayerMMR.DeserializeMessage(data);
				return pushPlayerMMR;
			}
			if (num2 == 3284622792u)
			{
				ResponseResendSteamConfirmationCode responseResendSteamConfirmationCode = new ResponseResendSteamConfirmationCode();
				responseResendSteamConfirmationCode.DeserializeMessage(data);
				return responseResendSteamConfirmationCode;
			}
			if (num2 == 3294580938u)
			{
				RequestLobbyJoinForParty requestLobbyJoinForParty = new RequestLobbyJoinForParty();
				requestLobbyJoinForParty.DeserializeMessage(data);
				return requestLobbyJoinForParty;
			}
			if (num2 == 3300795992u)
			{
				ClientPingRequest clientPingRequest = new ClientPingRequest();
				clientPingRequest.DeserializeMessage(data);
				return clientPingRequest;
			}
			if (num2 == 3325042036u)
			{
				PushGuildApplicationRejected pushGuildApplicationRejected = new PushGuildApplicationRejected();
				pushGuildApplicationRejected.DeserializeMessage(data);
				return pushGuildApplicationRejected;
			}
			if (num2 == 3369131528u)
			{
				RequestOfflineTutorialCompleted requestOfflineTutorialCompleted = new RequestOfflineTutorialCompleted();
				requestOfflineTutorialCompleted.DeserializeMessage(data);
				return requestOfflineTutorialCompleted;
			}
			if (num2 == 3370528924u)
			{
				PushGuildInviteRemoved pushGuildInviteRemoved = new PushGuildInviteRemoved();
				pushGuildInviteRemoved.DeserializeMessage(data);
				return pushGuildInviteRemoved;
			}
			if (num2 == 3375728112u)
			{
				RequestRemoveGuildMember requestRemoveGuildMember = new RequestRemoveGuildMember();
				requestRemoveGuildMember.DeserializeMessage(data);
				return requestRemoveGuildMember;
			}
			if (num2 == 3375915592u)
			{
				DataLobbyChat dataLobbyChat = new DataLobbyChat();
				dataLobbyChat.DeserializeMessage(data);
				return dataLobbyChat;
			}
			if (num2 == 3379155387u)
			{
				ResponseRejectGuildApplication responseRejectGuildApplication = new ResponseRejectGuildApplication();
				responseRejectGuildApplication.DeserializeMessage(data);
				return responseRejectGuildApplication;
			}
			if (num2 == 3391275122u)
			{
				PushPlayerProgress pushPlayerProgress = new PushPlayerProgress();
				pushPlayerProgress.DeserializeMessage(data);
				return pushPlayerProgress;
			}
			if (num2 == 3397352908u)
			{
				NotifySiegelUnlocked notifySiegelUnlocked = new NotifySiegelUnlocked();
				notifySiegelUnlocked.DeserializeMessage(data);
				return notifySiegelUnlocked;
			}
			if (num2 == 3402400568u)
			{
				ResponseCheckGuildTag responseCheckGuildTag = new ResponseCheckGuildTag();
				responseCheckGuildTag.DeserializeMessage(data);
				return responseCheckGuildTag;
			}
			if (num2 == 3405142812u)
			{
				RecipientResponseInviteToParty recipientResponseInviteToParty = new RecipientResponseInviteToParty();
				recipientResponseInviteToParty.DeserializeMessage(data);
				return recipientResponseInviteToParty;
			}
			if (num2 == 3408313696u)
			{
				RequestUnsubscribeFromLobbyList requestUnsubscribeFromLobbyList = new RequestUnsubscribeFromLobbyList();
				requestUnsubscribeFromLobbyList.DeserializeMessage(data);
				return requestUnsubscribeFromLobbyList;
			}
			if (num2 == 3415497552u)
			{
				RequestServerProtoData requestServerProtoData = new RequestServerProtoData();
				requestServerProtoData.DeserializeMessage(data);
				return requestServerProtoData;
			}
			if (num2 == 3426490374u)
			{
				RecipientRequestInviteToParty recipientRequestInviteToParty = new RecipientRequestInviteToParty();
				recipientRequestInviteToParty.DeserializeMessage(data);
				return recipientRequestInviteToParty;
			}
			if (num2 == 3442345621u)
			{
				ResponseServerAckInviteToParty responseServerAckInviteToParty = new ResponseServerAckInviteToParty();
				responseServerAckInviteToParty.DeserializeMessage(data);
				return responseServerAckInviteToParty;
			}
			if (num2 == 3451241323u)
			{
				RequestLobbyKickPlayer requestLobbyKickPlayer = new RequestLobbyKickPlayer();
				requestLobbyKickPlayer.DeserializeMessage(data);
				return requestLobbyKickPlayer;
			}
			if (num2 == 3452175722u)
			{
				NewLeaderSelected newLeaderSelected = new NewLeaderSelected();
				newLeaderSelected.DeserializeMessage(data);
				return newLeaderSelected;
			}
			if (num2 == 3461673725u)
			{
				ResponseDisbandGuild responseDisbandGuild = new ResponseDisbandGuild();
				responseDisbandGuild.DeserializeMessage(data);
				return responseDisbandGuild;
			}
			if (num2 == 3468121880u)
			{
				PushLobbyListUpdate pushLobbyListUpdate = new PushLobbyListUpdate();
				pushLobbyListUpdate.DeserializeMessage(data);
				return pushLobbyListUpdate;
			}
			if (num2 == 3477421501u)
			{
				RequestJoinDiscordChannel requestJoinDiscordChannel = new RequestJoinDiscordChannel();
				requestJoinDiscordChannel.DeserializeMessage(data);
				return requestJoinDiscordChannel;
			}
			if (num2 == 3477894252u)
			{
				RequestKickPlayerFromParty requestKickPlayerFromParty = new RequestKickPlayerFromParty();
				requestKickPlayerFromParty.DeserializeMessage(data);
				return requestKickPlayerFromParty;
			}
			if (num2 == 3499442594u)
			{
				ResponseSabotageGuildInfo responseSabotageGuildInfo = new ResponseSabotageGuildInfo();
				responseSabotageGuildInfo.DeserializeMessage(data);
				return responseSabotageGuildInfo;
			}
			if (num2 == 3510015090u)
			{
				PushAnimaticDefinitions pushAnimaticDefinitions = new PushAnimaticDefinitions();
				pushAnimaticDefinitions.DeserializeMessage(data);
				return pushAnimaticDefinitions;
			}
			if (num2 == 3554474019u)
			{
				ResponseLevelCurve responseLevelCurve = new ResponseLevelCurve();
				responseLevelCurve.DeserializeMessage(data);
				return responseLevelCurve;
			}
			if (num2 == 3559327802u)
			{
				StartMatchmakingSolo startMatchmakingSolo = new StartMatchmakingSolo();
				startMatchmakingSolo.DeserializeMessage(data);
				return startMatchmakingSolo;
			}
			if (num2 == 3563342773u)
			{
				RequestCheckGuildName requestCheckGuildName = new RequestCheckGuildName();
				requestCheckGuildName.DeserializeMessage(data);
				return requestCheckGuildName;
			}
			if (num2 == 3623514798u)
			{
				PushMatchmakingGameFoundComplete pushMatchmakingGameFoundComplete = new PushMatchmakingGameFoundComplete();
				pushMatchmakingGameFoundComplete.DeserializeMessage(data);
				return pushMatchmakingGameFoundComplete;
			}
			if (num2 == 3639577521u)
			{
				ResponseGetGuildDetail responseGetGuildDetail = new ResponseGetGuildDetail();
				responseGetGuildDetail.DeserializeMessage(data);
				return responseGetGuildDetail;
			}
			if (num2 == 3648286461u)
			{
				ResponseRegisterEUPlayer responseRegisterEUPlayer = new ResponseRegisterEUPlayer();
				responseRegisterEUPlayer.DeserializeMessage(data);
				return responseRegisterEUPlayer;
			}
			if (num2 == 3684913767u)
			{
				RequestSabotageGuildInfo requestSabotageGuildInfo = new RequestSabotageGuildInfo();
				requestSabotageGuildInfo.DeserializeMessage(data);
				return requestSabotageGuildInfo;
			}
			if (num2 == 3715818711u)
			{
				RequestApplyLeaverPenalty requestApplyLeaverPenalty = new RequestApplyLeaverPenalty();
				requestApplyLeaverPenalty.DeserializeMessage(data);
				return requestApplyLeaverPenalty;
			}
			if (num2 == 3720101895u)
			{
				RequestKeystoneReroll requestKeystoneReroll = new RequestKeystoneReroll();
				requestKeystoneReroll.DeserializeMessage(data);
				return requestKeystoneReroll;
			}
			if (num2 == 3731792054u)
			{
				RequestApplyToGuild requestApplyToGuild = new RequestApplyToGuild();
				requestApplyToGuild.DeserializeMessage(data);
				return requestApplyToGuild;
			}
			if (num2 == 3736326188u)
			{
				PushGuildApplicationCancelled pushGuildApplicationCancelled = new PushGuildApplicationCancelled();
				pushGuildApplicationCancelled.DeserializeMessage(data);
				return pushGuildApplicationCancelled;
			}
			if (num2 == 3744745478u)
			{
				ResponseOfflineTutorialStatus responseOfflineTutorialStatus = new ResponseOfflineTutorialStatus();
				responseOfflineTutorialStatus.DeserializeMessage(data);
				return responseOfflineTutorialStatus;
			}
			if (num2 == 3746523256u)
			{
				RequestCreateWhisperChatRoom requestCreateWhisperChatRoom = new RequestCreateWhisperChatRoom();
				requestCreateWhisperChatRoom.DeserializeMessage(data);
				return requestCreateWhisperChatRoom;
			}
			if (num2 == 3749518121u)
			{
				RequestPushPlayerRotatingStore requestPushPlayerRotatingStore = new RequestPushPlayerRotatingStore();
				requestPushPlayerRotatingStore.DeserializeMessage(data);
				return requestPushPlayerRotatingStore;
			}
			if (num2 == 3759057617u)
			{
				RequestLobbyDetail requestLobbyDetail = new RequestLobbyDetail();
				requestLobbyDetail.DeserializeMessage(data);
				return requestLobbyDetail;
			}
			if (num2 == 3763689372u)
			{
				RequestLeaveGuild requestLeaveGuild = new RequestLeaveGuild();
				requestLeaveGuild.DeserializeMessage(data);
				return requestLeaveGuild;
			}
			if (num2 == 3789460582u)
			{
				ResponsePreviousChallengeLeaderboardInfo responsePreviousChallengeLeaderboardInfo = new ResponsePreviousChallengeLeaderboardInfo();
				responsePreviousChallengeLeaderboardInfo.DeserializeMessage(data);
				return responsePreviousChallengeLeaderboardInfo;
			}
			if (num2 == 3796957890u)
			{
				RequestStoreTransaction requestStoreTransaction = new RequestStoreTransaction();
				requestStoreTransaction.DeserializeMessage(data);
				return requestStoreTransaction;
			}
			if (num2 == 3801716005u)
			{
				RequestClientHandshake requestClientHandshake = new RequestClientHandshake();
				requestClientHandshake.DeserializeMessage(data);
				return requestClientHandshake;
			}
			if (num2 == 3827495177u)
			{
				UserLoginResponse userLoginResponse = new UserLoginResponse();
				userLoginResponse.DeserializeMessage(data);
				return userLoginResponse;
			}
			if (num2 == 3828043089u)
			{
				RequestUpgradeTrap requestUpgradeTrap = new RequestUpgradeTrap();
				requestUpgradeTrap.DeserializeMessage(data);
				return requestUpgradeTrap;
			}
			if (num2 == 3832506386u)
			{
				JoinChatRoomPush joinChatRoomPush = new JoinChatRoomPush();
				joinChatRoomPush.DeserializeMessage(data);
				return joinChatRoomPush;
			}
			if (num2 == 3837663253u)
			{
				ResponseSetGuildMOTD responseSetGuildMOTD = new ResponseSetGuildMOTD();
				responseSetGuildMOTD.DeserializeMessage(data);
				return responseSetGuildMOTD;
			}
			if (num2 == 3844760708u)
			{
				RequestGuildListFindByTag requestGuildListFindByTag = new RequestGuildListFindByTag();
				requestGuildListFindByTag.DeserializeMessage(data);
				return requestGuildListFindByTag;
			}
			if (num2 == 3851876137u)
			{
				PushMatchmakingGameFound pushMatchmakingGameFound = new PushMatchmakingGameFound();
				pushMatchmakingGameFound.DeserializeMessage(data);
				return pushMatchmakingGameFound;
			}
			if (num2 == 3861597650u)
			{
				RequestPlayerChangePortraitIndex requestPlayerChangePortraitIndex = new RequestPlayerChangePortraitIndex();
				requestPlayerChangePortraitIndex.DeserializeMessage(data);
				return requestPlayerChangePortraitIndex;
			}
			if (num2 == 3872412131u)
			{
				PushPlayerAccount pushPlayerAccount = new PushPlayerAccount();
				pushPlayerAccount.DeserializeMessage(data);
				return pushPlayerAccount;
			}
			if (num2 == 3899484410u)
			{
				DataLobbyList dataLobbyList = new DataLobbyList();
				dataLobbyList.DeserializeMessage(data);
				return dataLobbyList;
			}
			if (num2 == 3909660318u)
			{
				RequestCancelGuildApplication requestCancelGuildApplication = new RequestCancelGuildApplication();
				requestCancelGuildApplication.DeserializeMessage(data);
				return requestCancelGuildApplication;
			}
			if (num2 == 3910894782u)
			{
				RequestOfflineTutorialStarted requestOfflineTutorialStarted = new RequestOfflineTutorialStarted();
				requestOfflineTutorialStarted.DeserializeMessage(data);
				return requestOfflineTutorialStarted;
			}
			if (num2 == 3921608283u)
			{
				RequestGetApplicationsForGuild requestGetApplicationsForGuild = new RequestGetApplicationsForGuild();
				requestGetApplicationsForGuild.DeserializeMessage(data);
				return requestGetApplicationsForGuild;
			}
			if (num2 == 3934755070u)
			{
				FriendRemoved friendRemoved = new FriendRemoved();
				friendRemoved.DeserializeMessage(data);
				return friendRemoved;
			}
			if (num2 == 3951830498u)
			{
				ResponseSabotagePlayerInfo responseSabotagePlayerInfo = new ResponseSabotagePlayerInfo();
				responseSabotagePlayerInfo.DeserializeMessage(data);
				return responseSabotagePlayerInfo;
			}
			if (num2 == 3974413295u)
			{
				ResponseGetFriends responseGetFriends = new ResponseGetFriends();
				responseGetFriends.DeserializeMessage(data);
				return responseGetFriends;
			}
			if (num2 == 3976803159u)
			{
				PushMatchmakingGameFoundPlayerReady pushMatchmakingGameFoundPlayerReady = new PushMatchmakingGameFoundPlayerReady();
				pushMatchmakingGameFoundPlayerReady.DeserializeMessage(data);
				return pushMatchmakingGameFoundPlayerReady;
			}
			if (num2 == 4001055609u)
			{
				PushMessageDeleted pushMessageDeleted = new PushMessageDeleted();
				pushMessageDeleted.DeserializeMessage(data);
				return pushMessageDeleted;
			}
			if (num2 == 4005028566u)
			{
				RequestLobbySetDetails requestLobbySetDetails = new RequestLobbySetDetails();
				requestLobbySetDetails.DeserializeMessage(data);
				return requestLobbySetDetails;
			}
			if (num2 == 4012652900u)
			{
				RequestCheckForAbsenteeLeader requestCheckForAbsenteeLeader = new RequestCheckForAbsenteeLeader();
				requestCheckForAbsenteeLeader.DeserializeMessage(data);
				return requestCheckForAbsenteeLeader;
			}
			if (num2 == 4027114090u)
			{
				ResponseUpdateNameplate responseUpdateNameplate = new ResponseUpdateNameplate();
				responseUpdateNameplate.DeserializeMessage(data);
				return responseUpdateNameplate;
			}
			if (num2 == 4030005612u)
			{
				ResponseChatFilterOptionChange responseChatFilterOptionChange = new ResponseChatFilterOptionChange();
				responseChatFilterOptionChange.DeserializeMessage(data);
				return responseChatFilterOptionChange;
			}
			if (num2 == 4045256113u)
			{
				RequestInitiateSteamTransaction requestInitiateSteamTransaction = new RequestInitiateSteamTransaction();
				requestInitiateSteamTransaction.DeserializeMessage(data);
				return requestInitiateSteamTransaction;
			}
			if (num2 == 4054112466u)
			{
				ResponseStreamerAPIStateChange responseStreamerAPIStateChange = new ResponseStreamerAPIStateChange();
				responseStreamerAPIStateChange.DeserializeMessage(data);
				return responseStreamerAPIStateChange;
			}
			if (num2 == 4056958469u)
			{
				PushGuildMOTD pushGuildMOTD = new PushGuildMOTD();
				pushGuildMOTD.DeserializeMessage(data);
				return pushGuildMOTD;
			}
			if (num2 == 4068564391u)
			{
				RequestLobbyLeave requestLobbyLeave = new RequestLobbyLeave();
				requestLobbyLeave.DeserializeMessage(data);
				return requestLobbyLeave;
			}
			if (num2 == 4072129988u)
			{
				RequestSendLobbyChat requestSendLobbyChat = new RequestSendLobbyChat();
				requestSendLobbyChat.DeserializeMessage(data);
				return requestSendLobbyChat;
			}
			if (num2 == 4077581278u)
			{
				PushGuildInviteAdded pushGuildInviteAdded = new PushGuildInviteAdded();
				pushGuildInviteAdded.DeserializeMessage(data);
				return pushGuildInviteAdded;
			}
			if (num2 == 4079833005u)
			{
				RequestSetGuildDescription requestSetGuildDescription = new RequestSetGuildDescription();
				requestSetGuildDescription.DeserializeMessage(data);
				return requestSetGuildDescription;
			}
			if (num2 == 4086459309u)
			{
				PushDiscordRpcToken pushDiscordRpcToken = new PushDiscordRpcToken();
				pushDiscordRpcToken.DeserializeMessage(data);
				return pushDiscordRpcToken;
			}
			if (num2 == 4091036120u)
			{
				PushPlayerChallengeProgress pushPlayerChallengeProgress = new PushPlayerChallengeProgress();
				pushPlayerChallengeProgress.DeserializeMessage(data);
				return pushPlayerChallengeProgress;
			}
			if (num2 == 4101520268u)
			{
				RequestLobbySelectDeck requestLobbySelectDeck = new RequestLobbySelectDeck();
				requestLobbySelectDeck.DeserializeMessage(data);
				return requestLobbySelectDeck;
			}
			if (num2 == 4104066817u)
			{
				RequestAssignGuildLeader requestAssignGuildLeader = new RequestAssignGuildLeader();
				requestAssignGuildLeader.DeserializeMessage(data);
				return requestAssignGuildLeader;
			}
			if (num2 == 4112255981u)
			{
				ServerAckPromoteNewLeader serverAckPromoteNewLeader = new ServerAckPromoteNewLeader();
				serverAckPromoteNewLeader.DeserializeMessage(data);
				return serverAckPromoteNewLeader;
			}
			if (num2 == 4116074322u)
			{
				AdminWebCommunityEventsUpdatedPush adminWebCommunityEventsUpdatedPush = new AdminWebCommunityEventsUpdatedPush();
				adminWebCommunityEventsUpdatedPush.DeserializeMessage(data);
				return adminWebCommunityEventsUpdatedPush;
			}
			if (num2 == 4116325538u)
			{
				RequestCreateLobbyKeystone requestCreateLobbyKeystone = new RequestCreateLobbyKeystone();
				requestCreateLobbyKeystone.DeserializeMessage(data);
				return requestCreateLobbyKeystone;
			}
			if (num2 == 4120177164u)
			{
				AuthLoginUserRequest authLoginUserRequest = new AuthLoginUserRequest();
				authLoginUserRequest.DeserializeMessage(data);
				return authLoginUserRequest;
			}
			if (num2 == 4123902956u)
			{
				RequestDeleteFriend requestDeleteFriend = new RequestDeleteFriend();
				requestDeleteFriend.DeserializeMessage(data);
				return requestDeleteFriend;
			}
			if (num2 == 4131534742u)
			{
				ResponseLeaveGuild responseLeaveGuild = new ResponseLeaveGuild();
				responseLeaveGuild.DeserializeMessage(data);
				return responseLeaveGuild;
			}
			if (num2 == 4156966080u)
			{
				ResponseSubmitSteamConfirmationCode responseSubmitSteamConfirmationCode = new ResponseSubmitSteamConfirmationCode();
				responseSubmitSteamConfirmationCode.DeserializeMessage(data);
				return responseSubmitSteamConfirmationCode;
			}
			if (num2 == 4163934884u)
			{
				RequestGetGuildDetailByTag requestGetGuildDetailByTag = new RequestGetGuildDetailByTag();
				requestGetGuildDetailByTag.DeserializeMessage(data);
				return requestGetGuildDetailByTag;
			}
			if (num2 == 4171037411u)
			{
				ResponseValidatePassword responseValidatePassword = new ResponseValidatePassword();
				responseValidatePassword.DeserializeMessage(data);
				return responseValidatePassword;
			}
			if (num2 == 4172070350u)
			{
				ResponseKeystoneLeaderboardInfo responseKeystoneLeaderboardInfo = new ResponseKeystoneLeaderboardInfo();
				responseKeystoneLeaderboardInfo.DeserializeMessage(data);
				return responseKeystoneLeaderboardInfo;
			}
			if (num2 == 4177834193u)
			{
				ServerAckLeaveParty serverAckLeaveParty = new ServerAckLeaveParty();
				serverAckLeaveParty.DeserializeMessage(data);
				return serverAckLeaveParty;
			}
			if (num2 == 4193931842u)
			{
				ResponsePartyStatus responsePartyStatus = new ResponsePartyStatus();
				responsePartyStatus.DeserializeMessage(data);
				return responsePartyStatus;
			}
			if (num2 == 4210285541u)
			{
				RequestGetFriends requestGetFriends = new RequestGetFriends();
				requestGetFriends.DeserializeMessage(data);
				return requestGetFriends;
			}
			if (num2 == 4238955084u)
			{
				RequestFinalizeSteamTransaction requestFinalizeSteamTransaction = new RequestFinalizeSteamTransaction();
				requestFinalizeSteamTransaction.DeserializeMessage(data);
				return requestFinalizeSteamTransaction;
			}
			if (num2 == 4252966287u)
			{
				ResponseKickPlayerFromParty responseKickPlayerFromParty = new ResponseKickPlayerFromParty();
				responseKickPlayerFromParty.DeserializeMessage(data);
				return responseKickPlayerFromParty;
			}
			if (num2 == 4274991488u)
			{
				PushPlayerKickedFromParty pushPlayerKickedFromParty = new PushPlayerKickedFromParty();
				pushPlayerKickedFromParty.DeserializeMessage(data);
				return pushPlayerKickedFromParty;
			}
			if (num2 == 4289266884u)
			{
				ResponseAssignGuildLeader responseAssignGuildLeader = new ResponseAssignGuildLeader();
				responseAssignGuildLeader.DeserializeMessage(data);
				return responseAssignGuildLeader;
			}
			if (num2 == 8969000u)
			{
				PushTutorialProgress pushTutorialProgress = new PushTutorialProgress();
				pushTutorialProgress.DeserializeMessage(data);
				return pushTutorialProgress;
			}
			if (num2 == 8988110u)
			{
				RequestSabotagePlayerInfo requestSabotagePlayerInfo = new RequestSabotagePlayerInfo();
				requestSabotagePlayerInfo.DeserializeMessage(data);
				return requestSabotagePlayerInfo;
			}
			if (num2 == 20082191u)
			{
				ResponseGetOutgoingGuildApplications responseGetOutgoingGuildApplications = new ResponseGetOutgoingGuildApplications();
				responseGetOutgoingGuildApplications.DeserializeMessage(data);
				return responseGetOutgoingGuildApplications;
			}
			if (num2 == 28873780u)
			{
				RequestBotList requestBotList = new RequestBotList();
				requestBotList.DeserializeMessage(data);
				return requestBotList;
			}
			if (num2 == 39407926u)
			{
				ResponseCheckGuildName responseCheckGuildName = new ResponseCheckGuildName();
				responseCheckGuildName.DeserializeMessage(data);
				return responseCheckGuildName;
			}
			if (num2 == 44440897u)
			{
				ResponseRejectGuildInvite responseRejectGuildInvite = new ResponseRejectGuildInvite();
				responseRejectGuildInvite.DeserializeMessage(data);
				return responseRejectGuildInvite;
			}
			if (num2 == 47558132u)
			{
				UserLoginRequest userLoginRequest = new UserLoginRequest();
				userLoginRequest.DeserializeMessage(data);
				return userLoginRequest;
			}
			if (num2 == 82359087u)
			{
				ResponseUpgradeTrap responseUpgradeTrap = new ResponseUpgradeTrap();
				responseUpgradeTrap.DeserializeMessage(data);
				return responseUpgradeTrap;
			}
			if (num2 != 84025690u)
			{
				return null;
			}
			PushFriendUpdate pushFriendUpdate = new PushFriendUpdate();
			pushFriendUpdate.DeserializeMessage(data);
			return pushFriendUpdate;
		}
	}
}
