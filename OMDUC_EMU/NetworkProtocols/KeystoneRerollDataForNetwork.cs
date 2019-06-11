using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000598 RID: 1432
	public class KeystoneRerollDataForNetwork
	{
		// Token: 0x06003193 RID: 12691 RVA: 0x0001A99E File Offset: 0x00018B9E
		public KeystoneRerollDataForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x0001A9AC File Offset: 0x00018BAC
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x0001A9B4 File Offset: 0x00018BB4
		public uint RerollCount { get; set; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0001A9BD File Offset: 0x00018BBD
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x0001A9C5 File Offset: 0x00018BC5
		public List<StoreDataPrice> Prices { get; set; }

		// Token: 0x06003198 RID: 12696 RVA: 0x00104114 File Offset: 0x00102314
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.RerollCount);
			ArrayManager.WriteListStoreDataPrice(ref newArray, ref newSize, this.Prices);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00104150 File Offset: 0x00102350
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.RerollCount = ArrayManager.ReadUInt32(data, ref num);
			this.Prices = ArrayManager.ReadListStoreDataPrice(data, ref num);
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x0001A9CE File Offset: 0x00018BCE
		private void InitRefTypes()
		{
			this.RerollCount = 0u;
			this.Prices = new List<StoreDataPrice>();
		}
	}
}
