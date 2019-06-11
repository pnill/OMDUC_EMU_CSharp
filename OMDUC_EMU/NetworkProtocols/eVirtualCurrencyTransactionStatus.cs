using System;

namespace NetworkProtocols
{
	// Token: 0x020004C7 RID: 1223
	public enum eVirtualCurrencyTransactionStatus
	{
		// Token: 0x04001955 RID: 6485
		Success,
		// Token: 0x04001956 RID: 6486
		AccountUnknown,
		// Token: 0x04001957 RID: 6487
		OfferInvalid,
		// Token: 0x04001958 RID: 6488
		OfferNotYetStarted,
		// Token: 0x04001959 RID: 6489
		OfferHasEnded,
		// Token: 0x0400195A RID: 6490
		OfferQuantityExceeded,
		// Token: 0x0400195B RID: 6491
		OfferPriceMismatch,
		// Token: 0x0400195C RID: 6492
		NotEnoughGold,
		// Token: 0x0400195D RID: 6493
		NotEnoughSkulls,
		// Token: 0x0400195E RID: 6494
		Failure,
		// Token: 0x0400195F RID: 6495
		TencentITCDebitFailure,
		// Token: 0x04001960 RID: 6496
		TencentITCAccountIDParseError,
		// Token: 0x04001961 RID: 6497
		TencentITCAccountUnknown,
		// Token: 0x04001962 RID: 6498
		TencentITCUnknownOfferID,
		// Token: 0x04001963 RID: 6499
		TencentITCInvalidPriceType,
		// Token: 0x04001964 RID: 6500
		TencentITCConnectionError,
		// Token: 0x04001965 RID: 6501
		TencentITCAccountFrozen,
		// Token: 0x04001966 RID: 6502
		TencentITCParameterError,
		// Token: 0x04001967 RID: 6503
		TencentITCITCSystemBusy,
		// Token: 0x04001968 RID: 6504
		TencentITCITCAccountError,
		// Token: 0x04001969 RID: 6505
		TencentITCInsufficientBalance,
		// Token: 0x0400196A RID: 6506
		TencentITCFailedITCBill,
		// Token: 0x0400196B RID: 6507
		NotEnoughGibs
	}
}
