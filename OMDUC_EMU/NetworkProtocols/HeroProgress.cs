using System;

namespace NetworkProtocols
{
	// Token: 0x020004E4 RID: 1252
	public class HeroProgress
	{
		// Token: 0x06002B5E RID: 11102 RVA: 0x00016E35 File Offset: 0x00015035
		public HeroProgress()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x00016E43 File Offset: 0x00015043
		// (set) Token: 0x06002B60 RID: 11104 RVA: 0x00016E4B File Offset: 0x0001504B
		public ulong HeroGUID { get; set; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x00016E54 File Offset: 0x00015054
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x00016E5C File Offset: 0x0001505C
		public uint CurrentExp { get; set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x00016E65 File Offset: 0x00015065
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x00016E6D File Offset: 0x0001506D
		public uint ExpToNextLevel { get; set; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x00016E76 File Offset: 0x00015076
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x00016E7E File Offset: 0x0001507E
		public HeroProgressAward AwardItem { get; set; }

		// Token: 0x06002B67 RID: 11111 RVA: 0x000FC838 File Offset: 0x000FAA38
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.CurrentExp);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ExpToNextLevel);
			ArrayManager.WriteHeroProgressAward(ref newArray, ref newSize, this.AwardItem);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000FC894 File Offset: 0x000FAA94
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.CurrentExp = ArrayManager.ReadUInt32(data, ref num);
			this.ExpToNextLevel = ArrayManager.ReadUInt32(data, ref num);
			this.AwardItem = ArrayManager.ReadHeroProgressAward(data, ref num);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00016E87 File Offset: 0x00015087
		private void InitRefTypes()
		{
			this.HeroGUID = 0UL;
			this.CurrentExp = 0u;
			this.ExpToNextLevel = 0u;
			this.AwardItem = new HeroProgressAward();
		}
	}
}
