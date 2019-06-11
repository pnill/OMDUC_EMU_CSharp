using System;

namespace NetworkProtocols
{
	// Token: 0x02000588 RID: 1416
	public class ResponsePlayerDeleteDeck : BotNetMessage
	{
		// Token: 0x060030C9 RID: 12489 RVA: 0x0001A132 File Offset: 0x00018332
		public ResponsePlayerDeleteDeck()
		{
			this.InitRefTypes();
			base.PacketType = 1750828980u;
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0001A14B File Offset: 0x0001834B
		public ResponsePlayerDeleteDeck(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1750828980u;
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x0001A16B File Offset: 0x0001836B
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x0001A173 File Offset: 0x00018373
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x0001A17C File Offset: 0x0001837C
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x0001A184 File Offset: 0x00018384
		public ulong Value { get; set; }

		// Token: 0x060030CF RID: 12495 RVA: 0x00102E60 File Offset: 0x00101060
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
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00102EEC File Offset: 0x001010EC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EventCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0001A18D File Offset: 0x0001838D
		private void InitRefTypes()
		{
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BB3 RID: 7091
		public const uint cPacketType = 1750828980u;
	}
}
