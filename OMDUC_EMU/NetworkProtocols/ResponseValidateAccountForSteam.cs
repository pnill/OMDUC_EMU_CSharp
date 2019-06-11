using System;

namespace NetworkProtocols
{
	// Token: 0x02000606 RID: 1542
	public class ResponseValidateAccountForSteam : BotNetMessage
	{
		// Token: 0x060035C2 RID: 13762 RVA: 0x0001D34A File Offset: 0x0001B54A
		public ResponseValidateAccountForSteam()
		{
			this.InitRefTypes();
			base.PacketType = 856668671u;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0001D363 File Offset: 0x0001B563
		public ResponseValidateAccountForSteam(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 856668671u;
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x0001D383 File Offset: 0x0001B583
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x0001D38B File Offset: 0x0001B58B
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x060035C6 RID: 13766 RVA: 0x00109BAC File Offset: 0x00107DAC
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

		// Token: 0x060035C7 RID: 13767 RVA: 0x00109C2C File Offset: 0x00107E2C
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

		// Token: 0x060035C8 RID: 13768 RVA: 0x0001D394 File Offset: 0x0001B594
		private void InitRefTypes()
		{
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D4C RID: 7500
		public const uint cPacketType = 856668671u;
	}
}
