using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000720 RID: 1824
	public class ResponseGetFriends : BotNetMessage
	{
		// Token: 0x060040A9 RID: 16553 RVA: 0x00024CE0 File Offset: 0x00022EE0
		public ResponseGetFriends()
		{
			this.InitRefTypes();
			base.PacketType = 3974413295u;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00024CF9 File Offset: 0x00022EF9
		public ResponseGetFriends(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3974413295u;
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x00024D19 File Offset: 0x00022F19
		// (set) Token: 0x060040AC RID: 16556 RVA: 0x00024D21 File Offset: 0x00022F21
		public eGetFriendsStatus Status { get; set; }

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060040AD RID: 16557 RVA: 0x00024D2A File Offset: 0x00022F2A
		// (set) Token: 0x060040AE RID: 16558 RVA: 0x00024D32 File Offset: 0x00022F32
		public List<FriendItem> Friends { get; set; }

		// Token: 0x060040AF RID: 16559 RVA: 0x0011D7D0 File Offset: 0x0011B9D0
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
			ArrayManager.WriteeGetFriendsStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListFriendItem(ref newArray, ref newSize, this.Friends);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0011D85C File Offset: 0x0011BA5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGetFriendsStatus(data, ref num);
			this.Friends = ArrayManager.ReadListFriendItem(data, ref num);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00024D3B File Offset: 0x00022F3B
		private void InitRefTypes()
		{
			this.Status = eGetFriendsStatus.GetFriends_Failure;
			this.Friends = new List<FriendItem>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002225 RID: 8741
		public const uint cPacketType = 3974413295u;
	}
}
