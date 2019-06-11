using System;

namespace NetworkProtocols
{
	// Token: 0x02000682 RID: 1666
	public class RequestChallengeLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A6C RID: 14956 RVA: 0x0002067A File Offset: 0x0001E87A
		public RequestChallengeLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 2892599790u;
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00020693 File Offset: 0x0001E893
		public RequestChallengeLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2892599790u;
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x000206B3 File Offset: 0x0001E8B3
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x000206BB File Offset: 0x0001E8BB
		public ulong MapID { get; set; }

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x000206C4 File Offset: 0x0001E8C4
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x000206CC File Offset: 0x0001E8CC
		public string PlayerName { get; set; }

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000206D5 File Offset: 0x0001E8D5
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x000206DD File Offset: 0x0001E8DD
		public eLeaderboardSearchType SearchType { get; set; }

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x000206E6 File Offset: 0x0001E8E6
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x000206EE File Offset: 0x0001E8EE
		public eLeaderboardFilter Filter { get; set; }

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x000206F7 File Offset: 0x0001E8F7
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x000206FF File Offset: 0x0001E8FF
		public ushort PlayerCount { get; set; }

		// Token: 0x06003A78 RID: 14968 RVA: 0x00110DA0 File Offset: 0x0010EFA0
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
			ArrayManager.WriteeLeaderboardSearchType(ref newArray, ref newSize, this.SearchType);
			ArrayManager.WriteeLeaderboardFilter(ref newArray, ref newSize, this.Filter);
			ArrayManager.WriteUInt16(ref newArray, ref newSize, this.PlayerCount);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x00110E5C File Offset: 0x0010F05C
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
			this.SearchType = ArrayManager.ReadeLeaderboardSearchType(data, ref num);
			this.Filter = ArrayManager.ReadeLeaderboardFilter(data, ref num);
			this.PlayerCount = ArrayManager.ReadUInt16(data, ref num);
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00020708 File Offset: 0x0001E908
		private void InitRefTypes()
		{
			this.MapID = 0UL;
			this.PlayerName = string.Empty;
			this.SearchType = eLeaderboardSearchType.None;
			this.Filter = eLeaderboardFilter.None;
			this.PlayerCount = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F04 RID: 7940
		public const uint cPacketType = 2892599790u;
	}
}
