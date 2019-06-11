using System;

namespace NetworkProtocols
{
	// Token: 0x020006E0 RID: 1760
	public class MatchmakingUserUpdate : BotNetMessage
	{
		// Token: 0x06003EDE RID: 16094 RVA: 0x00023757 File Offset: 0x00021957
		public MatchmakingUserUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 1009527074u;
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00023770 File Offset: 0x00021970
		public MatchmakingUserUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1009527074u;
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x00023790 File Offset: 0x00021990
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x00023798 File Offset: 0x00021998
		public eMatchmakingState State { get; set; }

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06003EE2 RID: 16098 RVA: 0x000237A1 File Offset: 0x000219A1
		// (set) Token: 0x06003EE3 RID: 16099 RVA: 0x000237A9 File Offset: 0x000219A9
		public uint CurrentWaitTimeMS { get; set; }

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06003EE4 RID: 16100 RVA: 0x000237B2 File Offset: 0x000219B2
		// (set) Token: 0x06003EE5 RID: 16101 RVA: 0x000237BA File Offset: 0x000219BA
		public uint WaitPenaltyTimeSec { get; set; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x000237C3 File Offset: 0x000219C3
		// (set) Token: 0x06003EE7 RID: 16103 RVA: 0x000237CB File Offset: 0x000219CB
		public eApproximateWaitTime WaitTime { get; set; }

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x000237D4 File Offset: 0x000219D4
		// (set) Token: 0x06003EE9 RID: 16105 RVA: 0x000237DC File Offset: 0x000219DC
		public eApproximatePopulation Population { get; set; }

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003EEA RID: 16106 RVA: 0x000237E5 File Offset: 0x000219E5
		// (set) Token: 0x06003EEB RID: 16107 RVA: 0x000237ED File Offset: 0x000219ED
		public uint PlayerCount { get; set; }

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003EEC RID: 16108 RVA: 0x000237F6 File Offset: 0x000219F6
		// (set) Token: 0x06003EED RID: 16109 RVA: 0x000237FE File Offset: 0x000219FE
		public uint AverageWaitTimeMS { get; set; }

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06003EEE RID: 16110 RVA: 0x00023807 File Offset: 0x00021A07
		// (set) Token: 0x06003EEF RID: 16111 RVA: 0x0002380F File Offset: 0x00021A0F
		public eGameType GameType { get; set; }

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x00023818 File Offset: 0x00021A18
		// (set) Token: 0x06003EF1 RID: 16113 RVA: 0x00023820 File Offset: 0x00021A20
		public eMatchmakingType MatchmakingType { get; set; }

		// Token: 0x06003EF2 RID: 16114 RVA: 0x001176BC File Offset: 0x001158BC
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
			ArrayManager.WriteeMatchmakingState(ref newArray, ref newSize, this.State);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.CurrentWaitTimeMS);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.WaitPenaltyTimeSec);
			ArrayManager.WriteeApproximateWaitTime(ref newArray, ref newSize, this.WaitTime);
			ArrayManager.WriteeApproximatePopulation(ref newArray, ref newSize, this.Population);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerCount);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.AverageWaitTimeMS);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteeMatchmakingType(ref newArray, ref newSize, this.MatchmakingType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x001177B4 File Offset: 0x001159B4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.State = ArrayManager.ReadeMatchmakingState(data, ref num);
			this.CurrentWaitTimeMS = ArrayManager.ReadUInt32(data, ref num);
			this.WaitPenaltyTimeSec = ArrayManager.ReadUInt32(data, ref num);
			this.WaitTime = ArrayManager.ReadeApproximateWaitTime(data, ref num);
			this.Population = ArrayManager.ReadeApproximatePopulation(data, ref num);
			this.PlayerCount = ArrayManager.ReadUInt32(data, ref num);
			this.AverageWaitTimeMS = ArrayManager.ReadUInt32(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.MatchmakingType = ArrayManager.ReadeMatchmakingType(data, ref num);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0011788C File Offset: 0x00115A8C
		private void InitRefTypes()
		{
			this.State = eMatchmakingState.MatchmakingState_None;
			this.CurrentWaitTimeMS = 0u;
			this.WaitPenaltyTimeSec = 0u;
			this.WaitTime = eApproximateWaitTime.None;
			this.Population = eApproximatePopulation.None;
			this.PlayerCount = 0u;
			this.AverageWaitTimeMS = 0u;
			this.GameType = eGameType.None;
			this.MatchmakingType = eMatchmakingType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002107 RID: 8455
		public const uint cPacketType = 1009527074u;
	}
}
