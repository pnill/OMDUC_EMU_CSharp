using System;

namespace NetworkProtocols
{
	// Token: 0x02000770 RID: 1904
	public class RequestGuildListFindByTag : BotNetMessage
	{
		// Token: 0x0600438C RID: 17292 RVA: 0x00026E89 File Offset: 0x00025089
		public RequestGuildListFindByTag()
		{
			this.InitRefTypes();
			base.PacketType = 3844760708u;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00026EA2 File Offset: 0x000250A2
		public RequestGuildListFindByTag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3844760708u;
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x00026EC2 File Offset: 0x000250C2
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x00026ECA File Offset: 0x000250CA
		public eGuildLeaderboardFilter LeaderboardFilter { get; set; }

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x00026ED3 File Offset: 0x000250D3
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x00026EDB File Offset: 0x000250DB
		public string GuildTag { get; set; }

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x00026EE4 File Offset: 0x000250E4
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x00026EEC File Offset: 0x000250EC
		public bool OnlyGuildsAcceptingApplications { get; set; }

		// Token: 0x06004394 RID: 17300 RVA: 0x001223C0 File Offset: 0x001205C0
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.OnlyGuildsAcceptingApplications);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x0012245C File Offset: 0x0012065C
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
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.OnlyGuildsAcceptingApplications = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00026EF5 File Offset: 0x000250F5
		private void InitRefTypes()
		{
			this.LeaderboardFilter = eGuildLeaderboardFilter.None;
			this.GuildTag = string.Empty;
			this.OnlyGuildsAcceptingApplications = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400231A RID: 8986
		public const uint cPacketType = 3844760708u;
	}
}
