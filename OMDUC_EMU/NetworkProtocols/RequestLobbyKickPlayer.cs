using System;

namespace NetworkProtocols
{
	// Token: 0x020006BC RID: 1724
	public class RequestLobbyKickPlayer : BotNetMessage
	{
		// Token: 0x06003DD1 RID: 15825 RVA: 0x00022A18 File Offset: 0x00020C18
		public RequestLobbyKickPlayer()
		{
			this.InitRefTypes();
			base.PacketType = 3451241323u;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00022A31 File Offset: 0x00020C31
		public RequestLobbyKickPlayer(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3451241323u;
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x00022A51 File Offset: 0x00020C51
		// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x00022A59 File Offset: 0x00020C59
		public ulong LobbyID { get; set; }

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x00022A62 File Offset: 0x00020C62
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x00022A6A File Offset: 0x00020C6A
		public ulong KickedSUID { get; set; }

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00115BC0 File Offset: 0x00113DC0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KickedSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00115C4C File Offset: 0x00113E4C
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
			this.KickedSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00022A73 File Offset: 0x00020C73
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.KickedSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002089 RID: 8329
		public const uint cPacketType = 3451241323u;
	}
}
