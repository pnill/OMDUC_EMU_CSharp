using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000750 RID: 1872
	public class GuildMemberEntry
	{
		// Token: 0x06004242 RID: 16962 RVA: 0x0002605E File Offset: 0x0002425E
		public GuildMemberEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x0002606C File Offset: 0x0002426C
		// (set) Token: 0x06004244 RID: 16964 RVA: 0x00026074 File Offset: 0x00024274
		public ulong AccountSUID { get; set; }

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x0002607D File Offset: 0x0002427D
		// (set) Token: 0x06004246 RID: 16966 RVA: 0x00026085 File Offset: 0x00024285
		public ulong GuildID { get; set; }

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x0002608E File Offset: 0x0002428E
		// (set) Token: 0x06004248 RID: 16968 RVA: 0x00026096 File Offset: 0x00024296
		public string Name { get; set; }

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06004249 RID: 16969 RVA: 0x0002609F File Offset: 0x0002429F
		// (set) Token: 0x0600424A RID: 16970 RVA: 0x000260A7 File Offset: 0x000242A7
		public string GuildTag { get; set; }

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x000260B0 File Offset: 0x000242B0
		// (set) Token: 0x0600424C RID: 16972 RVA: 0x000260B8 File Offset: 0x000242B8
		public string GuildName { get; set; }

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x000260C1 File Offset: 0x000242C1
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x000260C9 File Offset: 0x000242C9
		public ePlayerPresence Presence { get; set; }

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x000260D2 File Offset: 0x000242D2
		// (set) Token: 0x06004250 RID: 16976 RVA: 0x000260DA File Offset: 0x000242DA
		public uint AccountLevel { get; set; }

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x000260E3 File Offset: 0x000242E3
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x000260EB File Offset: 0x000242EB
		public eGuildMemberRank Rank { get; set; }

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x000260F4 File Offset: 0x000242F4
		// (set) Token: 0x06004254 RID: 16980 RVA: 0x000260FC File Offset: 0x000242FC
		public DateTime LastLogin { get; set; }

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06004255 RID: 16981 RVA: 0x00026105 File Offset: 0x00024305
		// (set) Token: 0x06004256 RID: 16982 RVA: 0x0002610D File Offset: 0x0002430D
		public DateTime DateJoined { get; set; }

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x00026116 File Offset: 0x00024316
		// (set) Token: 0x06004258 RID: 16984 RVA: 0x0002611E File Offset: 0x0002431E
		public uint ActiveGuildPoints { get; set; }

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06004259 RID: 16985 RVA: 0x00026127 File Offset: 0x00024327
		// (set) Token: 0x0600425A RID: 16986 RVA: 0x0002612F File Offset: 0x0002432F
		public uint LifetimeGuildPoints { get; set; }

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600425B RID: 16987 RVA: 0x00026138 File Offset: 0x00024338
		// (set) Token: 0x0600425C RID: 16988 RVA: 0x00026140 File Offset: 0x00024340
		public uint AccumulatedTrickleGuildPoints { get; set; }

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600425D RID: 16989 RVA: 0x00026149 File Offset: 0x00024349
		// (set) Token: 0x0600425E RID: 16990 RVA: 0x00026151 File Offset: 0x00024351
		public ulong SelectedBadge { get; set; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x0002615A File Offset: 0x0002435A
		// (set) Token: 0x06004260 RID: 16992 RVA: 0x00026162 File Offset: 0x00024362
		public ulong SelectedAvatar { get; set; }

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x0002616B File Offset: 0x0002436B
		// (set) Token: 0x06004262 RID: 16994 RVA: 0x00026173 File Offset: 0x00024373
		public ulong SelectedBackground { get; set; }

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x0002617C File Offset: 0x0002437C
		// (set) Token: 0x06004264 RID: 16996 RVA: 0x00026184 File Offset: 0x00024384
		public ulong SelectedTitle { get; set; }

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x0002618D File Offset: 0x0002438D
		// (set) Token: 0x06004266 RID: 16998 RVA: 0x00026195 File Offset: 0x00024395
		public bool IsRobotEmployee { get; set; }

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x0002619E File Offset: 0x0002439E
		// (set) Token: 0x06004268 RID: 17000 RVA: 0x000261A6 File Offset: 0x000243A6
		public List<PlayerBoostStatus> PlayerBoosts { get; set; }

		// Token: 0x06004269 RID: 17001 RVA: 0x001203A0 File Offset: 0x0011E5A0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteePlayerPresence(ref newArray, ref newSize, this.Presence);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.AccountLevel);
			ArrayManager.WriteeGuildMemberRank(ref newArray, ref newSize, this.Rank);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.LastLogin);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.DateJoined);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ActiveGuildPoints);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.LifetimeGuildPoints);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.AccumulatedTrickleGuildPoints);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedBadge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedAvatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedBackground);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedTitle);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteListPlayerBoostStatus(ref newArray, ref newSize, this.PlayerBoosts);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x001204DC File Offset: 0x0011E6DC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Presence = ArrayManager.ReadePlayerPresence(data, ref num);
			this.AccountLevel = ArrayManager.ReadUInt32(data, ref num);
			this.Rank = ArrayManager.ReadeGuildMemberRank(data, ref num);
			this.LastLogin = ArrayManager.ReadDateTime(data, ref num);
			this.DateJoined = ArrayManager.ReadDateTime(data, ref num);
			this.ActiveGuildPoints = ArrayManager.ReadUInt32(data, ref num);
			this.LifetimeGuildPoints = ArrayManager.ReadUInt32(data, ref num);
			this.AccumulatedTrickleGuildPoints = ArrayManager.ReadUInt32(data, ref num);
			this.SelectedBadge = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedAvatar = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedBackground = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedTitle = ArrayManager.ReadUInt64(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.PlayerBoosts = ArrayManager.ReadListPlayerBoostStatus(data, ref num);
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x001205F8 File Offset: 0x0011E7F8
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.GuildID = 0UL;
			this.Name = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Presence = ePlayerPresence.PlayerPresence_None;
			this.AccountLevel = 0u;
			this.Rank = eGuildMemberRank.None;
			this.LastLogin = default(DateTime);
			this.DateJoined = default(DateTime);
			this.ActiveGuildPoints = 0u;
			this.LifetimeGuildPoints = 0u;
			this.AccumulatedTrickleGuildPoints = 0u;
			this.SelectedBadge = 0UL;
			this.SelectedAvatar = 0UL;
			this.SelectedBackground = 0UL;
			this.SelectedTitle = 0UL;
			this.IsRobotEmployee = false;
			this.PlayerBoosts = new List<PlayerBoostStatus>();
		}
	}
}
