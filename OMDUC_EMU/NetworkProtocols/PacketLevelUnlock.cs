using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005A7 RID: 1447
	public class PacketLevelUnlock
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x0001B120 File Offset: 0x00019320
		public PacketLevelUnlock()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x0001B12E File Offset: 0x0001932E
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x0001B136 File Offset: 0x00019336
		public ushort PlayerLevel { get; set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x0001B13F File Offset: 0x0001933F
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x0001B147 File Offset: 0x00019347
		public string Title { get; set; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x0001B150 File Offset: 0x00019350
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x0001B158 File Offset: 0x00019358
		public eGameType AllowedGameType { get; set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x0001B161 File Offset: 0x00019361
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x0001B169 File Offset: 0x00019369
		public eGameType DefaultGameType { get; set; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x0001B172 File Offset: 0x00019372
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x0001B17A File Offset: 0x0001937A
		public string Description { get; set; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x0001B183 File Offset: 0x00019383
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x0001B18B File Offset: 0x0001938B
		public string Portrait { get; set; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x0001B194 File Offset: 0x00019394
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x0001B19C File Offset: 0x0001939C
		public uint MaxTraitSlots { get; set; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x0001B1A5 File Offset: 0x000193A5
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x0001B1AD File Offset: 0x000193AD
		public BaseAwardItem PlayerAward { get; set; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x0001B1B6 File Offset: 0x000193B6
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x0001B1BE File Offset: 0x000193BE
		public List<PacketUnlockedCraftRecipe> UnlockedCraftRecipes { get; set; }

		// Token: 0x06003263 RID: 12899 RVA: 0x00105014 File Offset: 0x00103214
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt16(ref newArray, ref newSize, this.PlayerLevel);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.AllowedGameType);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.DefaultGameType);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Portrait);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MaxTraitSlots);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.PlayerAward);
			ArrayManager.WriteListPacketUnlockedCraftRecipe(ref newArray, ref newSize, this.UnlockedCraftRecipes);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x001050BC File Offset: 0x001032BC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.PlayerLevel = ArrayManager.ReadUInt16(data, ref num);
			this.Title = ArrayManager.ReadString(data, ref num);
			this.AllowedGameType = ArrayManager.ReadeGameType(data, ref num);
			this.DefaultGameType = ArrayManager.ReadeGameType(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
			this.Portrait = ArrayManager.ReadString(data, ref num);
			this.MaxTraitSlots = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerAward = ArrayManager.ReadBaseAwardItem(data, ref num);
			this.UnlockedCraftRecipes = ArrayManager.ReadListPacketUnlockedCraftRecipe(data, ref num);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x0010514C File Offset: 0x0010334C
		private void InitRefTypes()
		{
			this.PlayerLevel = 0;
			this.Title = string.Empty;
			this.AllowedGameType = eGameType.None;
			this.DefaultGameType = eGameType.None;
			this.Description = string.Empty;
			this.Portrait = string.Empty;
			this.MaxTraitSlots = 0u;
			this.PlayerAward = new BaseAwardItem();
			this.UnlockedCraftRecipes = new List<PacketUnlockedCraftRecipe>();
		}
	}
}
