using System;

namespace NetworkProtocols
{
	// Token: 0x020006C3 RID: 1731
	public class RecipientRequestInviteToLobby : BotNetMessage
	{
		// Token: 0x06003E16 RID: 15894 RVA: 0x00022D93 File Offset: 0x00020F93
		public RecipientRequestInviteToLobby()
		{
			this.InitRefTypes();
			base.PacketType = 2303525649u;
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00022DAC File Offset: 0x00020FAC
		public RecipientRequestInviteToLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2303525649u;
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x00022DCC File Offset: 0x00020FCC
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x00022DD4 File Offset: 0x00020FD4
		public ulong LobbyID { get; set; }

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00022DDD File Offset: 0x00020FDD
		// (set) Token: 0x06003E1B RID: 15899 RVA: 0x00022DE5 File Offset: 0x00020FE5
		public eGameType LobbyGameType { get; set; }

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x00022DEE File Offset: 0x00020FEE
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x00022DF6 File Offset: 0x00020FF6
		public string LeaderName { get; set; }

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x00022DFF File Offset: 0x00020FFF
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00022E07 File Offset: 0x00021007
		public string GuildTag { get; set; }

		// Token: 0x06003E20 RID: 15904 RVA: 0x00116330 File Offset: 0x00114530
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
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.LobbyGameType);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LeaderName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x001163DC File Offset: 0x001145DC
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
			this.LobbyGameType = ArrayManager.ReadeGameType(data, ref num);
			this.LeaderName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x00022E10 File Offset: 0x00021010
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.LobbyGameType = eGameType.None;
			this.LeaderName = string.Empty;
			this.GuildTag = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020A1 RID: 8353
		public const uint cPacketType = 2303525649u;
	}
}
