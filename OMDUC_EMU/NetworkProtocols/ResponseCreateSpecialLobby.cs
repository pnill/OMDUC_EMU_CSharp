using System;

namespace NetworkProtocols
{
	// Token: 0x02000698 RID: 1688
	public class ResponseCreateSpecialLobby : BotNetMessage
	{
		// Token: 0x06003B28 RID: 15144 RVA: 0x00020F5A File Offset: 0x0001F15A
		public ResponseCreateSpecialLobby()
		{
			this.InitRefTypes();
			base.PacketType = 1779119402u;
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00020F73 File Offset: 0x0001F173
		public ResponseCreateSpecialLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1779119402u;
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x00020F93 File Offset: 0x0001F193
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x00020F9B File Offset: 0x0001F19B
		public eSpecialLobbyEventCodes ResponseCode { get; set; }

		// Token: 0x06003B2C RID: 15148 RVA: 0x00112020 File Offset: 0x00110220
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
			ArrayManager.WriteeSpecialLobbyEventCodes(ref newArray, ref newSize, this.ResponseCode);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x001120A0 File Offset: 0x001102A0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ResponseCode = ArrayManager.ReadeSpecialLobbyEventCodes(data, ref num);
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		private void InitRefTypes()
		{
			this.ResponseCode = eSpecialLobbyEventCodes.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F6E RID: 8046
		public const uint cPacketType = 1779119402u;
	}
}
