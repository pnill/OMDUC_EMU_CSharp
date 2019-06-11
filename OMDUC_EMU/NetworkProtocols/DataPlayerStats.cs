using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006B5 RID: 1717
	public class DataPlayerStats
	{
		// Token: 0x06003CF4 RID: 15604 RVA: 0x000221F7 File Offset: 0x000203F7
		public DataPlayerStats()
		{
			this.InitRefTypes();
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x00022205 File Offset: 0x00020405
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x0002220D File Offset: 0x0002040D
		public string Name { get; set; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00022216 File Offset: 0x00020416
		// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x0002221E File Offset: 0x0002041E
		public ulong GuildID { get; set; }

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x00022227 File Offset: 0x00020427
		// (set) Token: 0x06003CFA RID: 15610 RVA: 0x0002222F File Offset: 0x0002042F
		public string GuildTag { get; set; }

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x00022238 File Offset: 0x00020438
		// (set) Token: 0x06003CFC RID: 15612 RVA: 0x00022240 File Offset: 0x00020440
		public string GuildName { get; set; }

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x00022249 File Offset: 0x00020449
		// (set) Token: 0x06003CFE RID: 15614 RVA: 0x00022251 File Offset: 0x00020451
		public string Class { get; set; }

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x0002225A File Offset: 0x0002045A
		// (set) Token: 0x06003D00 RID: 15616 RVA: 0x00022262 File Offset: 0x00020462
		public string ComputerName { get; set; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x0002226B File Offset: 0x0002046B
		// (set) Token: 0x06003D02 RID: 15618 RVA: 0x00022273 File Offset: 0x00020473
		public uint PlayerID { get; set; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x0002227C File Offset: 0x0002047C
		// (set) Token: 0x06003D04 RID: 15620 RVA: 0x00022284 File Offset: 0x00020484
		public uint PlayerKills { get; set; }

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x0002228D File Offset: 0x0002048D
		// (set) Token: 0x06003D06 RID: 15622 RVA: 0x00022295 File Offset: 0x00020495
		public uint PlayerDeaths { get; set; }

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0002229E File Offset: 0x0002049E
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x000222A6 File Offset: 0x000204A6
		public uint MinionKills { get; set; }

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x000222AF File Offset: 0x000204AF
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x000222B7 File Offset: 0x000204B7
		public uint Score { get; set; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x000222C0 File Offset: 0x000204C0
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x000222C8 File Offset: 0x000204C8
		public uint TrapsBuilt { get; set; }

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x000222D1 File Offset: 0x000204D1
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x000222D9 File Offset: 0x000204D9
		public uint TrapsSold { get; set; }

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x000222E2 File Offset: 0x000204E2
		// (set) Token: 0x06003D10 RID: 15632 RVA: 0x000222EA File Offset: 0x000204EA
		public uint RiftsOpened { get; set; }

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x000222F3 File Offset: 0x000204F3
		// (set) Token: 0x06003D12 RID: 15634 RVA: 0x000222FB File Offset: 0x000204FB
		public uint RiftPointsTaken { get; set; }

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06003D13 RID: 15635 RVA: 0x00022304 File Offset: 0x00020504
		// (set) Token: 0x06003D14 RID: 15636 RVA: 0x0002230C File Offset: 0x0002050C
		public uint WaveSent { get; set; }

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x00022315 File Offset: 0x00020515
		// (set) Token: 0x06003D16 RID: 15638 RVA: 0x0002231D File Offset: 0x0002051D
		public uint ShotsFired { get; set; }

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00022326 File Offset: 0x00020526
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x0002232E File Offset: 0x0002052E
		public uint ShotsHit { get; set; }

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00022337 File Offset: 0x00020537
		// (set) Token: 0x06003D1A RID: 15642 RVA: 0x0002233F File Offset: 0x0002053F
		public uint MeleeSwings { get; set; }

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x00022348 File Offset: 0x00020548
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x00022350 File Offset: 0x00020550
		public uint MeleeHits { get; set; }

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x00022359 File Offset: 0x00020559
		// (set) Token: 0x06003D1E RID: 15646 RVA: 0x00022361 File Offset: 0x00020561
		public uint DamageDealtPlayers { get; set; }

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x0002236A File Offset: 0x0002056A
		// (set) Token: 0x06003D20 RID: 15648 RVA: 0x00022372 File Offset: 0x00020572
		public uint DamageDealtMobs { get; set; }

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x0002237B File Offset: 0x0002057B
		// (set) Token: 0x06003D22 RID: 15650 RVA: 0x00022383 File Offset: 0x00020583
		public uint TotalDamageDealt { get; set; }

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003D23 RID: 15651 RVA: 0x0002238C File Offset: 0x0002058C
		// (set) Token: 0x06003D24 RID: 15652 RVA: 0x00022394 File Offset: 0x00020594
		public uint ActualDamageDealtPlayers { get; set; }

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x0002239D File Offset: 0x0002059D
		// (set) Token: 0x06003D26 RID: 15654 RVA: 0x000223A5 File Offset: 0x000205A5
		public uint ActualDamageDealtMobs { get; set; }

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x000223AE File Offset: 0x000205AE
		// (set) Token: 0x06003D28 RID: 15656 RVA: 0x000223B6 File Offset: 0x000205B6
		public uint ActualTotalDamageDealt { get; set; }

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x000223BF File Offset: 0x000205BF
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x000223C7 File Offset: 0x000205C7
		public uint DamageMitigated { get; set; }

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x000223D0 File Offset: 0x000205D0
		// (set) Token: 0x06003D2C RID: 15660 RVA: 0x000223D8 File Offset: 0x000205D8
		public uint PrimaryAbilityUsed { get; set; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x000223E1 File Offset: 0x000205E1
		// (set) Token: 0x06003D2E RID: 15662 RVA: 0x000223E9 File Offset: 0x000205E9
		public uint SecondaryAbilityUsed { get; set; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x000223F2 File Offset: 0x000205F2
		// (set) Token: 0x06003D30 RID: 15664 RVA: 0x000223FA File Offset: 0x000205FA
		public uint SoftCurrencyWon { get; set; }

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x00022403 File Offset: 0x00020603
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x0002240B File Offset: 0x0002060B
		public uint ExperiencePointsGained { get; set; }

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x00022414 File Offset: 0x00020614
		// (set) Token: 0x06003D34 RID: 15668 RVA: 0x0002241C File Offset: 0x0002061C
		public bool IsBot { get; set; }

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x00022425 File Offset: 0x00020625
		// (set) Token: 0x06003D36 RID: 15670 RVA: 0x0002242D File Offset: 0x0002062D
		public ulong CharacterGUID { get; set; }

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x00022436 File Offset: 0x00020636
		// (set) Token: 0x06003D38 RID: 15672 RVA: 0x0002243E File Offset: 0x0002063E
		public uint PlayerBestCombo { get; set; }

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00022447 File Offset: 0x00020647
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x0002244F File Offset: 0x0002064F
		public uint GlyphsBuilt { get; set; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x00022458 File Offset: 0x00020658
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x00022460 File Offset: 0x00020660
		public uint GlyphsSold { get; set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x00022469 File Offset: 0x00020669
		// (set) Token: 0x06003D3E RID: 15678 RVA: 0x00022471 File Offset: 0x00020671
		public uint PeakGlyphs { get; set; }

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x0002247A File Offset: 0x0002067A
		// (set) Token: 0x06003D40 RID: 15680 RVA: 0x00022482 File Offset: 0x00020682
		public uint Assists { get; set; }

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x0002248B File Offset: 0x0002068B
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00022493 File Offset: 0x00020693
		public uint TrapKills { get; set; }

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x0002249C File Offset: 0x0002069C
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x000224A4 File Offset: 0x000206A4
		public uint CoinEarned { get; set; }

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x000224AD File Offset: 0x000206AD
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x000224B5 File Offset: 0x000206B5
		public uint CoinSpent { get; set; }

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x000224BE File Offset: 0x000206BE
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x000224C6 File Offset: 0x000206C6
		public uint ComboCoinEarned { get; set; }

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x000224CF File Offset: 0x000206CF
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x000224D7 File Offset: 0x000206D7
		public uint PlayerSiegeDamage { get; set; }

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x000224E0 File Offset: 0x000206E0
		// (set) Token: 0x06003D4C RID: 15692 RVA: 0x000224E8 File Offset: 0x000206E8
		public uint PillageMinionPortalXP { get; set; }

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x000224F1 File Offset: 0x000206F1
		// (set) Token: 0x06003D4E RID: 15694 RVA: 0x000224F9 File Offset: 0x000206F9
		public uint EscortMinionPortalXP { get; set; }

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x00022502 File Offset: 0x00020702
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x0002250A File Offset: 0x0002070A
		public uint PlayerLevel { get; set; }

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x00022513 File Offset: 0x00020713
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x0002251B File Offset: 0x0002071B
		public uint PlayerTrapDamage { get; set; }

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x00022524 File Offset: 0x00020724
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x0002252C File Offset: 0x0002072C
		public uint PlayerCombos { get; set; }

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x00022535 File Offset: 0x00020735
		// (set) Token: 0x06003D56 RID: 15702 RVA: 0x0002253D File Offset: 0x0002073D
		public uint PlayerHealingDone { get; set; }

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x00022546 File Offset: 0x00020746
		// (set) Token: 0x06003D58 RID: 15704 RVA: 0x0002254E File Offset: 0x0002074E
		public uint PlayerBattleLevel { get; set; }

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x00022557 File Offset: 0x00020757
		// (set) Token: 0x06003D5A RID: 15706 RVA: 0x0002255F File Offset: 0x0002075F
		public uint PlayerDamageTakenActual { get; set; }

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00022568 File Offset: 0x00020768
		// (set) Token: 0x06003D5C RID: 15708 RVA: 0x00022570 File Offset: 0x00020770
		public uint PlayerDamageTaken { get; set; }

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x00022579 File Offset: 0x00020779
		// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00022581 File Offset: 0x00020781
		public uint SabotagePlayerMinionDamageToPlayers { get; set; }

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x0002258A File Offset: 0x0002078A
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00022592 File Offset: 0x00020792
		public uint SabotagePlayerMinionDamageToTraps { get; set; }

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x0002259B File Offset: 0x0002079B
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x000225A3 File Offset: 0x000207A3
		public uint SabotagePlayerMinionDamageToGuardians { get; set; }

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x000225AC File Offset: 0x000207AC
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x000225B4 File Offset: 0x000207B4
		public uint SabotagePlayerMinionRiftPointsScored { get; set; }

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x000225BD File Offset: 0x000207BD
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x000225C5 File Offset: 0x000207C5
		public List<PlayerBoostStatus> PlayerBoosts { get; set; }

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x000225CE File Offset: 0x000207CE
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x000225D6 File Offset: 0x000207D6
		public double KillScore { get; set; }

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x000225DF File Offset: 0x000207DF
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x000225E7 File Offset: 0x000207E7
		public double WaveBonusScoreMultiplier { get; set; }

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x000225F0 File Offset: 0x000207F0
		// (set) Token: 0x06003D6C RID: 15724 RVA: 0x000225F8 File Offset: 0x000207F8
		public double ComboBonusScore { get; set; }

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06003D6D RID: 15725 RVA: 0x00022601 File Offset: 0x00020801
		// (set) Token: 0x06003D6E RID: 15726 RVA: 0x00022609 File Offset: 0x00020809
		public double HeroSurvivalBonusScoreMultiplier { get; set; }

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x00022612 File Offset: 0x00020812
		// (set) Token: 0x06003D70 RID: 15728 RVA: 0x0002261A File Offset: 0x0002081A
		public double RiftPointBonusScoreMultiplier { get; set; }

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x00022623 File Offset: 0x00020823
		// (set) Token: 0x06003D72 RID: 15730 RVA: 0x0002262B File Offset: 0x0002082B
		public double TimeBonusScoreMultiplier { get; set; }

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06003D73 RID: 15731 RVA: 0x00022634 File Offset: 0x00020834
		// (set) Token: 0x06003D74 RID: 15732 RVA: 0x0002263C File Offset: 0x0002083C
		public ulong SelectedBadge { get; set; }

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x00022645 File Offset: 0x00020845
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x0002264D File Offset: 0x0002084D
		public ulong SelectedAvatar { get; set; }

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x00022656 File Offset: 0x00020856
		// (set) Token: 0x06003D78 RID: 15736 RVA: 0x0002265E File Offset: 0x0002085E
		public ulong SelectedBackground { get; set; }

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00022667 File Offset: 0x00020867
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x0002266F File Offset: 0x0002086F
		public ulong SelectedTitle { get; set; }

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x00022678 File Offset: 0x00020878
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x00022680 File Offset: 0x00020880
		public ulong SelectedPlayerSkin { get; set; }

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x00022689 File Offset: 0x00020889
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x00022691 File Offset: 0x00020891
		public bool MostDamageTaken { get; set; }

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x0002269A File Offset: 0x0002089A
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x000226A2 File Offset: 0x000208A2
		public bool MostDamageCaused { get; set; }

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x000226AB File Offset: 0x000208AB
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x000226B3 File Offset: 0x000208B3
		public bool MostTrapDamageCaused { get; set; }

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x000226BC File Offset: 0x000208BC
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x000226C4 File Offset: 0x000208C4
		public bool MostHealingDone { get; set; }

		// Token: 0x06003D85 RID: 15749 RVA: 0x00114A14 File Offset: 0x00112C14
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Class);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ComputerName);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerKills);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerDeaths);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MinionKills);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Score);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TrapsBuilt);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TrapsSold);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.RiftsOpened);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.RiftPointsTaken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.WaveSent);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ShotsFired);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ShotsHit);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MeleeSwings);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MeleeHits);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.DamageDealtPlayers);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.DamageDealtMobs);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TotalDamageDealt);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ActualDamageDealtPlayers);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ActualDamageDealtMobs);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ActualTotalDamageDealt);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.DamageMitigated);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PrimaryAbilityUsed);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SecondaryAbilityUsed);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SoftCurrencyWon);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ExperiencePointsGained);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsBot);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CharacterGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerBestCombo);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.GlyphsBuilt);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.GlyphsSold);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PeakGlyphs);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Assists);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TrapKills);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.CoinEarned);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.CoinSpent);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ComboCoinEarned);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerSiegeDamage);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PillageMinionPortalXP);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.EscortMinionPortalXP);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerLevel);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerTrapDamage);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerCombos);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerHealingDone);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerBattleLevel);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerDamageTakenActual);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerDamageTaken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SabotagePlayerMinionDamageToPlayers);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SabotagePlayerMinionDamageToTraps);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SabotagePlayerMinionDamageToGuardians);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SabotagePlayerMinionRiftPointsScored);
			ArrayManager.WriteListPlayerBoostStatus(ref newArray, ref newSize, this.PlayerBoosts);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.KillScore);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.WaveBonusScoreMultiplier);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.ComboBonusScore);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.HeroSurvivalBonusScoreMultiplier);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.RiftPointBonusScoreMultiplier);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.TimeBonusScoreMultiplier);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedBadge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedAvatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedBackground);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedTitle);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedPlayerSkin);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.MostDamageTaken);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.MostDamageCaused);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.MostTrapDamageCaused);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.MostHealingDone);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00114E6C File Offset: 0x0011306C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Name = ArrayManager.ReadString(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Class = ArrayManager.ReadString(data, ref num);
			this.ComputerName = ArrayManager.ReadString(data, ref num);
			this.PlayerID = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerKills = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerDeaths = ArrayManager.ReadUInt32(data, ref num);
			this.MinionKills = ArrayManager.ReadUInt32(data, ref num);
			this.Score = ArrayManager.ReadUInt32(data, ref num);
			this.TrapsBuilt = ArrayManager.ReadUInt32(data, ref num);
			this.TrapsSold = ArrayManager.ReadUInt32(data, ref num);
			this.RiftsOpened = ArrayManager.ReadUInt32(data, ref num);
			this.RiftPointsTaken = ArrayManager.ReadUInt32(data, ref num);
			this.WaveSent = ArrayManager.ReadUInt32(data, ref num);
			this.ShotsFired = ArrayManager.ReadUInt32(data, ref num);
			this.ShotsHit = ArrayManager.ReadUInt32(data, ref num);
			this.MeleeSwings = ArrayManager.ReadUInt32(data, ref num);
			this.MeleeHits = ArrayManager.ReadUInt32(data, ref num);
			this.DamageDealtPlayers = ArrayManager.ReadUInt32(data, ref num);
			this.DamageDealtMobs = ArrayManager.ReadUInt32(data, ref num);
			this.TotalDamageDealt = ArrayManager.ReadUInt32(data, ref num);
			this.ActualDamageDealtPlayers = ArrayManager.ReadUInt32(data, ref num);
			this.ActualDamageDealtMobs = ArrayManager.ReadUInt32(data, ref num);
			this.ActualTotalDamageDealt = ArrayManager.ReadUInt32(data, ref num);
			this.DamageMitigated = ArrayManager.ReadUInt32(data, ref num);
			this.PrimaryAbilityUsed = ArrayManager.ReadUInt32(data, ref num);
			this.SecondaryAbilityUsed = ArrayManager.ReadUInt32(data, ref num);
			this.SoftCurrencyWon = ArrayManager.ReadUInt32(data, ref num);
			this.ExperiencePointsGained = ArrayManager.ReadUInt32(data, ref num);
			this.IsBot = ArrayManager.ReadBoolean(data, ref num);
			this.CharacterGUID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerBestCombo = ArrayManager.ReadUInt32(data, ref num);
			this.GlyphsBuilt = ArrayManager.ReadUInt32(data, ref num);
			this.GlyphsSold = ArrayManager.ReadUInt32(data, ref num);
			this.PeakGlyphs = ArrayManager.ReadUInt32(data, ref num);
			this.Assists = ArrayManager.ReadUInt32(data, ref num);
			this.TrapKills = ArrayManager.ReadUInt32(data, ref num);
			this.CoinEarned = ArrayManager.ReadUInt32(data, ref num);
			this.CoinSpent = ArrayManager.ReadUInt32(data, ref num);
			this.ComboCoinEarned = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerSiegeDamage = ArrayManager.ReadUInt32(data, ref num);
			this.PillageMinionPortalXP = ArrayManager.ReadUInt32(data, ref num);
			this.EscortMinionPortalXP = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerLevel = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerTrapDamage = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerCombos = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerHealingDone = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerBattleLevel = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerDamageTakenActual = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerDamageTaken = ArrayManager.ReadUInt32(data, ref num);
			this.SabotagePlayerMinionDamageToPlayers = ArrayManager.ReadUInt32(data, ref num);
			this.SabotagePlayerMinionDamageToTraps = ArrayManager.ReadUInt32(data, ref num);
			this.SabotagePlayerMinionDamageToGuardians = ArrayManager.ReadUInt32(data, ref num);
			this.SabotagePlayerMinionRiftPointsScored = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerBoosts = ArrayManager.ReadListPlayerBoostStatus(data, ref num);
			this.KillScore = ArrayManager.ReadDouble(data, ref num);
			this.WaveBonusScoreMultiplier = ArrayManager.ReadDouble(data, ref num);
			this.ComboBonusScore = ArrayManager.ReadDouble(data, ref num);
			this.HeroSurvivalBonusScoreMultiplier = ArrayManager.ReadDouble(data, ref num);
			this.RiftPointBonusScoreMultiplier = ArrayManager.ReadDouble(data, ref num);
			this.TimeBonusScoreMultiplier = ArrayManager.ReadDouble(data, ref num);
			this.SelectedBadge = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedAvatar = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedBackground = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedTitle = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedPlayerSkin = ArrayManager.ReadUInt64(data, ref num);
			this.MostDamageTaken = ArrayManager.ReadBoolean(data, ref num);
			this.MostDamageCaused = ArrayManager.ReadBoolean(data, ref num);
			this.MostTrapDamageCaused = ArrayManager.ReadBoolean(data, ref num);
			this.MostHealingDone = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x0011526C File Offset: 0x0011346C
		private void InitRefTypes()
		{
			this.Name = string.Empty;
			this.GuildID = 0UL;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Class = string.Empty;
			this.ComputerName = string.Empty;
			this.PlayerID = 0u;
			this.PlayerKills = 0u;
			this.PlayerDeaths = 0u;
			this.MinionKills = 0u;
			this.Score = 0u;
			this.TrapsBuilt = 0u;
			this.TrapsSold = 0u;
			this.RiftsOpened = 0u;
			this.RiftPointsTaken = 0u;
			this.WaveSent = 0u;
			this.ShotsFired = 0u;
			this.ShotsHit = 0u;
			this.MeleeSwings = 0u;
			this.MeleeHits = 0u;
			this.DamageDealtPlayers = 0u;
			this.DamageDealtMobs = 0u;
			this.TotalDamageDealt = 0u;
			this.ActualDamageDealtPlayers = 0u;
			this.ActualDamageDealtMobs = 0u;
			this.ActualTotalDamageDealt = 0u;
			this.DamageMitigated = 0u;
			this.PrimaryAbilityUsed = 0u;
			this.SecondaryAbilityUsed = 0u;
			this.SoftCurrencyWon = 0u;
			this.ExperiencePointsGained = 0u;
			this.IsBot = false;
			this.CharacterGUID = 0UL;
			this.PlayerBestCombo = 0u;
			this.GlyphsBuilt = 0u;
			this.GlyphsSold = 0u;
			this.PeakGlyphs = 0u;
			this.Assists = 0u;
			this.TrapKills = 0u;
			this.CoinEarned = 0u;
			this.CoinSpent = 0u;
			this.ComboCoinEarned = 0u;
			this.PlayerSiegeDamage = 0u;
			this.PillageMinionPortalXP = 0u;
			this.EscortMinionPortalXP = 0u;
			this.PlayerLevel = 0u;
			this.PlayerTrapDamage = 0u;
			this.PlayerCombos = 0u;
			this.PlayerHealingDone = 0u;
			this.PlayerBattleLevel = 0u;
			this.PlayerDamageTakenActual = 0u;
			this.PlayerDamageTaken = 0u;
			this.SabotagePlayerMinionDamageToPlayers = 0u;
			this.SabotagePlayerMinionDamageToTraps = 0u;
			this.SabotagePlayerMinionDamageToGuardians = 0u;
			this.SabotagePlayerMinionRiftPointsScored = 0u;
			this.PlayerBoosts = new List<PlayerBoostStatus>();
			this.KillScore = 0.0;
			this.WaveBonusScoreMultiplier = 0.0;
			this.ComboBonusScore = 0.0;
			this.HeroSurvivalBonusScoreMultiplier = 0.0;
			this.RiftPointBonusScoreMultiplier = 0.0;
			this.TimeBonusScoreMultiplier = 0.0;
			this.SelectedBadge = 0UL;
			this.SelectedAvatar = 0UL;
			this.SelectedBackground = 0UL;
			this.SelectedTitle = 0UL;
			this.SelectedPlayerSkin = 0UL;
			this.MostDamageTaken = false;
			this.MostDamageCaused = false;
			this.MostTrapDamageCaused = false;
			this.MostHealingDone = false;
		}
	}
}
