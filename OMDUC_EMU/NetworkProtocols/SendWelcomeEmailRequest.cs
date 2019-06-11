using System;
using System.ComponentModel;
using ProtoBuf;

namespace NetworkProtocols
{
	// Token: 0x020004A5 RID: 1189
	[ProtoContract(Name = "SendWelcomeEmailRequest")]
	[Serializable]
	public class SendWelcomeEmailRequest : BotNetMessage
	{
		// Token: 0x06002ABE RID: 10942 RVA: 0x0001662D File Offset: 0x0001482D
		public SendWelcomeEmailRequest()
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x0001664B File Offset: 0x0001484B
		public SendWelcomeEmailRequest(ulong sessionToken)
		{
			base.SessionToken = sessionToken;
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x00016670 File Offset: 0x00014870
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x00016678 File Offset: 0x00014878
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x00016681 File Offset: 0x00014881
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00016689 File Offset: 0x00014889
		[ProtoMember(12, IsRequired = false, Name = "EmailAddress", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x00016692 File Offset: 0x00014892
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x0001669A File Offset: 0x0001489A
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

		// Token: 0x0400178C RID: 6028
		private ulong _AccountSUID;

		// Token: 0x0400178D RID: 6029
		private string _EmailAddress = string.Empty;

		// Token: 0x0400178E RID: 6030
		private string _Username = string.Empty;
	}
}
