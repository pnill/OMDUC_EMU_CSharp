using System;
using ProtoBuf;

namespace NetworkProtocols
{
	// Token: 0x020004A7 RID: 1191
	[ProtoContract(Name = "eEmailTemplateType")]
	public enum eEmailTemplateType
	{
		// Token: 0x04001794 RID: 6036
		[ProtoEnum(Name = "eEmailTemplateType_RegistrationWelcomeEmail", Value = 0)]
		eEmailTemplateType_RegistrationWelcomeEmail,
		// Token: 0x04001795 RID: 6037
		[ProtoEnum(Name = "eEmailTemplateType_ForgotPasswordEmail", Value = 1)]
		eEmailTemplateType_ForgotPasswordEmail
	}
}
