using System;

namespace NetworkProtocols
{
	// Token: 0x020006A8 RID: 1704
	public class RequestLobbyMap : BotNetMessage
	{
		// Token: 0x06003BC4 RID: 15300 RVA: 0x00021734 File Offset: 0x0001F934
		public RequestLobbyMap()
		{
			this.InitRefTypes();
			base.PacketType = 1411369296u;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x0002174D File Offset: 0x0001F94D
		public RequestLobbyMap(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1411369296u;
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0002176D File Offset: 0x0001F96D
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x00021775 File Offset: 0x0001F975
		public ulong LobbyID { get; set; }

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x0002177E File Offset: 0x0001F97E
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x00021786 File Offset: 0x0001F986
		public ulong MapID { get; set; }

		// Token: 0x06003BCA RID: 15306 RVA: 0x0011310C File Offset: 0x0011130C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00113198 File Offset: 0x00111398
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
			this.MapID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0002178F File Offset: 0x0001F98F
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.MapID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FA4 RID: 8100
		public const uint cPacketType = 1411369296u;
	}
}
