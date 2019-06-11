using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006B4 RID: 1716
	public class DataTeamStats
	{
		// Token: 0x06003CBA RID: 15546 RVA: 0x0002201E File Offset: 0x0002021E
		public DataTeamStats()
		{
			this.InitRefTypes();
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x0002202C File Offset: 0x0002022C
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x00022034 File Offset: 0x00020234
		public uint PlayerKills { get; set; }

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0002203D File Offset: 0x0002023D
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x00022045 File Offset: 0x00020245
		public uint MinionKills { get; set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x0002204E File Offset: 0x0002024E
		// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x00022056 File Offset: 0x00020256
		public uint PlayerDeaths { get; set; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x0002205F File Offset: 0x0002025F
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x00022067 File Offset: 0x00020267
		public uint WarCampsOpened { get; set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x00022070 File Offset: 0x00020270
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x00022078 File Offset: 0x00020278
		public uint RemainingRiftPoints { get; set; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00022081 File Offset: 0x00020281
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x00022089 File Offset: 0x00020289
		public uint Leadership { get; set; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00022092 File Offset: 0x00020292
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x0002209A File Offset: 0x0002029A
		public uint TrapMoneyEarned { get; set; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x000220A3 File Offset: 0x000202A3
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x000220AB File Offset: 0x000202AB
		public uint MinionsSpawned { get; set; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x000220B4 File Offset: 0x000202B4
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x000220BC File Offset: 0x000202BC
		public uint LaneBossesKilled { get; set; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x000220C5 File Offset: 0x000202C5
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x000220CD File Offset: 0x000202CD
		public bool IsWinner { get; set; }

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x000220D6 File Offset: 0x000202D6
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x000220DE File Offset: 0x000202DE
		public List<DataPlayerStats> PlayerStats { get; set; }

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x000220E7 File Offset: 0x000202E7
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x000220EF File Offset: 0x000202EF
		public int ComboCoinEarned { get; set; }

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x000220F8 File Offset: 0x000202F8
		// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x00022100 File Offset: 0x00020300
		public uint TeamContributionScore { get; set; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x00022109 File Offset: 0x00020309
		// (set) Token: 0x06003CD6 RID: 15574 RVA: 0x00022111 File Offset: 0x00020311
		public int TeamEscortXPEarned { get; set; }

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x0002211A File Offset: 0x0002031A
		// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x00022122 File Offset: 0x00020322
		public int TeamPillageXPEarned { get; set; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x0002212B File Offset: 0x0002032B
		// (set) Token: 0x06003CDA RID: 15578 RVA: 0x00022133 File Offset: 0x00020333
		public int TeamBossesPlayed { get; set; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x0002213C File Offset: 0x0002033C
		// (set) Token: 0x06003CDC RID: 15580 RVA: 0x00022144 File Offset: 0x00020344
		public int TeamGlyphsPlaced { get; set; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x0002214D File Offset: 0x0002034D
		// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00022155 File Offset: 0x00020355
		public int TotalAssists { get; set; }

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x0002215E File Offset: 0x0002035E
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x00022166 File Offset: 0x00020366
		public int TeamCoinEarned { get; set; }

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x0002216F File Offset: 0x0002036F
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x00022177 File Offset: 0x00020377
		public int TeamTrapKills { get; set; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x00022180 File Offset: 0x00020380
		// (set) Token: 0x06003CE4 RID: 15588 RVA: 0x00022188 File Offset: 0x00020388
		public int TeamBestCombo { get; set; }

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x00022191 File Offset: 0x00020391
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x00022199 File Offset: 0x00020399
		public int TeamMinionPortalEscortXPEarned { get; set; }

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x000221A2 File Offset: 0x000203A2
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x000221AA File Offset: 0x000203AA
		public int TeamMinionPortalPillageXPEarned { get; set; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x000221B3 File Offset: 0x000203B3
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x000221BB File Offset: 0x000203BB
		public int TeamCombosEarned { get; set; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x000221C4 File Offset: 0x000203C4
		// (set) Token: 0x06003CEC RID: 15596 RVA: 0x000221CC File Offset: 0x000203CC
		public bool IsKeystoneGame { get; set; }

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x000221D5 File Offset: 0x000203D5
		// (set) Token: 0x06003CEE RID: 15598 RVA: 0x000221DD File Offset: 0x000203DD
		public KeystoneDetailPacket TeamKeystoneInfo { get; set; }

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x000221E6 File Offset: 0x000203E6
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x000221EE File Offset: 0x000203EE
		public List<BaseAwardEntry> TeamKeystoneAwards { get; set; }

		// Token: 0x06003CF1 RID: 15601 RVA: 0x001145FC File Offset: 0x001127FC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerKills);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MinionKills);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerDeaths);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.WarCampsOpened);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.RemainingRiftPoints);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Leadership);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TrapMoneyEarned);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MinionsSpawned);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.LaneBossesKilled);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsWinner);
			ArrayManager.WriteListDataPlayerStats(ref newArray, ref newSize, this.PlayerStats);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.ComboCoinEarned);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TeamContributionScore);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamEscortXPEarned);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamPillageXPEarned);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamBossesPlayed);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamGlyphsPlaced);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TotalAssists);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamCoinEarned);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamTrapKills);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamBestCombo);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamMinionPortalEscortXPEarned);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamMinionPortalPillageXPEarned);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.TeamCombosEarned);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsKeystoneGame);
			ArrayManager.WriteKeystoneDetailPacket(ref newArray, ref newSize, this.TeamKeystoneInfo);
			ArrayManager.WriteListBaseAwardEntry(ref newArray, ref newSize, this.TeamKeystoneAwards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x001147B0 File Offset: 0x001129B0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.PlayerKills = ArrayManager.ReadUInt32(data, ref num);
			this.MinionKills = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerDeaths = ArrayManager.ReadUInt32(data, ref num);
			this.WarCampsOpened = ArrayManager.ReadUInt32(data, ref num);
			this.RemainingRiftPoints = ArrayManager.ReadUInt32(data, ref num);
			this.Leadership = ArrayManager.ReadUInt32(data, ref num);
			this.TrapMoneyEarned = ArrayManager.ReadUInt32(data, ref num);
			this.MinionsSpawned = ArrayManager.ReadUInt32(data, ref num);
			this.LaneBossesKilled = ArrayManager.ReadUInt32(data, ref num);
			this.IsWinner = ArrayManager.ReadBoolean(data, ref num);
			this.PlayerStats = ArrayManager.ReadListDataPlayerStats(data, ref num);
			this.ComboCoinEarned = ArrayManager.ReadInt32(data, ref num);
			this.TeamContributionScore = ArrayManager.ReadUInt32(data, ref num);
			this.TeamEscortXPEarned = ArrayManager.ReadInt32(data, ref num);
			this.TeamPillageXPEarned = ArrayManager.ReadInt32(data, ref num);
			this.TeamBossesPlayed = ArrayManager.ReadInt32(data, ref num);
			this.TeamGlyphsPlaced = ArrayManager.ReadInt32(data, ref num);
			this.TotalAssists = ArrayManager.ReadInt32(data, ref num);
			this.TeamCoinEarned = ArrayManager.ReadInt32(data, ref num);
			this.TeamTrapKills = ArrayManager.ReadInt32(data, ref num);
			this.TeamBestCombo = ArrayManager.ReadInt32(data, ref num);
			this.TeamMinionPortalEscortXPEarned = ArrayManager.ReadInt32(data, ref num);
			this.TeamMinionPortalPillageXPEarned = ArrayManager.ReadInt32(data, ref num);
			this.TeamCombosEarned = ArrayManager.ReadInt32(data, ref num);
			this.IsKeystoneGame = ArrayManager.ReadBoolean(data, ref num);
			this.TeamKeystoneInfo = ArrayManager.ReadKeystoneDetailPacket(data, ref num);
			this.TeamKeystoneAwards = ArrayManager.ReadListBaseAwardEntry(data, ref num);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x0011493C File Offset: 0x00112B3C
		private void InitRefTypes()
		{
			this.PlayerKills = 0u;
			this.MinionKills = 0u;
			this.PlayerDeaths = 0u;
			this.WarCampsOpened = 0u;
			this.RemainingRiftPoints = 0u;
			this.Leadership = 0u;
			this.TrapMoneyEarned = 0u;
			this.MinionsSpawned = 0u;
			this.LaneBossesKilled = 0u;
			this.IsWinner = false;
			this.PlayerStats = new List<DataPlayerStats>();
			this.ComboCoinEarned = 0;
			this.TeamContributionScore = 0u;
			this.TeamEscortXPEarned = 0;
			this.TeamPillageXPEarned = 0;
			this.TeamBossesPlayed = 0;
			this.TeamGlyphsPlaced = 0;
			this.TotalAssists = 0;
			this.TeamCoinEarned = 0;
			this.TeamTrapKills = 0;
			this.TeamBestCombo = 0;
			this.TeamMinionPortalEscortXPEarned = 0;
			this.TeamMinionPortalPillageXPEarned = 0;
			this.TeamCombosEarned = 0;
			this.IsKeystoneGame = false;
			this.TeamKeystoneInfo = new KeystoneDetailPacket();
			this.TeamKeystoneAwards = new List<BaseAwardEntry>();
		}
	}
}
