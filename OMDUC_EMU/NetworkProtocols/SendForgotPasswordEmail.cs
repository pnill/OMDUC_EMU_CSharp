using System;
using System.ComponentModel;
using ProtoBuf;

namespace NetworkProtocols
{
	// Token: 0x020004A6 RID: 1190
	[ProtoContract(Name = "SendForgotPasswordEmail")]
	[Serializable]
	public class SendForgotPasswordEmail : BotNetMessage
	{
		// Token: 0x06002AC6 RID: 10950 RVA: 0x000166A3 File Offset: 0x000148A3
		public SendForgotPasswordEmail()
		{
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000166CC File Offset: 0x000148CC
		public SendForgotPasswordEmail(ulong sessionToken)
		{
			base.SessionToken = sessionToken;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000166FC File Offset: 0x000148FC
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x00016704 File Offset: 0x00014904
		[DefaultValue(0f)]
		[ProtoMember(11, IsRequired = false, Name = "AccountSUID", DataFormat = DataFormat.TwosComplement)]
		public ulong AccountSUID
		{
			get
			{
				return this._AccountSUID;
			}
			set
			{
				this._AccountSUID = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x0001670D File Offset: 0x0001490D
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x00016715 File Offset: 0x00014915
		[DefaultValue("")]
		[ProtoMember(12, IsRequired = false, Name = "EmailAddress", DataFormat = DataFormat.Default)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				this._EmailAddress = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x0001671E File Offset: 0x0001491E
		// (set) Token: 0x06002ACD RID: 10957 RVA: 0x00016726 File Offset: 0x00014926
		[DefaultValue("")]
		[ProtoMember(13, IsRequired = false, Name = "Username", DataFormat = DataFormat.Default)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				this._Username = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x0001672F File Offset: 0x0001492F
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00016737 File Offset: 0x00014937
		[DefaultValue("")]
		[ProtoMember(14, IsRequired = false, Name = "Token", DataFormat = DataFormat.Default)]
		public string Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				this._Token = value;
			}
		}

		// Token: 0x0400178F RID: 6031
		private ulong _AccountSUID;

		// Token: 0x04001790 RID: 6032
		private string _EmailAddress = string.Empty;

		// Token: 0x04001791 RID: 6033
		private string _Username = string.Empty;

		// Token: 0x04001792 RID: 6034
		private string _Token = string.Empty;
	}
}
