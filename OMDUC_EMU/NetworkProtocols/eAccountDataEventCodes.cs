using System;

namespace NetworkProtocols
{
	// Token: 0x020004C0 RID: 1216
	public enum eAccountDataEventCodes
	{
		// Token: 0x04001842 RID: 6210
		AccountDataEventCodes_None,
		// Token: 0x04001843 RID: 6211
		Success_DeckDetailPosted,
		// Token: 0x04001844 RID: 6212
		Success_DeckMetaChanged,
		// Token: 0x04001845 RID: 6213
		Success_DeckDeleted,
		// Token: 0x04001846 RID: 6214
		Success_DeckAdded,
		// Token: 0x04001847 RID: 6215
		Success_ChatFilterOptionChanged,
		// Token: 0x04001848 RID: 6216
		Success_OfflineTutorialProcessed,
		// Token: 0x04001849 RID: 6217
		Failure_Account_NoSuchAccount = 100,
		// Token: 0x0400184A RID: 6218
		Failure_Inventory_NoSuchAccount,
		// Token: 0x0400184B RID: 6219
		Failure_Stats_NoSuchAccount,
		// Token: 0x0400184C RID: 6220
		Failure_RequestPlayerDecks_NoSuchAccount,
		// Token: 0x0400184D RID: 6221
		Failure_RequestPlayerDeckDetail_NoSuchAccount,
		// Token: 0x0400184E RID: 6222
		Failure_RequestPlayerDeckDetail_NoSuchDeck,
		// Token: 0x0400184F RID: 6223
		Failure_RequestPlayerAddDeck_NoSuchAccount,
		// Token: 0x04001850 RID: 6224
		Failure_RequestPlayerAddDeck_CouldNotSaveAccount,
		// Token: 0x04001851 RID: 6225
		Failure_RequestPlayerDeleteDeck_NoSuchAccount,
		// Token: 0x04001852 RID: 6226
		Failure_RequestPlayerDeleteDeck_NoSuchDeck,
		// Token: 0x04001853 RID: 6227
		Failure_RequestPlayerDeleteDeck_CouldNotSaveAccount,
		// Token: 0x04001854 RID: 6228
		Failure_RequestPlayerChangeDeckMeta_NoSuchAccount,
		// Token: 0x04001855 RID: 6229
		Failure_RequestPlayerChangeDeckMeta_NoSuchDeck,
		// Token: 0x04001856 RID: 6230
		Failure_RequestPlayerChangeDeckMeta_CouldNotSaveAccount,
		// Token: 0x04001857 RID: 6231
		Failure_RequestPlayerDeleteDeck_DeckLocked = 118,
		// Token: 0x04001858 RID: 6232
		Failure_RequestPlayerChangeDeckMeta_DeckLocked = 120,
		// Token: 0x04001859 RID: 6233
		Failure_RequestPlayerOpenPack_DoNotOwnPack,
		// Token: 0x0400185A RID: 6234
		Failure_RequestPlayerOpenPack_CouldNotSaveAccount,
		// Token: 0x0400185B RID: 6235
		Failure_RequestPlayerOpenPack_PackError,
		// Token: 0x0400185C RID: 6236
		Failure_RequestPlayerPurchasePack_NoSuchAccount,
		// Token: 0x0400185D RID: 6237
		Failure_RequestPlayerPurchasePack_NoSuchPack,
		// Token: 0x0400185E RID: 6238
		Failure_RequestPlayerPurchasePack_WrongCost,
		// Token: 0x0400185F RID: 6239
		Failure_RequestPlayerPurchasePack_NotEnoughInGameCoins,
		// Token: 0x04001860 RID: 6240
		Failure_RequestPlayerPurchasePack_CouldNotSaveAccount,
		// Token: 0x04001861 RID: 6241
		Failure_RequestPlayerPreGameData,
		// Token: 0x04001862 RID: 6242
		Failure_RequestPlayerOpenPack_NoSuchAccount,
		// Token: 0x04001863 RID: 6243
		Failure_ChangePortaitIndex_NoSuchAccount,
		// Token: 0x04001864 RID: 6244
		Failure_RequestPlayerAddDeck_InvalidPlayer,
		// Token: 0x04001865 RID: 6245
		Failure_RequestPlayerAddDeck_MaxDeckLimit,
		// Token: 0x04001866 RID: 6246
		Failure_RequestPlayerAddDeck_InvalidDeckProto = 141,
		// Token: 0x04001867 RID: 6247
		Failure_RequestPlayerAddDeck_InvalidCharactersInName,
		// Token: 0x04001868 RID: 6248
		Failure_RequestPlayerAddDeck_DeckNameAlreadyExists,
		// Token: 0x04001869 RID: 6249
		Failure_RequestPlayerAddDeck_UICDeckNameInvalid,
		// Token: 0x0400186A RID: 6250
		Failure_ProcessOfflineTutorial_NoSession = 146,
		// Token: 0x0400186B RID: 6251
		Failure_ProcessOfflineTutorial_NoAccount,
		// Token: 0x0400186C RID: 6252
		Failure_ProcessOfflineTutorial_AlreadyCompleted,
		// Token: 0x0400186D RID: 6253
		Failure_ProcessOfflineTutorial_NoTutorialRewardsFound,
		// Token: 0x0400186E RID: 6254
		Failure_RequestPlayerDeleteDeck_CannotDeleteLastDeckOfType = 151,
		// Token: 0x0400186F RID: 6255
		Failure_RequestPlayerAddDeck_NoPlayerDeckDataFound = 153
	}
}
