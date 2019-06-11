using System;

namespace NetworkProtocols
{
	// Token: 0x020006A7 RID: 1703
	public class RequestMapList : BotNetMessage
	{
		// Token: 0x06003BBD RID: 15293 RVA: 0x000216DA File Offset: 0x0001F8DA
		public RequestMapList()
		{
			this.InitRefTypes();
			base.PacketType = 947528557u;
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x000216F3 File Offset: 0x0001F8F3
		public RequestMapList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 947528557u;
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06003BBF RID: 15295 RVA: 0x00021713 File Offset: 0x0001F913
		// (set) Token: 0x06003BC0 RID: 15296 RVA: 0x0002171B File Offset: 0x0001F91B
		public eMapGameType GameTypeFilter { get; set; }

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00113024 File Offset: 0x00111224
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
			ArrayManager.WriteeMapGameType(ref newArray, ref newSize, this.GameTypeFilter);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x001130A4 File Offset: 0x001112A4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameTypeFilter = ArrayManager.ReadeMapGameType(data, ref num);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00021724 File Offset: 0x0001F924
		private void InitRefTypes()
		{
			this.GameTypeFilter = eMapGameType.MapGameType_None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FA2 RID: 8098
		public const uint cPacketType = 947528557u;
	}
}
