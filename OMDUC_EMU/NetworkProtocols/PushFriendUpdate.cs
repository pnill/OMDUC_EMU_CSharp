using System;

namespace NetworkProtocols
{
	// Token: 0x02000725 RID: 1829
	public class PushFriendUpdate : BotNetMessage
	{
		// Token: 0x060040DA RID: 16602 RVA: 0x00024F66 File Offset: 0x00023166
		public PushFriendUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 84025690u;
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00024F7F File Offset: 0x0002317F
		public PushFriendUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 84025690u;
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x00024F9F File Offset: 0x0002319F
		// (set) Token: 0x060040DD RID: 16605 RVA: 0x00024FA7 File Offset: 0x000231A7
		public FriendItem UpdatedFriendItem { get; set; }

		// Token: 0x060040DE RID: 16606 RVA: 0x0011DD1C File Offset: 0x0011BF1C
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
			ArrayManager.WriteFriendItem(ref newArray, ref newSize, this.UpdatedFriendItem);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x0011DD9C File Offset: 0x0011BF9C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.UpdatedFriendItem = ArrayManager.ReadFriendItem(data, ref num);
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00024FB0 File Offset: 0x000231B0
		private void InitRefTypes()
		{
			this.UpdatedFriendItem = new FriendItem();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002236 RID: 8758
		public const uint cPacketType = 84025690u;
	}
}
