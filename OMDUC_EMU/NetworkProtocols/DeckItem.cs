using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000583 RID: 1411
	public class DeckItem
	{
		// Token: 0x06003092 RID: 12434 RVA: 0x00019EB9 File Offset: 0x000180B9
		public DeckItem()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x00019EC7 File Offset: 0x000180C7
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x00019ECF File Offset: 0x000180CF
		public ulong InventoryProtoGUID { get; set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x00019ED8 File Offset: 0x000180D8
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x00019EE0 File Offset: 0x000180E0
		public int DeckSlot { get; set; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x00019EE9 File Offset: 0x000180E9
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x00019EF1 File Offset: 0x000180F1
		public uint Tier { get; set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x00019EFA File Offset: 0x000180FA
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x00019F02 File Offset: 0x00018102
		public List<ulong> Slots { get; set; }

		// Token: 0x0600309B RID: 12443 RVA: 0x001029D0 File Offset: 0x00100BD0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InventoryProtoGUID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.DeckSlot);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Tier);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.Slots);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00102A2C File Offset: 0x00100C2C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InventoryProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckSlot = ArrayManager.ReadInt32(data, ref num);
			this.Tier = ArrayManager.ReadUInt32(data, ref num);
			this.Slots = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00019F0B File Offset: 0x0001810B
		private void InitRefTypes()
		{
			this.InventoryProtoGUID = 0UL;
			this.DeckSlot = 0;
			this.Tier = 0u;
			this.Slots = new List<ulong>();
		}
	}
}
