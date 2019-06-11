using System;

namespace NetworkProtocols
{
	// Token: 0x0200064F RID: 1615
	public class RequestLobbyDeckList : BotNetMessage
	{
		// Token: 0x06003852 RID: 14418 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
		public RequestLobbyDeckList()
		{
			this.InitRefTypes();
			base.PacketType = 2043110444u;
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0001EFE1 File Offset: 0x0001D1E1
		public RequestLobbyDeckList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2043110444u;
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x0001F001 File Offset: 0x0001D201
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x0001F009 File Offset: 0x0001D209
		public ulong LobbyID { get; set; }

		// Token: 0x06003856 RID: 14422 RVA: 0x0010DC2C File Offset: 0x0010BE2C
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0010DCAC File Offset: 0x0010BEAC
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
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x0001F012 File Offset: 0x0001D212
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E1A RID: 7706
		public const uint cPacketType = 2043110444u;
	}
}
