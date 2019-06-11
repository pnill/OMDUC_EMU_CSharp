using System;

namespace NetworkProtocols
{
	// Token: 0x0200069A RID: 1690
	public class RequestLobbyJoinForParty : BotNetMessage
	{
		// Token: 0x06003B38 RID: 15160 RVA: 0x0002102B File Offset: 0x0001F22B
		public RequestLobbyJoinForParty()
		{
			this.InitRefTypes();
			base.PacketType = 3294580938u;
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00021044 File Offset: 0x0001F244
		public RequestLobbyJoinForParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3294580938u;
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x00021064 File Offset: 0x0001F264
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0002106C File Offset: 0x0001F26C
		public ulong LobbyID { get; set; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x00021075 File Offset: 0x0001F275
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x0002107D File Offset: 0x0001F27D
		public ulong PartyID { get; set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x00021086 File Offset: 0x0001F286
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x0002108E File Offset: 0x0001F28E
		public string Password { get; set; }

		// Token: 0x06003B40 RID: 15168 RVA: 0x0011220C File Offset: 0x0011040C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Password);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x001122A8 File Offset: 0x001104A8
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
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.Password = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00021097 File Offset: 0x0001F297
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.PartyID = 0UL;
			this.Password = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F73 RID: 8051
		public const uint cPacketType = 3294580938u;
	}
}
