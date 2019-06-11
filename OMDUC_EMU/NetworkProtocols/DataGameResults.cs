using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200056F RID: 1391
	public class DataGameResults : BotNetMessage
	{
		// Token: 0x06002F7D RID: 12157 RVA: 0x000193CF File Offset: 0x000175CF
		public DataGameResults()
		{
			this.InitRefTypes();
			base.PacketType = 1983900715u;
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000193E8 File Offset: 0x000175E8
		public DataGameResults(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1983900715u;
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x00019408 File Offset: 0x00017608
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00019410 File Offset: 0x00017610
		public bool Winner { get; set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x00019419 File Offset: 0x00017619
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x00019421 File Offset: 0x00017621
		public ulong GameLengthInSeconds { get; set; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x0001942A File Offset: 0x0001762A
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x00019432 File Offset: 0x00017632
		public uint PVEMaxWaveReached { get; set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x0001943B File Offset: 0x0001763B
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00019443 File Offset: 0x00017643
		public uint PVEScore { get; set; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x0001944C File Offset: 0x0001764C
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00019454 File Offset: 0x00017654
		public uint StarsEarned { get; set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x0001945D File Offset: 0x0001765D
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x00019465 File Offset: 0x00017665
		public uint StartingRiftPoints { get; set; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x0001946E File Offset: 0x0001766E
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00019476 File Offset: 0x00017676
		public bool GameWasCancelled { get; set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x0001947F File Offset: 0x0001767F
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00019487 File Offset: 0x00017687
		public ulong GameMapID { get; set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x00019490 File Offset: 0x00017690
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x00019498 File Offset: 0x00017698
		public eGameType GameType { get; set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x000194A1 File Offset: 0x000176A1
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x000194A9 File Offset: 0x000176A9
		public bool DisplayStarResults { get; set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000194B2 File Offset: 0x000176B2
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x000194BA File Offset: 0x000176BA
		public List<DataTeamStats> TeamStats { get; set; }

		// Token: 0x06002F95 RID: 12181 RVA: 0x00101108 File Offset: 0x000FF308
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Winner);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameLengthInSeconds);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PVEMaxWaveReached);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PVEScore);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.StarsEarned);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.StartingRiftPoints);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GameWasCancelled);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DisplayStarResults);
			ArrayManager.WriteListDataTeamStats(ref newArray, ref newSize, this.TeamStats);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x0010121C File Offset: 0x000FF41C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Winner = ArrayManager.ReadBoolean(data, ref num);
			this.GameLengthInSeconds = ArrayManager.ReadUInt64(data, ref num);
			this.PVEMaxWaveReached = ArrayManager.ReadUInt32(data, ref num);
			this.PVEScore = ArrayManager.ReadUInt32(data, ref num);
			this.StarsEarned = ArrayManager.ReadUInt32(data, ref num);
			this.StartingRiftPoints = ArrayManager.ReadUInt32(data, ref num);
			this.GameWasCancelled = ArrayManager.ReadBoolean(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.DisplayStarResults = ArrayManager.ReadBoolean(data, ref num);
			this.TeamStats = ArrayManager.ReadListDataTeamStats(data, ref num);
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00101310 File Offset: 0x000FF510
		private void InitRefTypes()
		{
			this.Winner = false;
			this.GameLengthInSeconds = 0UL;
			this.PVEMaxWaveReached = 0u;
			this.PVEScore = 0u;
			this.StarsEarned = 0u;
			this.StartingRiftPoints = 0u;
			this.GameWasCancelled = false;
			this.GameMapID = 0UL;
			this.GameType = eGameType.None;
			this.DisplayStarResults = false;
			this.TeamStats = new List<DataTeamStats>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B36 RID: 6966
		public const uint cPacketType = 1983900715u;
	}
}
