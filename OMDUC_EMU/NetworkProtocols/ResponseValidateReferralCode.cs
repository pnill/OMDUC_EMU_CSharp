using System;

namespace NetworkProtocols
{
	// Token: 0x02000613 RID: 1555
	public class ResponseValidateReferralCode : BotNetMessage
	{
		// Token: 0x06003641 RID: 13889 RVA: 0x0001D94C File Offset: 0x0001BB4C
		public ResponseValidateReferralCode()
		{
			this.InitRefTypes();
			base.PacketType = 2085121178u;
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0001D965 File Offset: 0x0001BB65
		public ResponseValidateReferralCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2085121178u;
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x0001D985 File Offset: 0x0001BB85
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x0001D98D File Offset: 0x0001BB8D
		public eRegistrationStatus Status { get; set; }

		// Token: 0x06003645 RID: 13893 RVA: 0x0010AA30 File Offset: 0x00108C30
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
			ArrayManager.WriteeRegistrationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0010AAB0 File Offset: 0x00108CB0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeRegistrationStatus(data, ref num);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0001D996 File Offset: 0x0001BB96
		private void InitRefTypes()
		{
			this.Status = eRegistrationStatus.eRegistrationStatus_Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D78 RID: 7544
		public const uint cPacketType = 2085121178u;
	}
}
