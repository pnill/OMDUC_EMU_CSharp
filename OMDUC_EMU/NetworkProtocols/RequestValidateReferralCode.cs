using System;

namespace NetworkProtocols
{
	// Token: 0x02000612 RID: 1554
	public class RequestValidateReferralCode : BotNetMessage
	{
		// Token: 0x0600363A RID: 13882 RVA: 0x0001D8EE File Offset: 0x0001BAEE
		public RequestValidateReferralCode()
		{
			this.InitRefTypes();
			base.PacketType = 1165618225u;
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0001D907 File Offset: 0x0001BB07
		public RequestValidateReferralCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1165618225u;
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x0001D927 File Offset: 0x0001BB27
		// (set) Token: 0x0600363D RID: 13885 RVA: 0x0001D92F File Offset: 0x0001BB2F
		public string ReferralCode { get; set; }

		// Token: 0x0600363E RID: 13886 RVA: 0x0010A948 File Offset: 0x00108B48
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ReferralCode);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0010A9C8 File Offset: 0x00108BC8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ReferralCode = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0001D938 File Offset: 0x0001BB38
		private void InitRefTypes()
		{
			this.ReferralCode = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D76 RID: 7542
		public const uint cPacketType = 1165618225u;
	}
}
