using System;

namespace NetworkProtocols
{
	// Token: 0x02000685 RID: 1669
	public class ResponsePreviousChallengeLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A8B RID: 14987 RVA: 0x00020809 File Offset: 0x0001EA09
		public ResponsePreviousChallengeLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 3789460582u;
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00020822 File Offset: 0x0001EA22
		public ResponsePreviousChallengeLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3789460582u;
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06003A8D RID: 14989 RVA: 0x00020842 File Offset: 0x0001EA42
		// (set) Token: 0x06003A8E RID: 14990 RVA: 0x0002084A File Offset: 0x0001EA4A
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x00020853 File Offset: 0x0001EA53
		// (set) Token: 0x06003A90 RID: 14992 RVA: 0x0002085B File Offset: 0x0001EA5B
		public LeaderboardPlayerInfoForNetwork Player { get; set; }

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x00020864 File Offset: 0x0001EA64
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x0002086C File Offset: 0x0001EA6C
		public PacketChallenge PreviousChallengeDefinition { get; set; }

		// Token: 0x06003A93 RID: 14995 RVA: 0x001110E8 File Offset: 0x0010F2E8
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
			ArrayManager.WriteeLeaderboardOperationResult(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteLeaderboardPlayerInfoForNetwork(ref newArray, ref newSize, this.Player);
			ArrayManager.WritePacketChallenge(ref newArray, ref newSize, this.PreviousChallengeDefinition);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00111184 File Offset: 0x0010F384
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeLeaderboardOperationResult(data, ref num);
			this.Player = ArrayManager.ReadLeaderboardPlayerInfoForNetwork(data, ref num);
			this.PreviousChallengeDefinition = ArrayManager.ReadPacketChallenge(data, ref num);
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00020875 File Offset: 0x0001EA75
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.Player = new LeaderboardPlayerInfoForNetwork();
			this.PreviousChallengeDefinition = new PacketChallenge();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F0F RID: 7951
		public const uint cPacketType = 3789460582u;
	}
}
