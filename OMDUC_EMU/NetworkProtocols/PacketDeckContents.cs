using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000654 RID: 1620
	public class PacketDeckContents
	{
		// Token: 0x06003884 RID: 14468 RVA: 0x0001F1FD File Offset: 0x0001D3FD
		public PacketDeckContents()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x0001F20B File Offset: 0x0001D40B
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x0001F213 File Offset: 0x0001D413
		public ulong DeckGUID { get; set; }

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x0001F21C File Offset: 0x0001D41C
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x0001F224 File Offset: 0x0001D424
		public ulong DeckProtoGUID { get; set; }

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x0001F22D File Offset: 0x0001D42D
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x0001F235 File Offset: 0x0001D435
		public List<ulong> DeckItems { get; set; }

		// Token: 0x0600388B RID: 14475 RVA: 0x0010E148 File Offset: 0x0010C348
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckProtoGUID);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.DeckItems);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0010E194 File Offset: 0x0010C394
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.DeckGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckItems = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x0001F23E File Offset: 0x0001D43E
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			this.DeckProtoGUID = 0UL;
			this.DeckItems = new List<ulong>();
		}
	}
}
