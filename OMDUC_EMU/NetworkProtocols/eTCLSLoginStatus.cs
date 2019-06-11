using System;

namespace NetworkProtocols
{
	// Token: 0x020004D0 RID: 1232
	public enum eTCLSLoginStatus
	{
		// Token: 0x040019B4 RID: 6580
		TCLSLoginStatus_Failure,
		// Token: 0x040019B5 RID: 6581
		TCLSLoginStatus_Success,
		// Token: 0x040019B6 RID: 6582
		TCLSLoginStatus_Banned,
		// Token: 0x040019B7 RID: 6583
		TCLSLoginStatus_Maintenance,
		// Token: 0x040019B8 RID: 6584
		TCLSLoginStatus_AccountUnknown,
		// Token: 0x040019B9 RID: 6585
		TCLSLoginStatus_SuccessShowTC,
		// Token: 0x040019BA RID: 6586
		TCLSLoginStatus_AccountNotWhiteListed,
		// Token: 0x040019BB RID: 6587
		TCLSLoginStatus_LoginPending,
		// Token: 0x040019BC RID: 6588
		TCLSLoginStatus_AlreadyLoggedIn,
		// Token: 0x040019BD RID: 6589
		TCLSLoginStatus_EmailRequired = 101,
		// Token: 0x040019BE RID: 6590
		TCLSLoginStatus_EmailIncorrectFormat,
		// Token: 0x040019BF RID: 6591
		TCLSLoginStatus_PasswordRequired = 104,
		// Token: 0x040019C0 RID: 6592
		TCLSLoginStatus_ServerBusy,
		// Token: 0x040019C1 RID: 6593
		TCLSLoginStatus_NicknameRequired,
		// Token: 0x040019C2 RID: 6594
		TCLSLoginStatus_NicknameInvalid
	}
}
