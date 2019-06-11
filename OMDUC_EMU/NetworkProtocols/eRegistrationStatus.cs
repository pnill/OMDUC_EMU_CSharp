using System;

namespace NetworkProtocols
{
	// Token: 0x02000495 RID: 1173
	public enum eRegistrationStatus
	{
		// Token: 0x040016EE RID: 5870
		eRegistrationStatus_Success,
		// Token: 0x040016EF RID: 5871
		eRegistrationStatus_ServerError,
		// Token: 0x040016F0 RID: 5872
		eRegistrationStatus_InvalidNickname,
		// Token: 0x040016F1 RID: 5873
		eRegistrationStatus_InvalidEmail,
		// Token: 0x040016F2 RID: 5874
		eRegistrationStatus_InvalidPassword,
		// Token: 0x040016F3 RID: 5875
		eRegistrationStatus_InvalidGameCode,
		// Token: 0x040016F4 RID: 5876
		eRegistrationStatus_EmailExists,
		// Token: 0x040016F5 RID: 5877
		eRegistrationStatus_FraudulentEmail,
		// Token: 0x040016F6 RID: 5878
		eRegistrationStatus_NicknameExists,
		// Token: 0x040016F7 RID: 5879
		eRegistrationStatus_RestrictedNickname,
		// Token: 0x040016F8 RID: 5880
		eRegistrationStatus_NicknameTooShort,
		// Token: 0x040016F9 RID: 5881
		eRegistrationStatus_NicknameTooLong,
		// Token: 0x040016FA RID: 5882
		eRegistrationStatus_PasswordTooShort,
		// Token: 0x040016FB RID: 5883
		eRegistrationStatus_PasswordTooLong,
		// Token: 0x040016FC RID: 5884
		eRegistrationStatus_PasswordNotComplex,
		// Token: 0x040016FD RID: 5885
		eRegistrationStatus_ReferralNotFound,
		// Token: 0x040016FE RID: 5886
		eRegistrationStatus_GameCodeUsed,
		// Token: 0x040016FF RID: 5887
		eRegistrationStatus_SteamAuthenticationFailed = 201,
		// Token: 0x04001700 RID: 5888
		eRegistrationStatus_SteamIDDoesNotMatchAuthToken
	}
}
