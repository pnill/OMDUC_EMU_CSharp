using System;

namespace NetworkProtocols
{
	// Token: 0x0200049B RID: 1179
	public enum eLobbyRequestResult
	{
		// Token: 0x04001729 RID: 5929
		LobbyRequest_Succeeded,
		// Token: 0x0400172A RID: 5930
		LobbyRequest_Failed = 10,
		// Token: 0x0400172B RID: 5931
		LobbyRequest_Failed_Unimplemented,
		// Token: 0x0400172C RID: 5932
		LobbyRequest_Failed_NoCreate,
		// Token: 0x0400172D RID: 5933
		LobbyRequest_Failed_UnsupportedType,
		// Token: 0x0400172E RID: 5934
		LobbyRequest_Failed_LobbyDNE,
		// Token: 0x0400172F RID: 5935
		LobbyRequest_Failed_PlayerDNE,
		// Token: 0x04001730 RID: 5936
		LobbyRequest_Failed_LobbyFull,
		// Token: 0x04001731 RID: 5937
		LobbyRequest_Failed_TeamFull,
		// Token: 0x04001732 RID: 5938
		LobbyRequest_Failed_AlreadyInLobby,
		// Token: 0x04001733 RID: 5939
		LobbyRequest_Failed_InvalidState,
		// Token: 0x04001734 RID: 5940
		LobbyRequest_Failed_UnknownUser,
		// Token: 0x04001735 RID: 5941
		LobbyRequest_Failed_DeckDNE,
		// Token: 0x04001736 RID: 5942
		LobbyRequest_Failed_DoNotOwnCharacter,
		// Token: 0x04001737 RID: 5943
		LobbyRequest_Failed_InvalidTeam,
		// Token: 0x04001738 RID: 5944
		LobbyRequest_Failed_LockedReady,
		// Token: 0x04001739 RID: 5945
		LobbyRequest_Failed_NoLobbyName,
		// Token: 0x0400173A RID: 5946
		LobbyRequest_Failed_NotAllPlayersOnTeam,
		// Token: 0x0400173B RID: 5947
		LobbyRequest_Failed_NotEnoughCharacters,
		// Token: 0x0400173C RID: 5948
		LobbyRequest_Failed_NotOnTeam,
		// Token: 0x0400173D RID: 5949
		LobbyRequest_Failed_NotOwner,
		// Token: 0x0400173E RID: 5950
		LobbyRequest_Failed_NoValidDecks,
		// Token: 0x0400173F RID: 5951
		LobbyRequest_Failed_CharacterTaken,
		// Token: 0x04001740 RID: 5952
		LobbyRequest_Failed_NotEveryoneReady,
		// Token: 0x04001741 RID: 5953
		LobbyRequest_Failed_TimedOut,
		// Token: 0x04001742 RID: 5954
		LobbyRequest_Failed_InvalidBot,
		// Token: 0x04001743 RID: 5955
		LobbyRequest_Failed_MapDNE,
		// Token: 0x04001744 RID: 5956
		LobbyRequest_Failed_UnselectedDeck,
		// Token: 0x04001745 RID: 5957
		LobbyRequest_Failed_InvalidType,
		// Token: 0x04001746 RID: 5958
		LobbyRequest_Failed_NoCharacterSelected,
		// Token: 0x04001747 RID: 5959
		LobbyRequest_Failed_Matchmaking,
		// Token: 0x04001748 RID: 5960
		LobbyRequest_Failed_InvalidSkinGUID,
		// Token: 0x04001749 RID: 5961
		LobbyRequest_Failed_LobbyNameInvalid,
		// Token: 0x0400174A RID: 5962
		LobbyRequest_Failed_TencentUICReject,
		// Token: 0x0400174B RID: 5963
		LobbyRequest_Failed_DeckInvalidGameType,
		// Token: 0x0400174C RID: 5964
		LobbyRequest_Failed_LobbyNameCheckFailedUIC,
		// Token: 0x0400174D RID: 5965
		LobbyRequest_Failed_NoValidKeystone,
		// Token: 0x0400174E RID: 5966
		LobbyRequest_Succeeded_LobbyClosed,
		// Token: 0x0400174F RID: 5967
		LobbyRequest_Failed_TooManyMembersInParty,
		// Token: 0x04001750 RID: 5968
		LobbyRequest_Failed_BannedCardFound,
		// Token: 0x04001751 RID: 5969
		LobbyRequest_Failed_NoSuchAccount,
		// Token: 0x04001752 RID: 5970
		LobbyRequest_Failed_NoSuchDeck,
		// Token: 0x04001753 RID: 5971
		LobbyRequest_Failed_DeckLocked,
		// Token: 0x04001754 RID: 5972
		LobbyRequest_Failed_TooManyCardsOfType,
		// Token: 0x04001755 RID: 5973
		LobbyRequest_Failed_CouldNotSaveAccount,
		// Token: 0x04001756 RID: 5974
		LobbyRequest_Failed_SkinNotOwned,
		// Token: 0x04001757 RID: 5975
		LobbyRequest_Failed_DyeNotOwned,
		// Token: 0x04001758 RID: 5976
		LobbyRequest_Failed_IncorrectPassword,
		// Token: 0x04001759 RID: 5977
		LobbyRequest_Failed_PrivateLobby,
		// Token: 0x0400175A RID: 5978
		LobbyRequest_Failed_PlayerOffline,
		// Token: 0x0400175B RID: 5979
		LobbyRequest_Failed_NotInLobby,
		// Token: 0x0400175C RID: 5980
		LobbyRequest_Failed_PlayerInvalidState,
		// Token: 0x0400175D RID: 5981
		LobbyRequest_Failed_InvitePending,
		// Token: 0x0400175E RID: 5982
		LobbyRequest_Failed_InviteDNE
	}
}
