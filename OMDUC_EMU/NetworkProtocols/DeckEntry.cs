using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000582 RID: 1410
	public class DeckEntry
	{
		// Token: 0x06003080 RID: 12416 RVA: 0x00019E34 File Offset: 0x00018034
		public DeckEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x00019E42 File Offset: 0x00018042
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x00019E4A File Offset: 0x0001804A
		public ulong DeckGUID { get; set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x00019E53 File Offset: 0x00018053
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x00019E5B File Offset: 0x0001805B
		public ulong DeckProtoGUID { get; set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x00019E64 File Offset: 0x00018064
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x00019E6C File Offset: 0x0001806C
		public string Name { get; set; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x00019E75 File Offset: 0x00018075
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x00019E7D File Offset: 0x0001807D
		public string DeckIcon { get; set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x00019E86 File Offset: 0x00018086
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x00019E8E File Offset: 0x0001808E
		public bool Locked { get; set; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x00019E97 File Offset: 0x00018097
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x00019E9F File Offset: 0x0001809F
		public bool IsDesignerDeck { get; set; }

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x00019EA8 File Offset: 0x000180A8
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x00019EB0 File Offset: 0x000180B0
		public List<DeckItem> Items { get; set; }

		// Token: 0x0600308F RID: 12431 RVA: 0x00102888 File Offset: 0x00100A88
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckProtoGUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteString(ref newArray, ref newSize, this.DeckIcon);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Locked);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsDesignerDeck);
			ArrayManager.WriteListDeckItem(ref newArray, ref newSize, this.Items);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00102910 File Offset: 0x00100B10
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.DeckGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.DeckIcon = ArrayManager.ReadString(data, ref num);
			this.Locked = ArrayManager.ReadBoolean(data, ref num);
			this.IsDesignerDeck = ArrayManager.ReadBoolean(data, ref num);
			this.Items = ArrayManager.ReadListDeckItem(data, ref num);
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x00102984 File Offset: 0x00100B84
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			this.DeckProtoGUID = 0UL;
			this.Name = string.Empty;
			this.DeckIcon = string.Empty;
			this.Locked = false;
			this.IsDesignerDeck = false;
			this.Items = new List<DeckItem>();
		}
	}
}
