using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000584 RID: 1412
	public class ResponsePlayerDecks : BotNetMessage
	{
		// Token: 0x0600309E RID: 12446 RVA: 0x00019F2E File Offset: 0x0001812E
		public ResponsePlayerDecks()
		{
			this.InitRefTypes();
			base.PacketType = 2376677189u;
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x00019F47 File Offset: 0x00018147
		public ResponsePlayerDecks(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2376677189u;
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x00019F67 File Offset: 0x00018167
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x00019F6F File Offset: 0x0001816F
		public ulong AccountSUID { get; set; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x00019F78 File Offset: 0x00018178
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x00019F80 File Offset: 0x00018180
		public List<DeckEntry> Decks { get; set; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00019F89 File Offset: 0x00018189
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x00019F91 File Offset: 0x00018191
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x00019F9A File Offset: 0x0001819A
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x00019FA2 File Offset: 0x000181A2
		public ulong Value { get; set; }

		// Token: 0x060030A8 RID: 12456 RVA: 0x00102A74 File Offset: 0x00100C74
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteListDeckEntry(ref newArray, ref newSize, this.Decks);
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00102B20 File Offset: 0x00100D20
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Decks = ArrayManager.ReadListDeckEntry(data, ref num);
			this.EventCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00019FAB File Offset: 0x000181AB
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Decks = new List<DeckEntry>();
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BA4 RID: 7076
		public const uint cPacketType = 2376677189u;
	}
}
