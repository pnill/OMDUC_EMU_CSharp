using System;

namespace NetworkProtocols
{
	// Token: 0x02000696 RID: 1686
	public class RequestDirectLobbyCreateParty : BotNetMessage
	{
		// Token: 0x06003B12 RID: 15122 RVA: 0x00020E3F File Offset: 0x0001F03F
		public RequestDirectLobbyCreateParty()
		{
			this.InitRefTypes();
			base.PacketType = 2523278831u;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00020E58 File Offset: 0x0001F058
		public RequestDirectLobbyCreateParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2523278831u;
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x00020E78 File Offset: 0x0001F078
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x00020E80 File Offset: 0x0001F080
		public ulong PartyID { get; set; }

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x00020E89 File Offset: 0x0001F089
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x00020E91 File Offset: 0x0001F091
		public eGameType GameType { get; set; }

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x00020E9A File Offset: 0x0001F09A
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x00020EA2 File Offset: 0x0001F0A2
		public string LobbyName { get; set; }

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x00020EAB File Offset: 0x0001F0AB
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x00020EB3 File Offset: 0x0001F0B3
		public ulong MapGUID { get; set; }

		// Token: 0x06003B1C RID: 15132 RVA: 0x00111DDC File Offset: 0x0010FFDC
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LobbyName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapGUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00111E88 File Offset: 0x00110088
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.LobbyName = ArrayManager.ReadString(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00020EBC File Offset: 0x0001F0BC
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.GameType = eGameType.None;
			this.LobbyName = string.Empty;
			this.MapGUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F66 RID: 8038
		public const uint cPacketType = 2523278831u;
	}
}
