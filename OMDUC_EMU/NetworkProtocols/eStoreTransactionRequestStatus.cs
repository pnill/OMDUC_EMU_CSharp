using System;

namespace NetworkProtocols
{
	// Token: 0x020004C6 RID: 1222
	public enum eStoreTransactionRequestStatus
	{
		// Token: 0x0400194C RID: 6476
		Success,
		// Token: 0x0400194D RID: 6477
		AccountUnknown,
		// Token: 0x0400194E RID: 6478
		OfferInvalid,
		// Token: 0x0400194F RID: 6479
		OfferNotYetStarted,
		// Token: 0x04001950 RID: 6480
		OfferHasEnded,
		// Token: 0x04001951 RID: 6481
		OfferQuantityExceeded,
		// Token: 0x04001952 RID: 6482
		Failure,
		// Token: 0x04001953 RID: 6483
		InvalidTransactionID
	}
}
