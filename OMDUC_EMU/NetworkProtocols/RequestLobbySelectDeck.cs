using System;

namespace NetworkProtocols
{
	// Token: 0x020006A2 RID: 1698
	public class RequestLobbySelectDeck : BotNetMessage
	{
		// Token: 0x06003B8E RID: 15246 RVA: 0x0002147C File Offset: 0x0001F67C
		public RequestLobbySelectDeck()
		{
			this.InitRefTypes();
			base.PacketType = 4101520268u;
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00021495 File Offset: 0x0001F695
		public RequestLobbySelectDeck(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4101520268u;
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x000214B5 File Offset: 0x0001F6B5
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x000214BD File Offset: 0x0001F6BD
		public ulong LobbyID { get; set; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x000214C6 File Offset: 0x0001F6C6
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x000214CE File Offset: 0x0001F6CE
		public ulong SelectedDeck { get; set; }

		// Token: 0x06003B94 RID: 15252 RVA: 0x00112AF4 File Offset: 0x00110CF4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedDeck);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00112B80 File Offset: 0x00110D80
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
			this.SelectedDeck = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x000214D7 File Offset: 0x0001F6D7
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.SelectedDeck = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F92 RID: 8082
		public const uint cPacketType = 4101520268u;
	}
}
