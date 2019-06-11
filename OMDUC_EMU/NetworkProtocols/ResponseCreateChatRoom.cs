using System;

namespace NetworkProtocols
{
	// Token: 0x02000484 RID: 1156
	public class ResponseCreateChatRoom : BotNetMessage
	{
		// Token: 0x060029CE RID: 10702 RVA: 0x00015B78 File Offset: 0x00013D78
		public ResponseCreateChatRoom()
		{
			this.InitRefTypes();
			base.PacketType = 3151536836u;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00015B91 File Offset: 0x00013D91
		public ResponseCreateChatRoom(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3151536836u;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x00015BB1 File Offset: 0x00013DB1
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x00015BB9 File Offset: 0x00013DB9
		public ulong ChatID { get; set; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x00015BC2 File Offset: 0x00013DC2
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x00015BCA File Offset: 0x00013DCA
		public eCreateChatRoomStatus Status { get; set; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x00015BD3 File Offset: 0x00013DD3
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x00015BDB File Offset: 0x00013DDB
		public eChatRoomType RoomType { get; set; }

		// Token: 0x060029D6 RID: 10710 RVA: 0x000FA398 File Offset: 0x000F8598
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
			ArrayManager.WriteeCreateChatRoomStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteeChatRoomType(ref newArray, ref newSize, this.RoomType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000FA434 File Offset: 0x000F8634
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
			this.Status = ArrayManager.ReadeCreateChatRoomStatus(data, ref num);
			this.RoomType = ArrayManager.ReadeChatRoomType(data, ref num);
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00015BE4 File Offset: 0x00013DE4
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.Status = eCreateChatRoomStatus.None;
			this.RoomType = eChatRoomType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016B5 RID: 5813
		public const uint cPacketType = 3151536836u;
	}
}
