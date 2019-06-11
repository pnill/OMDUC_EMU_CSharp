using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200063C RID: 1596
	public class PacketCampaignMission
	{
		// Token: 0x06003784 RID: 14212 RVA: 0x0001E736 File Offset: 0x0001C936
		public PacketCampaignMission()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x0001E744 File Offset: 0x0001C944
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x0001E74C File Offset: 0x0001C94C
		public string NameLocKey { get; set; }

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0001E755 File Offset: 0x0001C955
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x0001E75D File Offset: 0x0001C95D
		public ulong MissionID { get; set; }

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x0001E766 File Offset: 0x0001C966
		// (set) Token: 0x0600378A RID: 14218 RVA: 0x0001E76E File Offset: 0x0001C96E
		public ulong GameMapID { get; set; }

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x0001E777 File Offset: 0x0001C977
		// (set) Token: 0x0600378C RID: 14220 RVA: 0x0001E77F File Offset: 0x0001C97F
		public eGameType GameType { get; set; }

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x0001E788 File Offset: 0x0001C988
		// (set) Token: 0x0600378E RID: 14222 RVA: 0x0001E790 File Offset: 0x0001C990
		public bool StarsAvailable { get; set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x0001E799 File Offset: 0x0001C999
		// (set) Token: 0x06003790 RID: 14224 RVA: 0x0001E7A1 File Offset: 0x0001C9A1
		public ulong HeroGUID { get; set; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x0001E7AA File Offset: 0x0001C9AA
		// (set) Token: 0x06003792 RID: 14226 RVA: 0x0001E7B2 File Offset: 0x0001C9B2
		public ulong PrerequisiteMissionID { get; set; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x0001E7BB File Offset: 0x0001C9BB
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x0001E7C3 File Offset: 0x0001C9C3
		public List<PacketDeckContents> MissionDecks { get; set; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x0001E7CC File Offset: 0x0001C9CC
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		public List<ulong> CraftableItems { get; set; }

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x0001E7DD File Offset: 0x0001C9DD
		// (set) Token: 0x06003798 RID: 14232 RVA: 0x0001E7E5 File Offset: 0x0001C9E5
		public List<BaseAwardItem> MissionAwards { get; set; }

		// Token: 0x06003799 RID: 14233 RVA: 0x0010C998 File Offset: 0x0010AB98
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.NameLocKey);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MissionID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.StarsAvailable);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PrerequisiteMissionID);
			ArrayManager.WriteListPacketDeckContents(ref newArray, ref newSize, this.MissionDecks);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.CraftableItems);
			ArrayManager.WriteListBaseAwardItem(ref newArray, ref newSize, this.MissionAwards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0010CA4C File Offset: 0x0010AC4C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.NameLocKey = ArrayManager.ReadString(data, ref num);
			this.MissionID = ArrayManager.ReadUInt64(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.StarsAvailable = ArrayManager.ReadBoolean(data, ref num);
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.PrerequisiteMissionID = ArrayManager.ReadUInt64(data, ref num);
			this.MissionDecks = ArrayManager.ReadListPacketDeckContents(data, ref num);
			this.CraftableItems = ArrayManager.ReadListUInt64(data, ref num);
			this.MissionAwards = ArrayManager.ReadListBaseAwardItem(data, ref num);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0010CAE8 File Offset: 0x0010ACE8
		private void InitRefTypes()
		{
			this.NameLocKey = string.Empty;
			this.MissionID = 0UL;
			this.GameMapID = 0UL;
			this.GameType = eGameType.None;
			this.StarsAvailable = false;
			this.HeroGUID = 0UL;
			this.PrerequisiteMissionID = 0UL;
			this.MissionDecks = new List<PacketDeckContents>();
			this.CraftableItems = new List<ulong>();
			this.MissionAwards = new List<BaseAwardItem>();
		}
	}
}
