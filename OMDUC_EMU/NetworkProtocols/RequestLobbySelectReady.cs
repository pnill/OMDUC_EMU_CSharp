using System;

namespace NetworkProtocols
{
	// Token: 0x020006A4 RID: 1700
	public class RequestLobbySelectReady : BotNetMessage
	{
		// Token: 0x06003BA2 RID: 15266 RVA: 0x0002157D File Offset: 0x0001F77D
		public RequestLobbySelectReady()
		{
			this.InitRefTypes();
			base.PacketType = 1956461478u;
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00021596 File Offset: 0x0001F796
		public RequestLobbySelectReady(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1956461478u;
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x000215B6 File Offset: 0x0001F7B6
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x000215BE File Offset: 0x0001F7BE
		public ulong LobbyID { get; set; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x000215C7 File Offset: 0x0001F7C7
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x000215CF File Offset: 0x0001F7CF
		public bool Ready { get; set; }

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00112D18 File Offset: 0x00110F18
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Ready);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x00112DA4 File Offset: 0x00110FA4
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
			this.Ready = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000215D8 File Offset: 0x0001F7D8
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.Ready = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F99 RID: 8089
		public const uint cPacketType = 1956461478u;
	}
}
