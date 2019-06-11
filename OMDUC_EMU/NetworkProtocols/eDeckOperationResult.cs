using System;

namespace NetworkProtocols
{
	// Token: 0x020004C1 RID: 1217
	public enum eDeckOperationResult
	{
		// Token: 0x04001871 RID: 6257
		None,
		// Token: 0x04001872 RID: 6258
		Success_DeckDetailPosted,
		// Token: 0x04001873 RID: 6259
		Success_DeckMetaChanged,
		// Token: 0x04001874 RID: 6260
		Success_DeckDeleted,
		// Token: 0x04001875 RID: 6261
		Success_DeckAdded,
		// Token: 0x04001876 RID: 6262
		Failure_NoSuchAccount,
		// Token: 0x04001877 RID: 6263
		Failure_NoSuchDeck,
		// Token: 0x04001878 RID: 6264
		Failure_CouldNotSaveAccount,
		// Token: 0x04001879 RID: 6265
		Failure_BannedCardFound,
		// Token: 0x0400187A RID: 6266
		Failure_DeckLocked,
		// Token: 0x0400187B RID: 6267
		Failure_ItemDNE,
		// Token: 0x0400187C RID: 6268
		Failure_TooManyCardsOfType,
		// Token: 0x0400187D RID: 6269
		Failure_CardNotOwned,
		// Token: 0x0400187E RID: 6270
		Failure_TooManyGearCards,
		// Token: 0x0400187F RID: 6271
		Failure_TooManyTrapCards,
		// Token: 0x04001880 RID: 6272
		Failure_TooManyBossCards,
		// Token: 0x04001881 RID: 6273
		Failure_TooManyMinionCards,
		// Token: 0x04001882 RID: 6274
		Failure_InvalidDeckProto,
		// Token: 0x04001883 RID: 6275
		Failure_InvalidCharactersInName,
		// Token: 0x04001884 RID: 6276
		Failure_DeckNameAlreadyExists,
		// Token: 0x04001885 RID: 6277
		Failure_UICDeckNameInvalid,
		// Token: 0x04001886 RID: 6278
		Failure_TooManyTraitCards,
		// Token: 0x04001887 RID: 6279
		Failure_TooManyGuardianCards,
		// Token: 0x04001888 RID: 6280
		Failure_TooManyConsumableCards,
		// Token: 0x04001889 RID: 6281
		Failed_LobbyDNE
	}
}
