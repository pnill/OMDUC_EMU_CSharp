using System;

namespace NetworkProtocols
{
	// Token: 0x020006C4 RID: 1732
	public class RecipientResponseInviteToLobby : BotNetMessage
	{
		// Token: 0x06003E23 RID: 15907 RVA: 0x00022E3E File Offset: 0x0002103E
		public RecipientResponseInviteToLobby()
		{
			this.InitRefTypes();
			base.PacketType = 2408005643u;
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00022E57 File Offset: 0x00021057
		public RecipientResponseInviteToLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2408005643u;
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x00022E77 File Offset: 0x00021077
		// (set) Token: 0x06003E26 RID: 15910 RVA: 0x00022E7F File Offset: 0x0002107F
		public ulong LobbyID { get; set; }

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06003E27 RID: 15911 RVA: 0x00022E88 File Offset: 0x00021088
		// (set) Token: 0x06003E28 RID: 15912 RVA: 0x00022E90 File Offset: 0x00021090
		public ulong AccountSUID { get; set; }

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x00022E99 File Offset: 0x00021099
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x00022EA1 File Offset: 0x000210A1
		public string Username { get; set; }

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x00022EAA File Offset: 0x000210AA
		// (set) Token: 0x06003E2C RID: 15916 RVA: 0x00022EB2 File Offset: 0x000210B2
		public eLobbyInviteStatus DidJoin { get; set; }

		// Token: 0x06003E2D RID: 15917 RVA: 0x00116470 File Offset: 0x00114670
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteeLobbyInviteStatus(ref newArray, ref newSize, this.DidJoin);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0011651C File Offset: 0x0011471C
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
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.DidJoin = ArrayManager.ReadeLobbyInviteStatus(data, ref num);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00022EBB File Offset: 0x000210BB
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.AccountSUID = 0UL;
			this.Username = string.Empty;
			this.DidJoin = eLobbyInviteStatus.LobbyInviteStatus_Succeeded;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020A6 RID: 8358
		public const uint cPacketType = 2408005643u;
	}
}
