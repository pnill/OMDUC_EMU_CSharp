using System;

namespace NetworkProtocols
{
	// Token: 0x020004D8 RID: 1240
	public enum eKeystoneRerollStatus
	{
		// Token: 0x04001A07 RID: 6663
		Success,
		// Token: 0x04001A08 RID: 6664
		GeneralFailure,
		// Token: 0x04001A09 RID: 6665
		KeystoneNotFound,
		// Token: 0x04001A0A RID: 6666
		KeystoneNotOwned,
		// Token: 0x04001A0B RID: 6667
		KeystoneOfferMismatch,
		// Token: 0x04001A0C RID: 6668
		OfferInvalid,
		// Token: 0x04001A0D RID: 6669
		KeystonePriceMismatch,
		// Token: 0x04001A0E RID: 6670
		KeystoneInvalidForRerolls,
		// Token: 0x04001A0F RID: 6671
		NotEnoughGold,
		// Token: 0x04001A10 RID: 6672
		NotEnoughSkulls,
		// Token: 0x04001A11 RID: 6673
		NotEnoughGibs,
		// Token: 0x04001A12 RID: 6674
		CurrencyMismatch,
		// Token: 0x04001A13 RID: 6675
		UnknownUser
	}
}
