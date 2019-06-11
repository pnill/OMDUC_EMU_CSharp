using System;

namespace NetworkProtocols
{
	// Token: 0x02000680 RID: 1664
	public class RequestLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A52 RID: 14930 RVA: 0x0002052D File Offset: 0x0001E72D
		public RequestLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 1109727550u;
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00020546 File Offset: 0x0001E746
		public RequestLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1109727550u;
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x00020566 File Offset: 0x0001E766
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x0002056E File Offset: 0x0001E76E
		public ulong MapID { get; set; }

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x00020577 File Offset: 0x0001E777
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x0002057F File Offset: 0x0001E77F
		public string PlayerName { get; set; }

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x00020588 File Offset: 0x0001E788
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x00020590 File Offset: 0x0001E790
		public eLeaderboardType LeaderboardType { get; set; }

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x00020599 File Offset: 0x0001E799
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x000205A1 File Offset: 0x0001E7A1
		public eLeaderboardSearchType SearchType { get; set; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x000205AA File Offset: 0x0001E7AA
		// (set) Token: 0x06003A5D RID: 14941 RVA: 0x000205B2 File Offset: 0x0001E7B2
		public eLeaderboardFilter Filter { get; set; }

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x000205BB File Offset: 0x0001E7BB
		// (set) Token: 0x06003A5F RID: 14943 RVA: 0x000205C3 File Offset: 0x0001E7C3
		public ushort PlayerCount { get; set; }

		// Token: 0x06003A60 RID: 14944 RVA: 0x00110B24 File Offset: 0x0010ED24
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteeLeaderboardType(ref newArray, ref newSize, this.LeaderboardType);
			ArrayManager.WriteeLeaderboardSearchType(ref newArray, ref newSize, this.SearchType);
			ArrayManager.WriteeLeaderboardFilter(ref newArray, ref newSize, this.Filter);
			ArrayManager.WriteUInt16(ref newArray, ref newSize, this.PlayerCount);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00110BEC File Offset: 0x0010EDEC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MapID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.LeaderboardType = ArrayManager.ReadeLeaderboardType(data, ref num);
			this.SearchType = ArrayManager.ReadeLeaderboardSearchType(data, ref num);
			this.Filter = ArrayManager.ReadeLeaderboardFilter(data, ref num);
			this.PlayerCount = ArrayManager.ReadUInt16(data, ref num);
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x000205CC File Offset: 0x0001E7CC
		private void InitRefTypes()
		{
			this.MapID = 0UL;
			this.PlayerName = string.Empty;
			this.LeaderboardType = eLeaderboardType.None;
			this.SearchType = eLeaderboardSearchType.None;
			this.Filter = eLeaderboardFilter.None;
			this.PlayerCount = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EFA RID: 7930
		public const uint cPacketType = 1109727550u;
	}
}
