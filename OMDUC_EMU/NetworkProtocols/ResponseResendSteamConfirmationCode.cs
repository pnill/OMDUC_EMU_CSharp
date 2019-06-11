using System;

namespace NetworkProtocols
{
	// Token: 0x0200060E RID: 1550
	public class ResponseResendSteamConfirmationCode : BotNetMessage
	{
		// Token: 0x0600361E RID: 13854 RVA: 0x0001D781 File Offset: 0x0001B981
		public ResponseResendSteamConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 3284622792u;
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0001D79A File Offset: 0x0001B99A
		public ResponseResendSteamConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3284622792u;
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x0001D7BA File Offset: 0x0001B9BA
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x0001D7C2 File Offset: 0x0001B9C2
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x06003622 RID: 13858 RVA: 0x0010A5A8 File Offset: 0x001087A8
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

		// Token: 0x06003623 RID: 13859 RVA: 0x0010A628 File Offset: 0x00108828
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

		// Token: 0x06003624 RID: 13860 RVA: 0x0001D7CB File Offset: 0x0001B9CB
		private void InitRefTypes()
		{
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D6E RID: 7534
		public const uint cPacketType = 3284622792u;
	}
}
