using System;

namespace NetworkProtocols
{
	// Token: 0x02000687 RID: 1671
	public class ResponseCurrentChallengeLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A9D RID: 15005 RVA: 0x000208F5 File Offset: 0x0001EAF5
		public ResponseCurrentChallengeLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 539378151u;
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x0002090E File Offset: 0x0001EB0E
		public ResponseCurrentChallengeLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 539378151u;
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x0002092E File Offset: 0x0001EB2E
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x00020936 File Offset: 0x0001EB36
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x0002093F File Offset: 0x0001EB3F
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x00020947 File Offset: 0x0001EB47
		public LeaderboardPlayerInfoForNetwork Player { get; set; }

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x00020950 File Offset: 0x0001EB50
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x00020958 File Offset: 0x0001EB58
		public PacketChallenge CurrentChallengeDefinition { get; set; }

		// Token: 0x06003AA5 RID: 15013 RVA: 0x001112F0 File Offset: 0x0010F4F0
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
			ArrayManager.WritePacketChallenge(ref newArray, ref newSize, this.CurrentChallengeDefinition);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0011138C File Offset: 0x0010F58C
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
			this.CurrentChallengeDefinition = ArrayManager.ReadPacketChallenge(data, ref num);
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00020961 File Offset: 0x0001EB61
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.Player = new LeaderboardPlayerInfoForNetwork();
			this.CurrentChallengeDefinition = new PacketChallenge();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F15 RID: 7957
		public const uint cPacketType = 539378151u;
	}
}
