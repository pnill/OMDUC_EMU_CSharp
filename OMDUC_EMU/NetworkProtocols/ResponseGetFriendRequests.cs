using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200071E RID: 1822
	public class ResponseGetFriendRequests : BotNetMessage
	{
		// Token: 0x0600409B RID: 16539 RVA: 0x00024C31 File Offset: 0x00022E31
		public ResponseGetFriendRequests()
		{
			this.InitRefTypes();
			base.PacketType = 2625276084u;
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00024C4A File Offset: 0x00022E4A
		public ResponseGetFriendRequests(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2625276084u;
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x00024C6A File Offset: 0x00022E6A
		// (set) Token: 0x0600409E RID: 16542 RVA: 0x00024C72 File Offset: 0x00022E72
		public eGetFriendRequestsStatus Status { get; set; }

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x00024C7B File Offset: 0x00022E7B
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x00024C83 File Offset: 0x00022E83
		public List<FriendRequestItem> FriendRequests { get; set; }

		// Token: 0x060040A1 RID: 16545 RVA: 0x0011D6CC File Offset: 0x0011B8CC
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
			ArrayManager.WriteeGetFriendRequestsStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListFriendRequestItem(ref newArray, ref newSize, this.FriendRequests);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x0011D758 File Offset: 0x0011B958
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGetFriendRequestsStatus(data, ref num);
			this.FriendRequests = ArrayManager.ReadListFriendRequestItem(data, ref num);
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00024C8C File Offset: 0x00022E8C
		private void InitRefTypes()
		{
			this.Status = eGetFriendRequestsStatus.GetFriendRequests_Failure;
			this.FriendRequests = new List<FriendRequestItem>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002221 RID: 8737
		public const uint cPacketType = 2625276084u;
	}
}
