using System;

namespace NetworkProtocols
{
	// Token: 0x020006E4 RID: 1764
	public enum ePartyOperationStatus
	{
		// Token: 0x0400211A RID: 8474
		Failure,
		// Token: 0x0400211B RID: 8475
		Success,
		// Token: 0x0400211C RID: 8476
		RecipientUnavailable,
		// Token: 0x0400211D RID: 8477
		RecipientIneligible,
		// Token: 0x0400211E RID: 8478
		RecipientOffline,
		// Token: 0x0400211F RID: 8479
		LeaderUnavailable,
		// Token: 0x04002120 RID: 8480
		LeaderIneligible,
		// Token: 0x04002121 RID: 8481
		RecipientAlreadyInvited,
		// Token: 0x04002122 RID: 8482
		RecipientAlreadyInParty,
		// Token: 0x04002123 RID: 8483
		PartyIsFull,
		// Token: 0x04002124 RID: 8484
		PartyNotFound,
		// Token: 0x04002125 RID: 8485
		PlayerNotFound,
		// Token: 0x04002126 RID: 8486
		PartyMemberInLobby,
		// Token: 0x04002127 RID: 8487
		PartyInGame,
		// Token: 0x04002128 RID: 8488
		PlayerNotInvited,
		// Token: 0x04002129 RID: 8489
		TooManyMembersInParty,
		// Token: 0x0400212A RID: 8490
		InvitesPending
	}
}
