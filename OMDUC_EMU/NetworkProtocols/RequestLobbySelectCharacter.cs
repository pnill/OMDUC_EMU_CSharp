using System;

namespace NetworkProtocols
{
	// Token: 0x020006A1 RID: 1697
	public class RequestLobbySelectCharacter : BotNetMessage
	{
		// Token: 0x06003B83 RID: 15235 RVA: 0x000213F0 File Offset: 0x0001F5F0
		public RequestLobbySelectCharacter()
		{
			this.InitRefTypes();
			base.PacketType = 2344008563u;
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00021409 File Offset: 0x0001F609
		public RequestLobbySelectCharacter(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2344008563u;
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x00021429 File Offset: 0x0001F629
		// (set) Token: 0x06003B86 RID: 15238 RVA: 0x00021431 File Offset: 0x0001F631
		public ulong LobbyID { get; set; }

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x0002143A File Offset: 0x0001F63A
		// (set) Token: 0x06003B88 RID: 15240 RVA: 0x00021442 File Offset: 0x0001F642
		public ulong SelectedCharacter { get; set; }

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06003B89 RID: 15241 RVA: 0x0002144B File Offset: 0x0001F64B
		// (set) Token: 0x06003B8A RID: 15242 RVA: 0x00021453 File Offset: 0x0001F653
		public bool IsCharacterSelected { get; set; }

		// Token: 0x06003B8B RID: 15243 RVA: 0x001129D4 File Offset: 0x00110BD4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedCharacter);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsCharacterSelected);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00112A70 File Offset: 0x00110C70
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
			this.SelectedCharacter = ArrayManager.ReadUInt64(data, ref num);
			this.IsCharacterSelected = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x0002145C File Offset: 0x0001F65C
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.SelectedCharacter = 0UL;
			this.IsCharacterSelected = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F8E RID: 8078
		public const uint cPacketType = 2344008563u;
	}
}
