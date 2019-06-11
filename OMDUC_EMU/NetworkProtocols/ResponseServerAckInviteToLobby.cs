using System;

namespace NetworkProtocols
{
	// Token: 0x020006C2 RID: 1730
	public class ResponseServerAckInviteToLobby : BotNetMessage
	{
		// Token: 0x06003E0B RID: 15883 RVA: 0x00022D08 File Offset: 0x00020F08
		public ResponseServerAckInviteToLobby()
		{
			this.InitRefTypes();
			base.PacketType = 2287934850u;
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00022D21 File Offset: 0x00020F21
		public ResponseServerAckInviteToLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2287934850u;
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06003E0D RID: 15885 RVA: 0x00022D41 File Offset: 0x00020F41
		// (set) Token: 0x06003E0E RID: 15886 RVA: 0x00022D49 File Offset: 0x00020F49
		public ulong LobbyID { get; set; }

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x00022D52 File Offset: 0x00020F52
		// (set) Token: 0x06003E10 RID: 15888 RVA: 0x00022D5A File Offset: 0x00020F5A
		public bool DidJoin { get; set; }

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x00022D63 File Offset: 0x00020F63
		// (set) Token: 0x06003E12 RID: 15890 RVA: 0x00022D6B File Offset: 0x00020F6B
		public eLobbyRequestResult Status { get; set; }

		// Token: 0x06003E13 RID: 15891 RVA: 0x00116210 File Offset: 0x00114410
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DidJoin);
			ArrayManager.WriteeLobbyRequestResult(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x001162AC File Offset: 0x001144AC
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
			this.DidJoin = ArrayManager.ReadBoolean(data, ref num);
			this.Status = ArrayManager.ReadeLobbyRequestResult(data, ref num);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00022D74 File Offset: 0x00020F74
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.DidJoin = false;
			this.Status = eLobbyRequestResult.LobbyRequest_Succeeded;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400209D RID: 8349
		public const uint cPacketType = 2287934850u;
	}
}
