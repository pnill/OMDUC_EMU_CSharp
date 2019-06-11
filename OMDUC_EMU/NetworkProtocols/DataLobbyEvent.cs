using System;

namespace NetworkProtocols
{
	// Token: 0x020006B2 RID: 1714
	public class DataLobbyEvent : BotNetMessage
	{
		// Token: 0x06003CA0 RID: 15520 RVA: 0x00021F04 File Offset: 0x00020104
		public DataLobbyEvent()
		{
			this.InitRefTypes();
			base.PacketType = 1963338851u;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00021F1D File Offset: 0x0002011D
		public DataLobbyEvent(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1963338851u;
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06003CA2 RID: 15522 RVA: 0x00021F3D File Offset: 0x0002013D
		// (set) Token: 0x06003CA3 RID: 15523 RVA: 0x00021F45 File Offset: 0x00020145
		public ulong LobbyID { get; set; }

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x00021F4E File Offset: 0x0002014E
		// (set) Token: 0x06003CA5 RID: 15525 RVA: 0x00021F56 File Offset: 0x00020156
		public eLobbyEventCodes EventCode { get; set; }

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06003CA6 RID: 15526 RVA: 0x00021F5F File Offset: 0x0002015F
		// (set) Token: 0x06003CA7 RID: 15527 RVA: 0x00021F67 File Offset: 0x00020167
		public ulong Value { get; set; }

		// Token: 0x06003CA8 RID: 15528 RVA: 0x0011433C File Offset: 0x0011253C
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
			ArrayManager.WriteeLobbyEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x001143D8 File Offset: 0x001125D8
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
			this.EventCode = ArrayManager.ReadeLobbyEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00021F70 File Offset: 0x00020170
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.EventCode = eLobbyEventCodes.LobbyEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002001 RID: 8193
		public const uint cPacketType = 1963338851u;
	}
}
