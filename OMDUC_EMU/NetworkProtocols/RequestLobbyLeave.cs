using System;

namespace NetworkProtocols
{
	// Token: 0x0200069E RID: 1694
	public class RequestLobbyLeave : BotNetMessage
	{
		// Token: 0x06003B68 RID: 15208 RVA: 0x00021296 File Offset: 0x0001F496
		public RequestLobbyLeave()
		{
			this.InitRefTypes();
			base.PacketType = 4068564391u;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x000212AF File Offset: 0x0001F4AF
		public RequestLobbyLeave(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4068564391u;
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x000212CF File Offset: 0x0001F4CF
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x000212D7 File Offset: 0x0001F4D7
		public ulong LobbyID { get; set; }

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x000212E0 File Offset: 0x0001F4E0
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x000212E8 File Offset: 0x0001F4E8
		public bool IsDisconnect { get; set; }

		// Token: 0x06003B6E RID: 15214 RVA: 0x001126C8 File Offset: 0x001108C8
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsDisconnect);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00112754 File Offset: 0x00110954
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
			this.IsDisconnect = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x000212F1 File Offset: 0x0001F4F1
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.IsDisconnect = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F85 RID: 8069
		public const uint cPacketType = 4068564391u;
	}
}
