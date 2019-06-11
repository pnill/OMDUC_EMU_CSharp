using System;

namespace NetworkProtocols
{
	// Token: 0x02000772 RID: 1906
	public class RequestGuildListFindByName : BotNetMessage
	{
		// Token: 0x060043A2 RID: 17314 RVA: 0x00026FA5 File Offset: 0x000251A5
		public RequestGuildListFindByName()
		{
			this.InitRefTypes();
			base.PacketType = 3231795318u;
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00026FBE File Offset: 0x000251BE
		public RequestGuildListFindByName(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3231795318u;
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x00026FDE File Offset: 0x000251DE
		// (set) Token: 0x060043A5 RID: 17317 RVA: 0x00026FE6 File Offset: 0x000251E6
		public eGuildLeaderboardFilter LeaderboardFilter { get; set; }

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060043A6 RID: 17318 RVA: 0x00026FEF File Offset: 0x000251EF
		// (set) Token: 0x060043A7 RID: 17319 RVA: 0x00026FF7 File Offset: 0x000251F7
		public string GuildName { get; set; }

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x00027000 File Offset: 0x00025200
		// (set) Token: 0x060043A9 RID: 17321 RVA: 0x00027008 File Offset: 0x00025208
		public bool OnlyGuildsAcceptingApplications { get; set; }

		// Token: 0x060043AA RID: 17322 RVA: 0x00122600 File Offset: 0x00120800
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

		// Token: 0x060043AB RID: 17323 RVA: 0x0012269C File Offset: 0x0012089C
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

		// Token: 0x060043AC RID: 17324 RVA: 0x00027011 File Offset: 0x00025211
		private void InitRefTypes()
		{
			this.LeaderboardFilter = eGuildLeaderboardFilter.None;
			this.GuildName = string.Empty;
			this.OnlyGuildsAcceptingApplications = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002322 RID: 8994
		public const uint cPacketType = 3231795318u;
	}
}
