using System;

namespace NetworkProtocols
{
	// Token: 0x020006A5 RID: 1701
	public class RequestLobbyStartGame : BotNetMessage
	{
		// Token: 0x06003BAB RID: 15275 RVA: 0x000215F0 File Offset: 0x0001F7F0
		public RequestLobbyStartGame()
		{
			this.InitRefTypes();
			base.PacketType = 1133738214u;
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00021609 File Offset: 0x0001F809
		public RequestLobbyStartGame(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1133738214u;
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x00021629 File Offset: 0x0001F829
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x00021631 File Offset: 0x0001F831
		public ulong LobbyID { get; set; }

		// Token: 0x06003BAF RID: 15279 RVA: 0x00112E1C File Offset: 0x0011101C
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00112E9C File Offset: 0x0011109C
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
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x0002163A File Offset: 0x0001F83A
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F9C RID: 8092
		public const uint cPacketType = 1133738214u;
	}
}
