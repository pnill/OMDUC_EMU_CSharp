using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000578 RID: 1400
	public class PlayerHeroStats
	{
		// Token: 0x0600300F RID: 12303 RVA: 0x0001991E File Offset: 0x00017B1E
		public PlayerHeroStats()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x0001992C File Offset: 0x00017B2C
		// (set) Token: 0x06003011 RID: 12305 RVA: 0x00019934 File Offset: 0x00017B34
		public ulong HeroCardGUID { get; set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x0001993D File Offset: 0x00017B3D
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x00019945 File Offset: 0x00017B45
		public ulong Win { get; set; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x0001994E File Offset: 0x00017B4E
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00019956 File Offset: 0x00017B56
		public ulong Games { get; set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x0001995F File Offset: 0x00017B5F
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00019967 File Offset: 0x00017B67
		public ulong PlayerKills { get; set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x00019970 File Offset: 0x00017B70
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00019978 File Offset: 0x00017B78
		public ulong PlayerDeaths { get; set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x00019981 File Offset: 0x00017B81
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x00019989 File Offset: 0x00017B89
		public ulong MinionKills { get; set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x00019992 File Offset: 0x00017B92
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x0001999A File Offset: 0x00017B9A
		public ulong AssistKills { get; set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000199A3 File Offset: 0x00017BA3
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x000199AB File Offset: 0x00017BAB
		public ulong SelectedSkinGUID { get; set; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x000199B4 File Offset: 0x00017BB4
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x000199BC File Offset: 0x00017BBC
		public ulong SelectedHeroicDyeID { get; set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000199C5 File Offset: 0x00017BC5
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x000199CD File Offset: 0x00017BCD
		public uint Level { get; set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x000199D6 File Offset: 0x00017BD6
		// (set) Token: 0x06003025 RID: 12325 RVA: 0x000199DE File Offset: 0x00017BDE
		public uint ExperiencePoints { get; set; }

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x000199E7 File Offset: 0x00017BE7
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x000199EF File Offset: 0x00017BEF
		public List<PlayerHeroMapStat> MapStats { get; set; }

		// Token: 0x06003028 RID: 12328 RVA: 0x00101D2C File Offset: 0x000FFF2C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroCardGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Win);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Games);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerKills);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerDeaths);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MinionKills);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AssistKills);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedSkinGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedHeroicDyeID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ExperiencePoints);
			ArrayManager.WriteListPlayerHeroMapStat(ref newArray, ref newSize, this.MapStats);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x00101E00 File Offset: 0x00100000
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.HeroCardGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Win = ArrayManager.ReadUInt64(data, ref num);
			this.Games = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerKills = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerDeaths = ArrayManager.ReadUInt64(data, ref num);
			this.MinionKills = ArrayManager.ReadUInt64(data, ref num);
			this.AssistKills = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedSkinGUID = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedHeroicDyeID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.ExperiencePoints = ArrayManager.ReadUInt32(data, ref num);
			this.MapStats = ArrayManager.ReadListPlayerHeroMapStat(data, ref num);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x00101EB8 File Offset: 0x001000B8
		private void InitRefTypes()
		{
			this.HeroCardGUID = 0UL;
			this.Win = 0UL;
			this.Games = 0UL;
			this.PlayerKills = 0UL;
			this.PlayerDeaths = 0UL;
			this.MinionKills = 0UL;
			this.AssistKills = 0UL;
			this.SelectedSkinGUID = 0UL;
			this.SelectedHeroicDyeID = 0UL;
			this.Level = 0u;
			this.ExperiencePoints = 0u;
			this.MapStats = new List<PlayerHeroMapStat>();
		}
	}
}
