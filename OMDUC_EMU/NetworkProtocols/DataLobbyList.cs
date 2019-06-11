using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006AC RID: 1708
	public class DataLobbyList : BotNetMessage
	{
		// Token: 0x06003BFD RID: 15357 RVA: 0x00021972 File Offset: 0x0001FB72
		public DataLobbyList()
		{
			this.InitRefTypes();
			base.PacketType = 3899484410u;
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0002198B File Offset: 0x0001FB8B
		public DataLobbyList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3899484410u;
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x000219AB File Offset: 0x0001FBAB
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x000219B3 File Offset: 0x0001FBB3
		public List<LobbyListEntry> Lobbies { get; set; }

		// Token: 0x06003C01 RID: 15361 RVA: 0x0011364C File Offset: 0x0011184C
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
			ArrayManager.WriteListLobbyListEntry(ref newArray, ref newSize, this.Lobbies);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x001136CC File Offset: 0x001118CC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Lobbies = ArrayManager.ReadListLobbyListEntry(data, ref num);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x000219BC File Offset: 0x0001FBBC
		private void InitRefTypes()
		{
			this.Lobbies = new List<LobbyListEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FBA RID: 8122
		public const uint cPacketType = 3899484410u;
	}
}
