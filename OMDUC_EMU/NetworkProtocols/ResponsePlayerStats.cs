using System;

namespace NetworkProtocols
{
	// Token: 0x020004F3 RID: 1267
	public class ResponsePlayerStats : BotNetMessage
	{
		// Token: 0x06002BE9 RID: 11241 RVA: 0x00017491 File Offset: 0x00015691
		public ResponsePlayerStats()
		{
			this.InitRefTypes();
			base.PacketType = 2031261405u;
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000174AA File Offset: 0x000156AA
		public ResponsePlayerStats(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2031261405u;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000174CA File Offset: 0x000156CA
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x000174D2 File Offset: 0x000156D2
		public ulong AccountSUID { get; set; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x000174DB File Offset: 0x000156DB
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x000174E3 File Offset: 0x000156E3
		public ulong Win { get; set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x000174EC File Offset: 0x000156EC
		// (set) Token: 0x06002BF0 RID: 11248 RVA: 0x000174F4 File Offset: 0x000156F4
		public ulong Games { get; set; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000174FD File Offset: 0x000156FD
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x00017505 File Offset: 0x00015705
		public ulong PlayerKills { get; set; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x0001750E File Offset: 0x0001570E
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x00017516 File Offset: 0x00015716
		public ulong PlayerDeaths { get; set; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x0001751F File Offset: 0x0001571F
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00017527 File Offset: 0x00015727
		public ulong MinionKills { get; set; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x00017530 File Offset: 0x00015730
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x00017538 File Offset: 0x00015738
		public uint SurvivalGamesPlayed { get; set; }

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x00017541 File Offset: 0x00015741
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x00017549 File Offset: 0x00015749
		public uint SurvivalWins { get; set; }

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x00017552 File Offset: 0x00015752
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x0001755A File Offset: 0x0001575A
		public uint SiegeGamesPlayed { get; set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x00017563 File Offset: 0x00015763
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x0001756B File Offset: 0x0001576B
		public uint SiegeWins { get; set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x00017574 File Offset: 0x00015774
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x0001757C File Offset: 0x0001577C
		public uint FiveStarredMaps { get; set; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x00017585 File Offset: 0x00015785
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x0001758D File Offset: 0x0001578D
		public uint NumberOfMaps { get; set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x00017596 File Offset: 0x00015796
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x0001759E File Offset: 0x0001579E
		public uint TotalHeroRanks { get; set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000175A7 File Offset: 0x000157A7
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x000175AF File Offset: 0x000157AF
		public uint HeroesUnlocked { get; set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000175B8 File Offset: 0x000157B8
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x000175C0 File Offset: 0x000157C0
		public uint NumberOfHeroes { get; set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000175C9 File Offset: 0x000157C9
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x000175D1 File Offset: 0x000157D1
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000175DA File Offset: 0x000157DA
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x000175E2 File Offset: 0x000157E2
		public ulong Value { get; set; }

		// Token: 0x06002C0D RID: 11277 RVA: 0x000FD3F4 File Offset: 0x000FB5F4
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Win);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Games);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerKills);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerDeaths);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MinionKills);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SurvivalGamesPlayed);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SurvivalWins);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SiegeGamesPlayed);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SiegeWins);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.FiveStarredMaps);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.NumberOfMaps);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TotalHeroRanks);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.HeroesUnlocked);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.NumberOfHeroes);
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000FD564 File Offset: 0x000FB764
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Win = ArrayManager.ReadUInt64(data, ref num);
			this.Games = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerKills = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerDeaths = ArrayManager.ReadUInt64(data, ref num);
			this.MinionKills = ArrayManager.ReadUInt64(data, ref num);
			this.SurvivalGamesPlayed = ArrayManager.ReadUInt32(data, ref num);
			this.SurvivalWins = ArrayManager.ReadUInt32(data, ref num);
			this.SiegeGamesPlayed = ArrayManager.ReadUInt32(data, ref num);
			this.SiegeWins = ArrayManager.ReadUInt32(data, ref num);
			this.FiveStarredMaps = ArrayManager.ReadUInt32(data, ref num);
			this.NumberOfMaps = ArrayManager.ReadUInt32(data, ref num);
			this.TotalHeroRanks = ArrayManager.ReadUInt32(data, ref num);
			this.HeroesUnlocked = ArrayManager.ReadUInt32(data, ref num);
			this.NumberOfHeroes = ArrayManager.ReadUInt32(data, ref num);
			this.EventCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000FD6AC File Offset: 0x000FB8AC
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Win = 0UL;
			this.Games = 0UL;
			this.PlayerKills = 0UL;
			this.PlayerDeaths = 0UL;
			this.MinionKills = 0UL;
			this.SurvivalGamesPlayed = 0u;
			this.SurvivalWins = 0u;
			this.SiegeGamesPlayed = 0u;
			this.SiegeWins = 0u;
			this.FiveStarredMaps = 0u;
			this.NumberOfMaps = 0u;
			this.TotalHeroRanks = 0u;
			this.HeroesUnlocked = 0u;
			this.NumberOfHeroes = 0u;
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A61 RID: 6753
		public const uint cPacketType = 2031261405u;
	}
}
