using System;

namespace NetworkProtocols
{
	// Token: 0x02000716 RID: 1814
	public class ResponseCreateFriendRequestByAccountSUID : BotNetMessage
	{
		// Token: 0x0600405D RID: 16477 RVA: 0x0002491B File Offset: 0x00022B1B
		public ResponseCreateFriendRequestByAccountSUID()
		{
			this.InitRefTypes();
			base.PacketType = 1788117334u;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00024934 File Offset: 0x00022B34
		public ResponseCreateFriendRequestByAccountSUID(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1788117334u;
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600405F RID: 16479 RVA: 0x00024954 File Offset: 0x00022B54
		// (set) Token: 0x06004060 RID: 16480 RVA: 0x0002495C File Offset: 0x00022B5C
		public ulong AccountSUID { get; set; }

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x00024965 File Offset: 0x00022B65
		// (set) Token: 0x06004062 RID: 16482 RVA: 0x0002496D File Offset: 0x00022B6D
		public eCreateFriendRequestStatus Status { get; set; }

		// Token: 0x06004063 RID: 16483 RVA: 0x0011D004 File Offset: 0x0011B204
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
			ArrayManager.WriteeCreateFriendRequestStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0011D090 File Offset: 0x0011B290
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
			this.Status = ArrayManager.ReadeCreateFriendRequestStatus(data, ref num);
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00024976 File Offset: 0x00022B76
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Status = eCreateFriendRequestStatus.CreateFriendRequestStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400220E RID: 8718
		public const uint cPacketType = 1788117334u;
	}
}
