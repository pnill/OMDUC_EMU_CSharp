using System;

namespace NetworkProtocols
{
	// Token: 0x02000488 RID: 1160
	public class JoinChatRoomPush : BotNetMessage
	{
		// Token: 0x060029FC RID: 10748 RVA: 0x00015D85 File Offset: 0x00013F85
		public JoinChatRoomPush()
		{
			this.InitRefTypes();
			base.PacketType = 3832506386u;
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00015D9E File Offset: 0x00013F9E
		public JoinChatRoomPush(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3832506386u;
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x00015DBE File Offset: 0x00013FBE
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x00015DC6 File Offset: 0x00013FC6
		public ulong ChatID { get; set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x00015DCF File Offset: 0x00013FCF
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x00015DD7 File Offset: 0x00013FD7
		public eChatRoomType ChatRoomType { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x00015DE0 File Offset: 0x00013FE0
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x00015DE8 File Offset: 0x00013FE8
		public string RoomName { get; set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x00015DF1 File Offset: 0x00013FF1
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x00015DF9 File Offset: 0x00013FF9
		public ulong WhisperAccountSUID { get; set; }

		// Token: 0x06002A06 RID: 10758 RVA: 0x000FA890 File Offset: 0x000F8A90
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.WhisperAccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000FA93C File Offset: 0x000F8B3C
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
			this.WhisperAccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00015E02 File Offset: 0x00014002
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.ChatRoomType = eChatRoomType.None;
			this.RoomName = string.Empty;
			this.WhisperAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016C6 RID: 5830
		public const uint cPacketType = 3832506386u;
	}
}
