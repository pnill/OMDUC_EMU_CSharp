using System;

namespace NetworkProtocols
{
	// Token: 0x020004E9 RID: 1257
	public class RequestPlayerAddDeck : BotNetMessage
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x00016FF4 File Offset: 0x000151F4
		public RequestPlayerAddDeck()
		{
			this.InitRefTypes();
			base.PacketType = 3235719861u;
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0001700D File Offset: 0x0001520D
		public RequestPlayerAddDeck(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3235719861u;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0001702D File Offset: 0x0001522D
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x00017035 File Offset: 0x00015235
		public string DeckName { get; set; }

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0001703E File Offset: 0x0001523E
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x00017046 File Offset: 0x00015246
		public ulong DeckProtoGUID { get; set; }

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x0001704F File Offset: 0x0001524F
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00017057 File Offset: 0x00015257
		public string DeckIcon { get; set; }

		// Token: 0x06002B8C RID: 11148 RVA: 0x000FCB94 File Offset: 0x000FAD94
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.DeckName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckProtoGUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.DeckIcon);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x000FCC30 File Offset: 0x000FAE30
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.DeckName = ArrayManager.ReadString(data, ref num);
			this.DeckProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckIcon = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00017060 File Offset: 0x00015260
		private void InitRefTypes()
		{
			this.DeckName = string.Empty;
			this.DeckProtoGUID = 0UL;
			this.DeckIcon = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A3F RID: 6719
		public const uint cPacketType = 3235719861u;
	}
}
