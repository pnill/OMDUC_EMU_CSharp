using System;

namespace NetworkProtocols
{
	// Token: 0x0200060C RID: 1548
	public class ResponseResendConfirmationCode : BotNetMessage
	{
		// Token: 0x06003606 RID: 13830 RVA: 0x0001D688 File Offset: 0x0001B888
		public ResponseResendConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 2624590464u;
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x0001D6A1 File Offset: 0x0001B8A1
		public ResponseResendConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2624590464u;
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x0001D6C1 File Offset: 0x0001B8C1
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x0001D6C9 File Offset: 0x0001B8C9
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x0600360A RID: 13834 RVA: 0x0010A2F4 File Offset: 0x001084F4
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
			ArrayManager.WriteeAuthLoginUserStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x0010A374 File Offset: 0x00108574
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeAuthLoginUserStatus(data, ref num);
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x0001D6D2 File Offset: 0x0001B8D2
		private void InitRefTypes()
		{
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D65 RID: 7525
		public const uint cPacketType = 2624590464u;
	}
}
