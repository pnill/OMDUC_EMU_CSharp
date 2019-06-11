using System;

namespace NetworkProtocols
{
	// Token: 0x02000718 RID: 1816
	public class ResponseDeleteFriend : BotNetMessage
	{
		// Token: 0x0600406D RID: 16493 RVA: 0x000249E9 File Offset: 0x00022BE9
		public ResponseDeleteFriend()
		{
			this.InitRefTypes();
			base.PacketType = 1116757033u;
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00024A02 File Offset: 0x00022C02
		public ResponseDeleteFriend(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1116757033u;
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x00024A22 File Offset: 0x00022C22
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x00024A2A File Offset: 0x00022C2A
		public ulong AccountSUID { get; set; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x00024A33 File Offset: 0x00022C33
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x00024A3B File Offset: 0x00022C3B
		public eDeleteFriendStatus Status { get; set; }

		// Token: 0x06004073 RID: 16499 RVA: 0x0011D1F0 File Offset: 0x0011B3F0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteeDeleteFriendStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x0011D27C File Offset: 0x0011B47C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeDeleteFriendStatus(data, ref num);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00024A44 File Offset: 0x00022C44
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Status = eDeleteFriendStatus.DeleteFriendStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002213 RID: 8723
		public const uint cPacketType = 1116757033u;
	}
}
