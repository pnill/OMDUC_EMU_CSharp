using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200059E RID: 1438
	public class ContentDefinition
	{
		// Token: 0x060031DE RID: 12766 RVA: 0x0001AC49 File Offset: 0x00018E49
		public ContentDefinition()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x0001AC57 File Offset: 0x00018E57
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x0001AC5F File Offset: 0x00018E5F
		public ulong ContentDefinitionID { get; set; }

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x0001AC68 File Offset: 0x00018E68
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x0001AC70 File Offset: 0x00018E70
		public eContentType ContentType { get; set; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x0001AC79 File Offset: 0x00018E79
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x0001AC81 File Offset: 0x00018E81
		public eContentSize ContentSize { get; set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0001AC8A File Offset: 0x00018E8A
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x0001AC92 File Offset: 0x00018E92
		public eTabLink TabLink { get; set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0001AC9B File Offset: 0x00018E9B
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x0001ACA3 File Offset: 0x00018EA3
		public bool UseLocalContent { get; set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x0001ACAC File Offset: 0x00018EAC
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x0001ACB4 File Offset: 0x00018EB4
		public string PrimaryAsset { get; set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x0001ACBD File Offset: 0x00018EBD
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x0001ACC5 File Offset: 0x00018EC5
		public string PrimaryText { get; set; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x0001ACCE File Offset: 0x00018ECE
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x0001ACD6 File Offset: 0x00018ED6
		public string SecondaryText { get; set; }

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x0001ACDF File Offset: 0x00018EDF
		// (set) Token: 0x060031F0 RID: 12784 RVA: 0x0001ACE7 File Offset: 0x00018EE7
		public string TargetAsset { get; set; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		public ulong OfferID { get; set; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x0001AD01 File Offset: 0x00018F01
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x0001AD09 File Offset: 0x00018F09
		public uint QuestCurrent { get; set; }

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x0001AD12 File Offset: 0x00018F12
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x0001AD1A File Offset: 0x00018F1A
		public uint QuestMax { get; set; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x0001AD23 File Offset: 0x00018F23
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x0001AD2B File Offset: 0x00018F2B
		public List<string> URLTexts { get; set; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x0001AD34 File Offset: 0x00018F34
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x0001AD3C File Offset: 0x00018F3C
		public List<string> URLImages { get; set; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x0001AD45 File Offset: 0x00018F45
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x0001AD4D File Offset: 0x00018F4D
		public List<string> TargetURLs { get; set; }

		// Token: 0x060031FD RID: 12797 RVA: 0x00104618 File Offset: 0x00102818
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ContentDefinitionID);
			ArrayManager.WriteeContentType(ref newArray, ref newSize, this.ContentType);
			ArrayManager.WriteeContentSize(ref newArray, ref newSize, this.ContentSize);
			ArrayManager.WriteeTabLink(ref newArray, ref newSize, this.TabLink);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.UseLocalContent);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PrimaryAsset);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PrimaryText);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SecondaryText);
			ArrayManager.WriteString(ref newArray, ref newSize, this.TargetAsset);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.QuestCurrent);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.QuestMax);
			ArrayManager.WriteListString(ref newArray, ref newSize, this.URLTexts);
			ArrayManager.WriteListString(ref newArray, ref newSize, this.URLImages);
			ArrayManager.WriteListString(ref newArray, ref newSize, this.TargetURLs);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00104718 File Offset: 0x00102918
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ContentDefinitionID = ArrayManager.ReadUInt64(data, ref num);
			this.ContentType = ArrayManager.ReadeContentType(data, ref num);
			this.ContentSize = ArrayManager.ReadeContentSize(data, ref num);
			this.TabLink = ArrayManager.ReadeTabLink(data, ref num);
			this.UseLocalContent = ArrayManager.ReadBoolean(data, ref num);
			this.PrimaryAsset = ArrayManager.ReadString(data, ref num);
			this.PrimaryText = ArrayManager.ReadString(data, ref num);
			this.SecondaryText = ArrayManager.ReadString(data, ref num);
			this.TargetAsset = ArrayManager.ReadString(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.QuestCurrent = ArrayManager.ReadUInt32(data, ref num);
			this.QuestMax = ArrayManager.ReadUInt32(data, ref num);
			this.URLTexts = ArrayManager.ReadListString(data, ref num);
			this.URLImages = ArrayManager.ReadListString(data, ref num);
			this.TargetURLs = ArrayManager.ReadListString(data, ref num);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x001047FC File Offset: 0x001029FC
		private void InitRefTypes()
		{
			this.ContentDefinitionID = 0UL;
			this.ContentType = eContentType.TextBlock;
			this.ContentSize = eContentSize.Small;
			this.TabLink = eTabLink.None;
			this.UseLocalContent = false;
			this.PrimaryAsset = string.Empty;
			this.PrimaryText = string.Empty;
			this.SecondaryText = string.Empty;
			this.TargetAsset = string.Empty;
			this.OfferID = 0UL;
			this.QuestCurrent = 0u;
			this.QuestMax = 0u;
			this.URLTexts = new List<string>();
			this.URLImages = new List<string>();
			this.TargetURLs = new List<string>();
		}
	}
}
