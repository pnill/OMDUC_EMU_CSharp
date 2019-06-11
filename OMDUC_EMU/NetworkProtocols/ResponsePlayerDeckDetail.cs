using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000586 RID: 1414
	public class ResponsePlayerDeckDetail : BotNetMessage
	{
		// Token: 0x060030B3 RID: 12467 RVA: 0x0001A017 File Offset: 0x00018217
		public ResponsePlayerDeckDetail()
		{
			this.InitRefTypes();
			base.PacketType = 1989657788u;
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0001A030 File Offset: 0x00018230
		public ResponsePlayerDeckDetail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1989657788u;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x0001A050 File Offset: 0x00018250
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x0001A058 File Offset: 0x00018258
		public ulong DeckGUID { get; set; }

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x0001A061 File Offset: 0x00018261
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x0001A069 File Offset: 0x00018269
		public List<ResponsePlayerDeckDetailEntry> Items { get; set; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x0001A072 File Offset: 0x00018272
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x0001A07A File Offset: 0x0001827A
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x0001A083 File Offset: 0x00018283
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x0001A08B File Offset: 0x0001828B
		public ulong Value { get; set; }

		// Token: 0x060030BD RID: 12477 RVA: 0x00102C1C File Offset: 0x00100E1C
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
			ArrayManager.WriteListResponsePlayerDeckDetailEntry(ref newArray, ref newSize, this.Items);
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00102CC8 File Offset: 0x00100EC8
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
			this.Items = ArrayManager.ReadListResponsePlayerDeckDetailEntry(data, ref num);
			this.EventCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0001A094 File Offset: 0x00018294
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			this.Items = new List<ResponsePlayerDeckDetailEntry>();
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BAB RID: 7083
		public const uint cPacketType = 1989657788u;
	}
}
