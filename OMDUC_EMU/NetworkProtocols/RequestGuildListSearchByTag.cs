using System;

namespace NetworkProtocols
{
	// Token: 0x0200076F RID: 1903
	public class RequestGuildListSearchByTag : BotNetMessage
	{
		// Token: 0x06004381 RID: 17281 RVA: 0x00026DFB File Offset: 0x00024FFB
		public RequestGuildListSearchByTag()
		{
			this.InitRefTypes();
			base.PacketType = 2789833521u;
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00026E14 File Offset: 0x00025014
		public RequestGuildListSearchByTag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2789833521u;
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x00026E34 File Offset: 0x00025034
		// (set) Token: 0x06004384 RID: 17284 RVA: 0x00026E3C File Offset: 0x0002503C
		public eGuildLeaderboardFilter LeaderboardFilter { get; set; }

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x00026E45 File Offset: 0x00025045
		// (set) Token: 0x06004386 RID: 17286 RVA: 0x00026E4D File Offset: 0x0002504D
		public string GuildTag { get; set; }

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x00026E56 File Offset: 0x00025056
		// (set) Token: 0x06004388 RID: 17288 RVA: 0x00026E5E File Offset: 0x0002505E
		public bool OnlyGuildsAcceptingApplications { get; set; }

		// Token: 0x06004389 RID: 17289 RVA: 0x001222A0 File Offset: 0x001204A0
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

		// Token: 0x0600438A RID: 17290 RVA: 0x0012233C File Offset: 0x0012053C
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

		// Token: 0x0600438B RID: 17291 RVA: 0x00026E67 File Offset: 0x00025067
		private void InitRefTypes()
		{
			this.LeaderboardFilter = eGuildLeaderboardFilter.None;
			this.GuildTag = string.Empty;
			this.OnlyGuildsAcceptingApplications = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002316 RID: 8982
		public const uint cPacketType = 2789833521u;
	}
}
