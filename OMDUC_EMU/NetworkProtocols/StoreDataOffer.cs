using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000596 RID: 1430
	public class StoreDataOffer
	{
		// Token: 0x06003169 RID: 12649 RVA: 0x0001A84C File Offset: 0x00018A4C
		public StoreDataOffer()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x0001A85A File Offset: 0x00018A5A
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x0001A862 File Offset: 0x00018A62
		public ulong OfferID { get; set; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x0001A86B File Offset: 0x00018A6B
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x0001A873 File Offset: 0x00018A73
		public ulong LimitedTimeOfferID { get; set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x0001A87C File Offset: 0x00018A7C
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x0001A884 File Offset: 0x00018A84
		public DateTime ExpiresOn { get; set; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06003170 RID: 12656 RVA: 0x0001A88D File Offset: 0x00018A8D
		// (set) Token: 0x06003171 RID: 12657 RVA: 0x0001A895 File Offset: 0x00018A95
		public StoreDataLocalizedContent Name { get; set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x0001A89E File Offset: 0x00018A9E
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x0001A8A6 File Offset: 0x00018AA6
		public StoreDataLocalizedContent Description { get; set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x0001A8AF File Offset: 0x00018AAF
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x0001A8B7 File Offset: 0x00018AB7
		public List<StoreDataSaleItem> SaleItems { get; set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x0001A8C8 File Offset: 0x00018AC8
		public List<string> Tags { get; set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x0001A8D1 File Offset: 0x00018AD1
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0001A8D9 File Offset: 0x00018AD9
		public StoreDataDateRange OfferAvailability { get; set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x0001A8E2 File Offset: 0x00018AE2
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x0001A8EA File Offset: 0x00018AEA
		public List<StoreDataPrice> Prices { get; set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0001A8F3 File Offset: 0x00018AF3
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x0001A8FB File Offset: 0x00018AFB
		public StoreDataDateRange DiscountOfferAvailability { get; set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0001A904 File Offset: 0x00018B04
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x0001A90C File Offset: 0x00018B0C
		public List<StoreDataPrice> DiscountPrices { get; set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x0001A915 File Offset: 0x00018B15
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x0001A91D File Offset: 0x00018B1D
		public string ImageName { get; set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0001A926 File Offset: 0x00018B26
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x0001A92E File Offset: 0x00018B2E
		public bool DisableDisplayOfTitle { get; set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x0001A937 File Offset: 0x00018B37
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x0001A93F File Offset: 0x00018B3F
		public bool HasBeenPurchased { get; set; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x0001A948 File Offset: 0x00018B48
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x0001A950 File Offset: 0x00018B50
		public List<KeystoneRerollDataForNetwork> KeystoneRerollData { get; set; }

		// Token: 0x06003188 RID: 12680 RVA: 0x00103E20 File Offset: 0x00102020
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LimitedTimeOfferID);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.ExpiresOn);
			ArrayManager.WriteStoreDataLocalizedContent(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteStoreDataLocalizedContent(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteListStoreDataSaleItem(ref newArray, ref newSize, this.SaleItems);
			ArrayManager.WriteListString(ref newArray, ref newSize, this.Tags);
			ArrayManager.WriteStoreDataDateRange(ref newArray, ref newSize, this.OfferAvailability);
			ArrayManager.WriteListStoreDataPrice(ref newArray, ref newSize, this.Prices);
			ArrayManager.WriteStoreDataDateRange(ref newArray, ref newSize, this.DiscountOfferAvailability);
			ArrayManager.WriteListStoreDataPrice(ref newArray, ref newSize, this.DiscountPrices);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ImageName);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DisableDisplayOfTitle);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.HasBeenPurchased);
			ArrayManager.WriteListKeystoneRerollDataForNetwork(ref newArray, ref newSize, this.KeystoneRerollData);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00103F20 File Offset: 0x00102120
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.LimitedTimeOfferID = ArrayManager.ReadUInt64(data, ref num);
			this.ExpiresOn = ArrayManager.ReadDateTime(data, ref num);
			this.Name = ArrayManager.ReadStoreDataLocalizedContent(data, ref num);
			this.Description = ArrayManager.ReadStoreDataLocalizedContent(data, ref num);
			this.SaleItems = ArrayManager.ReadListStoreDataSaleItem(data, ref num);
			this.Tags = ArrayManager.ReadListString(data, ref num);
			this.OfferAvailability = ArrayManager.ReadStoreDataDateRange(data, ref num);
			this.Prices = ArrayManager.ReadListStoreDataPrice(data, ref num);
			this.DiscountOfferAvailability = ArrayManager.ReadStoreDataDateRange(data, ref num);
			this.DiscountPrices = ArrayManager.ReadListStoreDataPrice(data, ref num);
			this.ImageName = ArrayManager.ReadString(data, ref num);
			this.DisableDisplayOfTitle = ArrayManager.ReadBoolean(data, ref num);
			this.HasBeenPurchased = ArrayManager.ReadBoolean(data, ref num);
			this.KeystoneRerollData = ArrayManager.ReadListKeystoneRerollDataForNetwork(data, ref num);
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00104004 File Offset: 0x00102204
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
			this.LimitedTimeOfferID = 0UL;
			this.ExpiresOn = default(DateTime);
			this.Name = new StoreDataLocalizedContent();
			this.Description = new StoreDataLocalizedContent();
			this.SaleItems = new List<StoreDataSaleItem>();
			this.Tags = new List<string>();
			this.OfferAvailability = new StoreDataDateRange();
			this.Prices = new List<StoreDataPrice>();
			this.DiscountOfferAvailability = new StoreDataDateRange();
			this.DiscountPrices = new List<StoreDataPrice>();
			this.ImageName = string.Empty;
			this.DisableDisplayOfTitle = false;
			this.HasBeenPurchased = false;
			this.KeystoneRerollData = new List<KeystoneRerollDataForNetwork>();
		}
	}
}
