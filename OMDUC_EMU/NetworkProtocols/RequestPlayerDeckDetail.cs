using System;

namespace NetworkProtocols
{
	// Token: 0x020004E7 RID: 1255
	public class RequestPlayerDeckDetail : BotNetMessage
	{
		// Token: 0x06002B76 RID: 11126 RVA: 0x00016F3E File Offset: 0x0001513E
		public RequestPlayerDeckDetail()
		{
			this.InitRefTypes();
			base.PacketType = 2606440563u;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00016F57 File Offset: 0x00015157
		public RequestPlayerDeckDetail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2606440563u;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x00016F77 File Offset: 0x00015177
		// (set) Token: 0x06002B79 RID: 11129 RVA: 0x00016F7F File Offset: 0x0001517F
		public ulong DeckGUID { get; set; }

		// Token: 0x06002B7A RID: 11130 RVA: 0x000FC9C4 File Offset: 0x000FABC4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckGUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000FCA44 File Offset: 0x000FAC44
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.DeckGUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00016F88 File Offset: 0x00015188
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A3B RID: 6715
		public const uint cPacketType = 2606440563u;
	}
}
