using System;

namespace NetworkProtocols
{
	// Token: 0x020006A6 RID: 1702
	public class RequestSendLobbyChat : BotNetMessage
	{
		// Token: 0x06003BB2 RID: 15282 RVA: 0x0002164B File Offset: 0x0001F84B
		public RequestSendLobbyChat()
		{
			this.InitRefTypes();
			base.PacketType = 4072129988u;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00021664 File Offset: 0x0001F864
		public RequestSendLobbyChat(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4072129988u;
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x00021684 File Offset: 0x0001F884
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x0002168C File Offset: 0x0001F88C
		public ulong LobbyID { get; set; }

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x00021695 File Offset: 0x0001F895
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x0002169D File Offset: 0x0001F89D
		public string ChatLine { get; set; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x000216A6 File Offset: 0x0001F8A6
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x000216AE File Offset: 0x0001F8AE
		public bool TeamOnly { get; set; }

		// Token: 0x06003BBA RID: 15290 RVA: 0x00112F04 File Offset: 0x00111104
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.ChatLine);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.TeamOnly);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00112FA0 File Offset: 0x001111A0
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
			this.ChatLine = ArrayManager.ReadString(data, ref num);
			this.TeamOnly = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x000216B7 File Offset: 0x0001F8B7
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.ChatLine = string.Empty;
			this.TeamOnly = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F9E RID: 8094
		public const uint cPacketType = 4072129988u;
	}
}
