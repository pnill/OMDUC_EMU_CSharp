using System;

namespace NetworkProtocols
{
	// Token: 0x020006A0 RID: 1696
	public class RequestLobbySelectTeam : BotNetMessage
	{
		// Token: 0x06003B7A RID: 15226 RVA: 0x0002137D File Offset: 0x0001F57D
		public RequestLobbySelectTeam()
		{
			this.InitRefTypes();
			base.PacketType = 2134158244u;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00021396 File Offset: 0x0001F596
		public RequestLobbySelectTeam(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2134158244u;
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x000213B6 File Offset: 0x0001F5B6
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x000213BE File Offset: 0x0001F5BE
		public ulong LobbyID { get; set; }

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x000213C7 File Offset: 0x0001F5C7
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x000213CF File Offset: 0x0001F5CF
		public uint Team { get; set; }

		// Token: 0x06003B80 RID: 15232 RVA: 0x001128D0 File Offset: 0x00110AD0
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
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Team);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x0011295C File Offset: 0x00110B5C
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
			this.Team = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x000213D8 File Offset: 0x0001F5D8
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.Team = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F8B RID: 8075
		public const uint cPacketType = 2134158244u;
	}
}
