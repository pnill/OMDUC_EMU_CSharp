using System;

namespace NetworkProtocols
{
	// Token: 0x020004B9 RID: 1209
	public enum eAuthLoginUserStatus
	{
		// Token: 0x040017CE RID: 6094
		AuthLoginUserStatus_Failure,
		// Token: 0x040017CF RID: 6095
		AuthLoginUserStatus_Success,
		// Token: 0x040017D0 RID: 6096
		AuthLoginUserStatus_Banned,
		// Token: 0x040017D1 RID: 6097
		AuthLoginUserStatus_Maintenance,
		// Token: 0x040017D2 RID: 6098
		AuthLoginUserStatus_AccountUnknown,
		// Token: 0x040017D3 RID: 6099
		AuthLoginUserStatus_AccountNotWhiteListed = 6,
		// Token: 0x040017D4 RID: 6100
		AuthLoginUserStatus_LoginPending,
		// Token: 0x040017D5 RID: 6101
		AuthLoginUserStatus_AlreadyLoggedIn,
		// Token: 0x040017D6 RID: 6102
		AuthLoginUserStatus_IPAddressBanned,
		// Token: 0x040017D7 RID: 6103
		AuthLoginUserStatus_Email = 101,
		// Token: 0x040017D8 RID: 6104
		AuthLoginUserStatus_EmailIncorrectFormat,
		// Token: 0x040017D9 RID: 6105
		AuthLoginUserStatus_Password = 104,
		// Token: 0x040017DA RID: 6106
		AuthLoginUserStatus_ServerBusy,
		// Token: 0x040017DB RID: 6107
		AuthLoginUserStatus_ConfirmationCodeRequired,
		// Token: 0x040017DC RID: 6108
		AuthLoginUserStatus_ConfirmationCodeInvalid,
		// Token: 0x040017DD RID: 6109
		AuthLoginUserStatus_NeedUsername,
		// Token: 0x040017DE RID: 6110
		AuthLoginUserStatus_SteamAuthenticationFailed = 201,
		// Token: 0x040017DF RID: 6111
		AuthLoginUserStatus_SteamIDDoesNotMatchAuthToken,
		// Token: 0x040017E0 RID: 6112
		AuthLoginUserStatus_SteamAccountNotFound,
		// Token: 0x040017E1 RID: 6113
		AuthLoginUserStatus_SteamAccountAlreadyLinked,
		// Token: 0x040017E2 RID: 6114
		AuthLoginUserStatus_SteamUserIsOffline,
		// Token: 0x040017E3 RID: 6115
		AuthLoginUserStatus_SteamInvalidTicket,
		// Token: 0x040017E4 RID: 6116
		AuthLoginUserStatus_InvalidNickname = 301,
		// Token: 0x040017E5 RID: 6117
		AuthLoginUserStatus_NicknameExists,
		// Token: 0x040017E6 RID: 6118
		AuthLoginUserStatus_RestrictedNickname,
		// Token: 0x040017E7 RID: 6119
		AuthLoginUserStatus_NicknameTooShort,
		// Token: 0x040017E8 RID: 6120
		AuthLoginUserStatus_NicknameTooLong,
		// Token: 0x040017E9 RID: 6121
		AuthLoginUserStatus_TransferCodeInvalid = 400,
		// Token: 0x040017EA RID: 6122
		AuthLoginUserStatus_TransferCodeUsed
	}
}
