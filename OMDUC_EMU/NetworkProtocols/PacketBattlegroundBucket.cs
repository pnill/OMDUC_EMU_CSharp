using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200063F RID: 1599
	public class PacketBattlegroundBucket
	{
		// Token: 0x060037AF RID: 14255 RVA: 0x0001E8C9 File Offset: 0x0001CAC9
		public PacketBattlegroundBucket()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x0001E8D7 File Offset: 0x0001CAD7
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x0001E8DF File Offset: 0x0001CADF
		public ulong BucketID { get; set; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		// (set) Token: 0x060037B3 RID: 14259 RVA: 0x0001E8F0 File Offset: 0x0001CAF0
		public ulong AnimaticDefinitionID { get; set; }

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x0001E8F9 File Offset: 0x0001CAF9
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x0001E901 File Offset: 0x0001CB01
		public string NameLocKey { get; set; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x0001E90A File Offset: 0x0001CB0A
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x0001E912 File Offset: 0x0001CB12
		public string DescriptionLocKey { get; set; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x0001E91B File Offset: 0x0001CB1B
		// (set) Token: 0x060037B9 RID: 14265 RVA: 0x0001E923 File Offset: 0x0001CB23
		public string SpriteName { get; set; }

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x0001E92C File Offset: 0x0001CB2C
		// (set) Token: 0x060037BB RID: 14267 RVA: 0x0001E934 File Offset: 0x0001CB34
		public ulong EventChestGUID { get; set; }

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0001E93D File Offset: 0x0001CB3D
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x0001E945 File Offset: 0x0001CB45
		public ulong HeroEventChestGUID { get; set; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0001E94E File Offset: 0x0001CB4E
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x0001E956 File Offset: 0x0001CB56
		public uint LevelRequired { get; set; }

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x0001E95F File Offset: 0x0001CB5F
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x0001E967 File Offset: 0x0001CB67
		public ulong PrerequisiteBucketID { get; set; }

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x0001E970 File Offset: 0x0001CB70
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x0001E978 File Offset: 0x0001CB78
		public eMatchmakingType MatchmakingType { get; set; }

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0001E981 File Offset: 0x0001CB81
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x0001E989 File Offset: 0x0001CB89
		public List<ulong> GameMaps { get; set; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0001E992 File Offset: 0x0001CB92
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0001E99A File Offset: 0x0001CB9A
		public string SuggestedLevelRangeLocKey { get; set; }

		// Token: 0x060037C8 RID: 14280 RVA: 0x0010CCDC File Offset: 0x0010AEDC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BucketID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AnimaticDefinitionID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.NameLocKey);
			ArrayManager.WriteString(ref newArray, ref newSize, this.DescriptionLocKey);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SpriteName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EventChestGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroEventChestGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.LevelRequired);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PrerequisiteBucketID);
			ArrayManager.WriteeMatchmakingType(ref newArray, ref newSize, this.MatchmakingType);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.GameMaps);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SuggestedLevelRangeLocKey);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x0010CDB0 File Offset: 0x0010AFB0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.AnimaticDefinitionID = ArrayManager.ReadUInt64(data, ref num);
			this.NameLocKey = ArrayManager.ReadString(data, ref num);
			this.DescriptionLocKey = ArrayManager.ReadString(data, ref num);
			this.SpriteName = ArrayManager.ReadString(data, ref num);
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.HeroEventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.LevelRequired = ArrayManager.ReadUInt32(data, ref num);
			this.PrerequisiteBucketID = ArrayManager.ReadUInt64(data, ref num);
			this.MatchmakingType = ArrayManager.ReadeMatchmakingType(data, ref num);
			this.GameMaps = ArrayManager.ReadListUInt64(data, ref num);
			this.SuggestedLevelRangeLocKey = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x0010CE68 File Offset: 0x0010B068
		private void InitRefTypes()
		{
			this.BucketID = 0UL;
			this.AnimaticDefinitionID = 0UL;
			this.NameLocKey = string.Empty;
			this.DescriptionLocKey = string.Empty;
			this.SpriteName = string.Empty;
			this.EventChestGUID = 0UL;
			this.HeroEventChestGUID = 0UL;
			this.LevelRequired = 0u;
			this.PrerequisiteBucketID = 0UL;
			this.MatchmakingType = eMatchmakingType.None;
			this.GameMaps = new List<ulong>();
			this.SuggestedLevelRangeLocKey = string.Empty;
		}
	}
}
