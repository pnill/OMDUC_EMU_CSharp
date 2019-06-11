using System;

namespace NetworkProtocols
{
	// Token: 0x0200059A RID: 1434
	public class StoreDataSaleItem
	{
		// Token: 0x060031A3 RID: 12707 RVA: 0x0001AA2A File Offset: 0x00018C2A
		public StoreDataSaleItem()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x0001AA38 File Offset: 0x00018C38
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x0001AA40 File Offset: 0x00018C40
		public StoreDataLocalizedContent Name { get; set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0001AA49 File Offset: 0x00018C49
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0001AA51 File Offset: 0x00018C51
		public StoreDataLocalizedContent Description { get; set; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0001AA5A File Offset: 0x00018C5A
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0001AA62 File Offset: 0x00018C62
		public eOfferEntryCurrencyType CurrencyType { get; set; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0001AA6B File Offset: 0x00018C6B
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x0001AA73 File Offset: 0x00018C73
		public ulong ItemGUID { get; set; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0001AA7C File Offset: 0x00018C7C
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0001AA84 File Offset: 0x00018C84
		public ulong CardGUID { get; set; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0001AA8D File Offset: 0x00018C8D
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x0001AA95 File Offset: 0x00018C95
		public uint Count { get; set; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x0001AA9E File Offset: 0x00018C9E
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x0001AAA6 File Offset: 0x00018CA6
		public ulong EventChestGUID { get; set; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x0001AAAF File Offset: 0x00018CAF
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x0001AAB7 File Offset: 0x00018CB7
		public int AvatarKey { get; set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		public bool IsRobotEmployee { get; set; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x0001AAD1 File Offset: 0x00018CD1
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x0001AAD9 File Offset: 0x00018CD9
		public bool HasBetaAccess { get; set; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x0001AAE2 File Offset: 0x00018CE2
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x0001AAEA File Offset: 0x00018CEA
		public string FounderLevel { get; set; }

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x0001AAF3 File Offset: 0x00018CF3
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x0001AAFB File Offset: 0x00018CFB
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0001AB04 File Offset: 0x00018D04
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x0001AB0C File Offset: 0x00018D0C
		public uint BoostDurationDays { get; set; }

		// Token: 0x060031BE RID: 12734 RVA: 0x001041E4 File Offset: 0x001023E4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteStoreDataLocalizedContent(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteStoreDataLocalizedContent(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteeOfferEntryCurrencyType(ref newArray, ref newSize, this.CurrencyType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ItemGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CardGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Count);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EventChestGUID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.AvatarKey);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.HasBetaAccess);
			ArrayManager.WriteString(ref newArray, ref newSize, this.FounderLevel);
			ArrayManager.WriteePlayerBoostType(ref newArray, ref newSize, this.BoostType);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.BoostDurationDays);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x001042C8 File Offset: 0x001024C8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Name = ArrayManager.ReadStoreDataLocalizedContent(data, ref num);
			this.Description = ArrayManager.ReadStoreDataLocalizedContent(data, ref num);
			this.CurrencyType = ArrayManager.ReadeOfferEntryCurrencyType(data, ref num);
			this.ItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.CardGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Count = ArrayManager.ReadUInt32(data, ref num);
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.AvatarKey = ArrayManager.ReadInt32(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.HasBetaAccess = ArrayManager.ReadBoolean(data, ref num);
			this.FounderLevel = ArrayManager.ReadString(data, ref num);
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			this.BoostDurationDays = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00104390 File Offset: 0x00102590
		private void InitRefTypes()
		{
			this.Name = new StoreDataLocalizedContent();
			this.Description = new StoreDataLocalizedContent();
			this.CurrencyType = eOfferEntryCurrencyType.None;
			this.ItemGUID = 0UL;
			this.CardGUID = 0UL;
			this.Count = 0u;
			this.EventChestGUID = 0UL;
			this.AvatarKey = 0;
			this.IsRobotEmployee = false;
			this.HasBetaAccess = false;
			this.FounderLevel = string.Empty;
			this.BoostType = ePlayerBoostType.None;
			this.BoostDurationDays = 0u;
		}
	}
}
