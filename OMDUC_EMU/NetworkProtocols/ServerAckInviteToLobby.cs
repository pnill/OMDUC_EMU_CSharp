using System;

namespace NetworkProtocols
{
	// Token: 0x020006C0 RID: 1728
	public class ServerAckInviteToLobby : BotNetMessage
	{
		// Token: 0x06003DF7 RID: 15863 RVA: 0x00022C09 File Offset: 0x00020E09
		public ServerAckInviteToLobby()
		{
			this.InitRefTypes();
			base.PacketType = 1334854673u;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00022C22 File Offset: 0x00020E22
		public ServerAckInviteToLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1334854673u;
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x00022C42 File Offset: 0x00020E42
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x00022C4A File Offset: 0x00020E4A
		public ulong LobbyID { get; set; }

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x00022C53 File Offset: 0x00020E53
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x00022C5B File Offset: 0x00020E5B
		public ulong AccountSUID { get; set; }

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x00022C64 File Offset: 0x00020E64
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x00022C6C File Offset: 0x00020E6C
		public eLobbyRequestResult Status { get; set; }

		// Token: 0x06003DFF RID: 15871 RVA: 0x00115FEC File Offset: 0x001141EC
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
			ArrayManager.WriteeLobbyRequestResult(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00116088 File Offset: 0x00114288
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
			this.Status = ArrayManager.ReadeLobbyRequestResult(data, ref num);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00022C75 File Offset: 0x00020E75
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.AccountSUID = 0UL;
			this.Status = eLobbyRequestResult.LobbyRequest_Succeeded;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002096 RID: 8342
		public const uint cPacketType = 1334854673u;
	}
}
