using System;

namespace NetworkProtocols
{
	// Token: 0x020006D1 RID: 1745
	public enum eMatchmakingState
	{
		// Token: 0x040020CC RID: 8396
		MatchmakingState_None,
		// Token: 0x040020CD RID: 8397
		MatchmakingState_Searching,
		// Token: 0x040020CE RID: 8398
		MatchmakingState_CreatingLobby,
		// Token: 0x040020CF RID: 8399
		MatchmakingState_Success = 10,
		// Token: 0x040020D0 RID: 8400
		MatchmakingState_Failed_Unknown = 20,
		// Token: 0x040020D1 RID: 8401
		MatchmakingState_Failed_PlayerLeft,
		// Token: 0x040020D2 RID: 8402
		MatchmakingState_Failed_PlayerCanceled,
		// Token: 0x040020D3 RID: 8403
		MatchmakingState_Failed_PlayerAlreadyMatchmaking,
		// Token: 0x040020D4 RID: 8404
		MatchmakingState_Failed_UnknownUser,
		// Token: 0x040020D5 RID: 8405
		MatchmakingState_Failed_LobbyTimeout,
		// Token: 0x040020D6 RID: 8406
		MatchmakingState_Failed_PlayerLeaverPenalty,
		// Token: 0x040020D7 RID: 8407
		MatchmakingState_Failed_TooManyMembersInParty,
		// Token: 0x040020D8 RID: 8408
		MatchmakingState_Failed_PartyInvitesPending
	}
}
