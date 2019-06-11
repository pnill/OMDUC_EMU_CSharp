using System;

namespace NetworkProtocols
{
	// Token: 0x02000771 RID: 1905
	public class RequestGuildListSearchByName : BotNetMessage
	{
		// Token: 0x06004397 RID: 17303 RVA: 0x00026F17 File Offset: 0x00025117
		public RequestGuildListSearchByName()
		{
			this.InitRefTypes();
			base.PacketType = 2078895210u;
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00026F30 File Offset: 0x00025130
		public RequestGuildListSearchByName(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2078895210u;
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x00026F50 File Offset: 0x00025150
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x00026F58 File Offset: 0x00025158
		public eGuildLeaderboardFilter LeaderboardFilter { get; set; }

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x00026F61 File Offset: 0x00025161
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x00026F69 File Offset: 0x00025169
		public string GuildName { get; set; }

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x00026F72 File Offset: 0x00025172
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x00026F7A File Offset: 0x0002517A
		public bool OnlyGuildsAcceptingApplications { get; set; }

		// Token: 0x0600439F RID: 17311 RVA: 0x001224E0 File Offset: 0x001206E0
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
			ArrayManager.WriteeGuildLeaderboardFilter(ref newArray, ref newSize, this.LeaderboardFilter);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.OnlyGuildsAcceptingApplications);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x0012257C File Offset: 0x0012077C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LeaderboardFilter = ArrayManager.ReadeGuildLeaderboardFilter(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.OnlyGuildsAcceptingApplications = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00026F83 File Offset: 0x00025183
		private void InitRefTypes()
		{
			this.LeaderboardFilter = eGuildLeaderboardFilter.None;
			this.GuildName = string.Empty;
			this.OnlyGuildsAcceptingApplications = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400231E RID: 8990
		public const uint cPacketType = 2078895210u;
	}
}
