using System;

namespace NetworkProtocols
{
	// Token: 0x0200069C RID: 1692
	public class RequestLobbyBotJoin : BotNetMessage
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x00021197 File Offset: 0x0001F397
		public RequestLobbyBotJoin()
		{
			this.InitRefTypes();
			base.PacketType = 1170143662u;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000211B0 File Offset: 0x0001F3B0
		public RequestLobbyBotJoin(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1170143662u;
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x000211D0 File Offset: 0x0001F3D0
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x000211D8 File Offset: 0x0001F3D8
		public ulong LobbyID { get; set; }

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x000211E1 File Offset: 0x0001F3E1
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x000211E9 File Offset: 0x0001F3E9
		public ulong BotID { get; set; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x000211F2 File Offset: 0x0001F3F2
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x000211FA File Offset: 0x0001F3FA
		public uint Team { get; set; }

		// Token: 0x06003B5C RID: 15196 RVA: 0x001124A4 File Offset: 0x001106A4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BotID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Team);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00112540 File Offset: 0x00110740
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
			this.BotID = ArrayManager.ReadUInt64(data, ref num);
			this.Team = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00021203 File Offset: 0x0001F403
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.BotID = 0UL;
			this.Team = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F7E RID: 8062
		public const uint cPacketType = 1170143662u;
	}
}
