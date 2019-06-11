using System;

namespace NetworkProtocols
{
	// Token: 0x0200060A RID: 1546
	public class ResponseSubmitSteamConfirmationCode : BotNetMessage
	{
		// Token: 0x060035F2 RID: 13810 RVA: 0x0001D57C File Offset: 0x0001B77C
		public ResponseSubmitSteamConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 4156966080u;
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0001D595 File Offset: 0x0001B795
		public ResponseSubmitSteamConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4156966080u;
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x0001D5B5 File Offset: 0x0001B7B5
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x0001D5BD File Offset: 0x0001B7BD
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x060035F6 RID: 13814 RVA: 0x0010A0CC File Offset: 0x001082CC
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

		// Token: 0x060035F7 RID: 13815 RVA: 0x0010A14C File Offset: 0x0010834C
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

		// Token: 0x060035F8 RID: 13816 RVA: 0x0001D5C6 File Offset: 0x0001B7C6
		private void InitRefTypes()
		{
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D5E RID: 7518
		public const uint cPacketType = 4156966080u;
	}
}
