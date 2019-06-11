using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005BB RID: 1467
	public class ResponseDashboardConfigs : BotNetMessage
	{
		// Token: 0x06003302 RID: 13058 RVA: 0x0001B7D2 File Offset: 0x000199D2
		public ResponseDashboardConfigs()
		{
			this.InitRefTypes();
			base.PacketType = 759795849u;
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x0001B7EB File Offset: 0x000199EB
		public ResponseDashboardConfigs(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 759795849u;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x0001B80B File Offset: 0x00019A0B
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x0001B813 File Offset: 0x00019A13
		public string BaseCDNContentURL { get; set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x0001B81C File Offset: 0x00019A1C
		// (set) Token: 0x06003307 RID: 13063 RVA: 0x0001B824 File Offset: 0x00019A24
		public int PartyInviteTimeoutSeconds { get; set; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x0001B82D File Offset: 0x00019A2D
		// (set) Token: 0x06003309 RID: 13065 RVA: 0x0001B835 File Offset: 0x00019A35
		public int LobbyInviteTimeoutSeconds { get; set; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x0001B83E File Offset: 0x00019A3E
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x0001B846 File Offset: 0x00019A46
		public eServerRegion ServerRegion { get; set; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x0001B84F File Offset: 0x00019A4F
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x0001B857 File Offset: 0x00019A57
		public List<MatchmakingBonusXPConfig> MatchmakingBonusConfig { get; set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x0001B860 File Offset: 0x00019A60
		// (set) Token: 0x0600330F RID: 13071 RVA: 0x0001B868 File Offset: 0x00019A68
		public string TermsOfServiceUrl { get; set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x0001B871 File Offset: 0x00019A71
		// (set) Token: 0x06003311 RID: 13073 RVA: 0x0001B879 File Offset: 0x00019A79
		public string ResetPasswordUrl { get; set; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x0001B882 File Offset: 0x00019A82
		// (set) Token: 0x06003313 RID: 13075 RVA: 0x0001B88A File Offset: 0x00019A8A
		public string ForumsUrl { get; set; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x0001B893 File Offset: 0x00019A93
		// (set) Token: 0x06003315 RID: 13077 RVA: 0x0001B89B File Offset: 0x00019A9B
		public string LoginUrl { get; set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06003316 RID: 13078 RVA: 0x0001B8A4 File Offset: 0x00019AA4
		// (set) Token: 0x06003317 RID: 13079 RVA: 0x0001B8AC File Offset: 0x00019AAC
		public string RegisterUrl { get; set; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x0001B8B5 File Offset: 0x00019AB5
		// (set) Token: 0x06003319 RID: 13081 RVA: 0x0001B8BD File Offset: 0x00019ABD
		public string EULAUrl { get; set; }

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x0001B8C6 File Offset: 0x00019AC6
		// (set) Token: 0x0600331B RID: 13083 RVA: 0x0001B8CE File Offset: 0x00019ACE
		public string LeaderboardUrl { get; set; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x0001B8D7 File Offset: 0x00019AD7
		// (set) Token: 0x0600331D RID: 13085 RVA: 0x0001B8DF File Offset: 0x00019ADF
		public List<ValidationRegex> ValidationRegexes { get; set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		// (set) Token: 0x0600331F RID: 13087 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		public string CustomerServiceUrl { get; set; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x0001B8F9 File Offset: 0x00019AF9
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x0001B901 File Offset: 0x00019B01
		public string PlayerReportingUrl { get; set; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x0001B90A File Offset: 0x00019B0A
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x0001B912 File Offset: 0x00019B12
		public List<TrapTier> TrapTiers { get; set; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x0001B91B File Offset: 0x00019B1B
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x0001B923 File Offset: 0x00019B23
		public int MatchmakingDownLevelingLevelDifference { get; set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x0001B92C File Offset: 0x00019B2C
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x0001B934 File Offset: 0x00019B34
		public int MaxFriends { get; set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x0001B93D File Offset: 0x00019B3D
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x0001B945 File Offset: 0x00019B45
		public string ChestContentsURL { get; set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x0001B94E File Offset: 0x00019B4E
		// (set) Token: 0x0600332B RID: 13099 RVA: 0x0001B956 File Offset: 0x00019B56
		public string GFAccountRecoveryURL { get; set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x0001B95F File Offset: 0x00019B5F
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x0001B967 File Offset: 0x00019B67
		public ulong SabotageUnlockAchievementGUID { get; set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x0001B970 File Offset: 0x00019B70
		// (set) Token: 0x0600332F RID: 13103 RVA: 0x0001B978 File Offset: 0x00019B78
		public string ReferAFriendURL { get; set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x0001B981 File Offset: 0x00019B81
		// (set) Token: 0x06003331 RID: 13105 RVA: 0x0001B989 File Offset: 0x00019B89
		public List<eGameABTestType> EnabledABTests { get; set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x0001B992 File Offset: 0x00019B92
		// (set) Token: 0x06003333 RID: 13107 RVA: 0x0001B99A File Offset: 0x00019B9A
		public bool CertifiedStreamersOnly { get; set; }

		// Token: 0x06003334 RID: 13108 RVA: 0x00105C3C File Offset: 0x00103E3C
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.BaseCDNContentURL);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.PartyInviteTimeoutSeconds);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.LobbyInviteTimeoutSeconds);
			ArrayManager.WriteeServerRegion(ref newArray, ref newSize, this.ServerRegion);
			ArrayManager.WriteListMatchmakingBonusXPConfig(ref newArray, ref newSize, this.MatchmakingBonusConfig);
			ArrayManager.WriteString(ref newArray, ref newSize, this.TermsOfServiceUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ResetPasswordUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ForumsUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LoginUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RegisterUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.EULAUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LeaderboardUrl);
			ArrayManager.WriteListValidationRegex(ref newArray, ref newSize, this.ValidationRegexes);
			ArrayManager.WriteString(ref newArray, ref newSize, this.CustomerServiceUrl);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerReportingUrl);
			ArrayManager.WriteListTrapTier(ref newArray, ref newSize, this.TrapTiers);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.MatchmakingDownLevelingLevelDifference);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.MaxFriends);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ChestContentsURL);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GFAccountRecoveryURL);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SabotageUnlockAchievementGUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ReferAFriendURL);
			ArrayManager.WriteListeGameABTestType(ref newArray, ref newSize, this.EnabledABTests);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.CertifiedStreamersOnly);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00105E14 File Offset: 0x00104014
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.BaseCDNContentURL = ArrayManager.ReadString(data, ref num);
			this.PartyInviteTimeoutSeconds = ArrayManager.ReadInt32(data, ref num);
			this.LobbyInviteTimeoutSeconds = ArrayManager.ReadInt32(data, ref num);
			this.ServerRegion = ArrayManager.ReadeServerRegion(data, ref num);
			this.MatchmakingBonusConfig = ArrayManager.ReadListMatchmakingBonusXPConfig(data, ref num);
			this.TermsOfServiceUrl = ArrayManager.ReadString(data, ref num);
			this.ResetPasswordUrl = ArrayManager.ReadString(data, ref num);
			this.ForumsUrl = ArrayManager.ReadString(data, ref num);
			this.LoginUrl = ArrayManager.ReadString(data, ref num);
			this.RegisterUrl = ArrayManager.ReadString(data, ref num);
			this.EULAUrl = ArrayManager.ReadString(data, ref num);
			this.LeaderboardUrl = ArrayManager.ReadString(data, ref num);
			this.ValidationRegexes = ArrayManager.ReadListValidationRegex(data, ref num);
			this.CustomerServiceUrl = ArrayManager.ReadString(data, ref num);
			this.PlayerReportingUrl = ArrayManager.ReadString(data, ref num);
			this.TrapTiers = ArrayManager.ReadListTrapTier(data, ref num);
			this.MatchmakingDownLevelingLevelDifference = ArrayManager.ReadInt32(data, ref num);
			this.MaxFriends = ArrayManager.ReadInt32(data, ref num);
			this.ChestContentsURL = ArrayManager.ReadString(data, ref num);
			this.GFAccountRecoveryURL = ArrayManager.ReadString(data, ref num);
			this.SabotageUnlockAchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			this.ReferAFriendURL = ArrayManager.ReadString(data, ref num);
			this.EnabledABTests = ArrayManager.ReadListeGameABTestType(data, ref num);
			this.CertifiedStreamersOnly = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00105FC0 File Offset: 0x001041C0
		private void InitRefTypes()
		{
			this.BaseCDNContentURL = string.Empty;
			this.PartyInviteTimeoutSeconds = 0;
			this.LobbyInviteTimeoutSeconds = 0;
			this.ServerRegion = eServerRegion.None;
			this.MatchmakingBonusConfig = new List<MatchmakingBonusXPConfig>();
			this.TermsOfServiceUrl = string.Empty;
			this.ResetPasswordUrl = string.Empty;
			this.ForumsUrl = string.Empty;
			this.LoginUrl = string.Empty;
			this.RegisterUrl = string.Empty;
			this.EULAUrl = string.Empty;
			this.LeaderboardUrl = string.Empty;
			this.ValidationRegexes = new List<ValidationRegex>();
			this.CustomerServiceUrl = string.Empty;
			this.PlayerReportingUrl = string.Empty;
			this.TrapTiers = new List<TrapTier>();
			this.MatchmakingDownLevelingLevelDifference = 0;
			this.MaxFriends = 0;
			this.ChestContentsURL = string.Empty;
			this.GFAccountRecoveryURL = string.Empty;
			this.SabotageUnlockAchievementGUID = 0UL;
			this.ReferAFriendURL = string.Empty;
			this.EnabledABTests = new List<eGameABTestType>();
			this.CertifiedStreamersOnly = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C77 RID: 7287
		public const uint cPacketType = 759795849u;
	}
}
