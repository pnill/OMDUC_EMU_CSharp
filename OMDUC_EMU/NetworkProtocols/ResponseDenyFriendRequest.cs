using System;

namespace NetworkProtocols
{
	// Token: 0x0200071C RID: 1820
	public class ResponseDenyFriendRequest : BotNetMessage
	{
		// Token: 0x0600408D RID: 16525 RVA: 0x00024B85 File Offset: 0x00022D85
		public ResponseDenyFriendRequest()
		{
			this.InitRefTypes();
			base.PacketType = 375865500u;
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00024B9E File Offset: 0x00022D9E
		public ResponseDenyFriendRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 375865500u;
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x00024BBE File Offset: 0x00022DBE
		// (set) Token: 0x06004090 RID: 16528 RVA: 0x00024BC6 File Offset: 0x00022DC6
		public ulong AccountSUID { get; set; }

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06004091 RID: 16529 RVA: 0x00024BCF File Offset: 0x00022DCF
		// (set) Token: 0x06004092 RID: 16530 RVA: 0x00024BD7 File Offset: 0x00022DD7
		public eDenyFriendRequestStatus Status { get; set; }

		// Token: 0x06004093 RID: 16531 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
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
			ArrayManager.WriteeDenyFriendRequestStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0011D654 File Offset: 0x0011B854
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
			this.Status = ArrayManager.ReadeDenyFriendRequestStatus(data, ref num);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00024BE0 File Offset: 0x00022DE0
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Status = eDenyFriendRequestStatus.DenyFriendRequestStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400221D RID: 8733
		public const uint cPacketType = 375865500u;
	}
}
