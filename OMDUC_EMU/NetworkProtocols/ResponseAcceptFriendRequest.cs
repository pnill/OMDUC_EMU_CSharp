using System;

namespace NetworkProtocols
{
	// Token: 0x0200071A RID: 1818
	public class ResponseAcceptFriendRequest : BotNetMessage
	{
		// Token: 0x0600407D RID: 16509 RVA: 0x00024AB7 File Offset: 0x00022CB7
		public ResponseAcceptFriendRequest()
		{
			this.InitRefTypes();
			base.PacketType = 3001880565u;
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00024AD0 File Offset: 0x00022CD0
		public ResponseAcceptFriendRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3001880565u;
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x00024AF0 File Offset: 0x00022CF0
		// (set) Token: 0x06004080 RID: 16512 RVA: 0x00024AF8 File Offset: 0x00022CF8
		public ulong AccountSUID { get; set; }

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06004081 RID: 16513 RVA: 0x00024B01 File Offset: 0x00022D01
		// (set) Token: 0x06004082 RID: 16514 RVA: 0x00024B09 File Offset: 0x00022D09
		public eAcceptFriendRequestStatus Status { get; set; }

		// Token: 0x06004083 RID: 16515 RVA: 0x0011D3DC File Offset: 0x0011B5DC
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
			ArrayManager.WriteeAcceptFriendRequestStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0011D468 File Offset: 0x0011B668
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
			this.Status = ArrayManager.ReadeAcceptFriendRequestStatus(data, ref num);
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00024B12 File Offset: 0x00022D12
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Status = eAcceptFriendRequestStatus.AcceptFriendRequestStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002218 RID: 8728
		public const uint cPacketType = 3001880565u;
	}
}
