using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006B0 RID: 1712
	public class GameMap
	{
		// Token: 0x06003C58 RID: 15448 RVA: 0x00021CB7 File Offset: 0x0001FEB7
		public GameMap()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x00021CC5 File Offset: 0x0001FEC5
		// (set) Token: 0x06003C5A RID: 15450 RVA: 0x00021CCD File Offset: 0x0001FECD
		public uint MapID { get; set; }

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x00021CD6 File Offset: 0x0001FED6
		// (set) Token: 0x06003C5C RID: 15452 RVA: 0x00021CDE File Offset: 0x0001FEDE
		public string MapName { get; set; }

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x00021CE7 File Offset: 0x0001FEE7
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x00021CEF File Offset: 0x0001FEEF
		public string MapDisplayName { get; set; }

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x00021D00 File Offset: 0x0001FF00
		public string MapDescription { get; set; }

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x00021D09 File Offset: 0x0001FF09
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x00021D11 File Offset: 0x0001FF11
		public string SplashImage { get; set; }

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x00021D1A File Offset: 0x0001FF1A
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x00021D22 File Offset: 0x0001FF22
		public ulong HeroGUID { get; set; }

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x00021D2B File Offset: 0x0001FF2B
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x00021D33 File Offset: 0x0001FF33
		public ulong DeckGUID { get; set; }

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x00021D3C File Offset: 0x0001FF3C
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x00021D44 File Offset: 0x0001FF44
		public int SuggestedLevel { get; set; }

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x00021D4D File Offset: 0x0001FF4D
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x00021D55 File Offset: 0x0001FF55
		public bool ArrangedGame { get; set; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x00021D5E File Offset: 0x0001FF5E
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x00021D66 File Offset: 0x0001FF66
		public eMapGameType GameType { get; set; }

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x00021D6F File Offset: 0x0001FF6F
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x00021D77 File Offset: 0x0001FF77
		public List<GameMapBot> Bots { get; set; }

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x00021D80 File Offset: 0x0001FF80
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x00021D88 File Offset: 0x0001FF88
		public string LootText { get; set; }

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x00021D91 File Offset: 0x0001FF91
		// (set) Token: 0x06003C72 RID: 15474 RVA: 0x00021D99 File Offset: 0x0001FF99
		public string MinionText { get; set; }

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x00021DA2 File Offset: 0x0001FFA2
		// (set) Token: 0x06003C74 RID: 15476 RVA: 0x00021DAA File Offset: 0x0001FFAA
		public bool Leaderboard { get; set; }

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x00021DB3 File Offset: 0x0001FFB3
		// (set) Token: 0x06003C76 RID: 15478 RVA: 0x00021DBB File Offset: 0x0001FFBB
		public uint NumWaves { get; set; }

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x00021DC4 File Offset: 0x0001FFC4
		// (set) Token: 0x06003C78 RID: 15480 RVA: 0x00021DCC File Offset: 0x0001FFCC
		public ulong NormalParTime { get; set; }

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x00021DD5 File Offset: 0x0001FFD5
		// (set) Token: 0x06003C7A RID: 15482 RVA: 0x00021DDD File Offset: 0x0001FFDD
		public ulong EliteParTime { get; set; }

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x00021DE6 File Offset: 0x0001FFE6
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x00021DEE File Offset: 0x0001FFEE
		public List<int> EndlessWaveRatingThresholds { get; set; }

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x00021DF7 File Offset: 0x0001FFF7
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x00021DFF File Offset: 0x0001FFFF
		public bool FlagBots { get; set; }

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x00021E08 File Offset: 0x00020008
		// (set) Token: 0x06003C80 RID: 15488 RVA: 0x00021E10 File Offset: 0x00020010
		public bool FlagRifts { get; set; }

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x00021E19 File Offset: 0x00020019
		// (set) Token: 0x06003C82 RID: 15490 RVA: 0x00021E21 File Offset: 0x00020021
		public bool FlagOrder { get; set; }

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003C83 RID: 15491 RVA: 0x00021E2A File Offset: 0x0002002A
		// (set) Token: 0x06003C84 RID: 15492 RVA: 0x00021E32 File Offset: 0x00020032
		public bool FlagUnchained { get; set; }

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06003C85 RID: 15493 RVA: 0x00021E3B File Offset: 0x0002003B
		// (set) Token: 0x06003C86 RID: 15494 RVA: 0x00021E43 File Offset: 0x00020043
		public bool FlagNorthernClan { get; set; }

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x00021E4C File Offset: 0x0002004C
		// (set) Token: 0x06003C88 RID: 15496 RVA: 0x00021E54 File Offset: 0x00020054
		public bool FlagBarbarian { get; set; }

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x00021E5D File Offset: 0x0002005D
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x00021E65 File Offset: 0x00020065
		public bool FlagFireFiends { get; set; }

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x00021E6E File Offset: 0x0002006E
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x00021E76 File Offset: 0x00020076
		public bool FlagPirate { get; set; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x00021E7F File Offset: 0x0002007F
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x00021E87 File Offset: 0x00020087
		public bool FlagChinese { get; set; }

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x00021E90 File Offset: 0x00020090
		// (set) Token: 0x06003C90 RID: 15504 RVA: 0x00021E98 File Offset: 0x00020098
		public eMapPresentationStyle PresentationStyle { get; set; }

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x00021EA1 File Offset: 0x000200A1
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x00021EA9 File Offset: 0x000200A9
		public List<ulong> Mobs { get; set; }

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x00021EB2 File Offset: 0x000200B2
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x00021EBA File Offset: 0x000200BA
		public string SubBucketSuggestedLevelRange { get; set; }

		// Token: 0x06003C95 RID: 15509 RVA: 0x00113E34 File Offset: 0x00112034
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MapID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.MapName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.MapDisplayName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.MapDescription);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SplashImage);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckGUID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.SuggestedLevel);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ArrangedGame);
			ArrayManager.WriteeMapGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteListGameMapBot(ref newArray, ref newSize, this.Bots);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LootText);
			ArrayManager.WriteString(ref newArray, ref newSize, this.MinionText);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Leaderboard);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.NumWaves);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.NormalParTime);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EliteParTime);
			ArrayManager.WriteListInt32(ref newArray, ref newSize, this.EndlessWaveRatingThresholds);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagBots);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagRifts);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagOrder);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagUnchained);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagNorthernClan);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagBarbarian);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagFireFiends);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagPirate);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FlagChinese);
			ArrayManager.WriteeMapPresentationStyle(ref newArray, ref newSize, this.PresentationStyle);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.Mobs);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SubBucketSuggestedLevelRange);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00114014 File Offset: 0x00112214
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.MapID = ArrayManager.ReadUInt32(data, ref num);
			this.MapName = ArrayManager.ReadString(data, ref num);
			this.MapDisplayName = ArrayManager.ReadString(data, ref num);
			this.MapDescription = ArrayManager.ReadString(data, ref num);
			this.SplashImage = ArrayManager.ReadString(data, ref num);
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckGUID = ArrayManager.ReadUInt64(data, ref num);
			this.SuggestedLevel = ArrayManager.ReadInt32(data, ref num);
			this.ArrangedGame = ArrayManager.ReadBoolean(data, ref num);
			this.GameType = ArrayManager.ReadeMapGameType(data, ref num);
			this.Bots = ArrayManager.ReadListGameMapBot(data, ref num);
			this.LootText = ArrayManager.ReadString(data, ref num);
			this.MinionText = ArrayManager.ReadString(data, ref num);
			this.Leaderboard = ArrayManager.ReadBoolean(data, ref num);
			this.NumWaves = ArrayManager.ReadUInt32(data, ref num);
			this.NormalParTime = ArrayManager.ReadUInt64(data, ref num);
			this.EliteParTime = ArrayManager.ReadUInt64(data, ref num);
			this.EndlessWaveRatingThresholds = ArrayManager.ReadListInt32(data, ref num);
			this.FlagBots = ArrayManager.ReadBoolean(data, ref num);
			this.FlagRifts = ArrayManager.ReadBoolean(data, ref num);
			this.FlagOrder = ArrayManager.ReadBoolean(data, ref num);
			this.FlagUnchained = ArrayManager.ReadBoolean(data, ref num);
			this.FlagNorthernClan = ArrayManager.ReadBoolean(data, ref num);
			this.FlagBarbarian = ArrayManager.ReadBoolean(data, ref num);
			this.FlagFireFiends = ArrayManager.ReadBoolean(data, ref num);
			this.FlagPirate = ArrayManager.ReadBoolean(data, ref num);
			this.FlagChinese = ArrayManager.ReadBoolean(data, ref num);
			this.PresentationStyle = ArrayManager.ReadeMapPresentationStyle(data, ref num);
			this.Mobs = ArrayManager.ReadListUInt64(data, ref num);
			this.SubBucketSuggestedLevelRange = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x001141C8 File Offset: 0x001123C8
		private void InitRefTypes()
		{
			this.MapID = 0u;
			this.MapName = string.Empty;
			this.MapDisplayName = string.Empty;
			this.MapDescription = string.Empty;
			this.SplashImage = string.Empty;
			this.HeroGUID = 0UL;
			this.DeckGUID = 0UL;
			this.SuggestedLevel = 0;
			this.ArrangedGame = false;
			this.GameType = eMapGameType.MapGameType_None;
			this.Bots = new List<GameMapBot>();
			this.LootText = string.Empty;
			this.MinionText = string.Empty;
			this.Leaderboard = false;
			this.NumWaves = 0u;
			this.NormalParTime = 0UL;
			this.EliteParTime = 0UL;
			this.EndlessWaveRatingThresholds = new List<int>();
			this.FlagBots = false;
			this.FlagRifts = false;
			this.FlagOrder = false;
			this.FlagUnchained = false;
			this.FlagNorthernClan = false;
			this.FlagBarbarian = false;
			this.FlagFireFiends = false;
			this.FlagPirate = false;
			this.FlagChinese = false;
			this.PresentationStyle = eMapPresentationStyle.Default;
			this.Mobs = new List<ulong>();
			this.SubBucketSuggestedLevelRange = string.Empty;
		}
	}
}
