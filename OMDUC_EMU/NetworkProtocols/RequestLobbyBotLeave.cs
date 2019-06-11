using System;

namespace NetworkProtocols
{
	// Token: 0x0200069D RID: 1693
	public class RequestLobbyBotLeave : BotNetMessage
	{
		// Token: 0x06003B5F RID: 15199 RVA: 0x00021223 File Offset: 0x0001F423
		public RequestLobbyBotLeave()
		{
			this.InitRefTypes();
			base.PacketType = 2986645097u;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x0002123C File Offset: 0x0001F43C
		public RequestLobbyBotLeave(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2986645097u;
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06003B61 RID: 15201 RVA: 0x0002125C File Offset: 0x0001F45C
		// (set) Token: 0x06003B62 RID: 15202 RVA: 0x00021264 File Offset: 0x0001F464
		public ulong LobbyID { get; set; }

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x0002126D File Offset: 0x0001F46D
		// (set) Token: 0x06003B64 RID: 15204 RVA: 0x00021275 File Offset: 0x0001F475
		public uint MemberID { get; set; }

		// Token: 0x06003B65 RID: 15205 RVA: 0x001125C4 File Offset: 0x001107C4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LobbyID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MemberID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00112650 File Offset: 0x00110850
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LobbyID = ArrayManager.ReadUInt64(data, ref num);
			this.MemberID = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x0002127E File Offset: 0x0001F47E
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.MemberID = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F82 RID: 8066
		public const uint cPacketType = 2986645097u;
	}
}
