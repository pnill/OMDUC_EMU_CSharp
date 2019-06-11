using System;

namespace NetworkProtocols
{
	// Token: 0x02000489 RID: 1161
	public class LeftChatRoomPush : BotNetMessage
	{
		// Token: 0x06002A09 RID: 10761 RVA: 0x00015E2D File Offset: 0x0001402D
		public LeftChatRoomPush()
		{
			this.InitRefTypes();
			base.PacketType = 138217706u;
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00015E46 File Offset: 0x00014046
		public LeftChatRoomPush(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 138217706u;
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x00015E66 File Offset: 0x00014066
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x00015E6E File Offset: 0x0001406E
		public ulong ChatID { get; set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x00015E77 File Offset: 0x00014077
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00015E7F File Offset: 0x0001407F
		public eChatRoomType ChatRoomType { get; set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x00015E88 File Offset: 0x00014088
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x00015E90 File Offset: 0x00014090
		public string RoomName { get; set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x00015E99 File Offset: 0x00014099
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x00015EA1 File Offset: 0x000140A1
		public ulong AccountSUID { get; set; }

		// Token: 0x06002A13 RID: 10771 RVA: 0x000FA9D0 File Offset: 0x000F8BD0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			ArrayManager.WriteeChatRoomType(ref newArray, ref newSize, this.ChatRoomType);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RoomName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000FAA7C File Offset: 0x000F8C7C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
			this.ChatRoomType = ArrayManager.ReadeChatRoomType(data, ref num);
			this.RoomName = ArrayManager.ReadString(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00015EAA File Offset: 0x000140AA
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.ChatRoomType = eChatRoomType.None;
			this.RoomName = string.Empty;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016CB RID: 5835
		public const uint cPacketType = 138217706u;
	}
}
