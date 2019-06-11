using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200076E RID: 1902
	public class GuildLeaderboardInfoForNetwork
	{
		// Token: 0x06004367 RID: 17255 RVA: 0x00026D32 File Offset: 0x00024F32
		public GuildLeaderboardInfoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x00026D40 File Offset: 0x00024F40
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x00026D48 File Offset: 0x00024F48
		public uint Rank { get; set; }

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x00026D51 File Offset: 0x00024F51
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x00026D59 File Offset: 0x00024F59
		public ulong GuildID { get; set; }

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x00026D62 File Offset: 0x00024F62
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x00026D6A File Offset: 0x00024F6A
		public string Name { get; set; }

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x00026D73 File Offset: 0x00024F73
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x00026D7B File Offset: 0x00024F7B
		public string Tag { get; set; }

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x00026D84 File Offset: 0x00024F84
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x00026D8C File Offset: 0x00024F8C
		public string Description { get; set; }

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x00026D95 File Offset: 0x00024F95
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x00026D9D File Offset: 0x00024F9D
		public ulong MemberCount { get; set; }

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x00026DA6 File Offset: 0x00024FA6
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x00026DAE File Offset: 0x00024FAE
		public uint ActiveGuildPoints { get; set; }

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x00026DB7 File Offset: 0x00024FB7
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x00026DBF File Offset: 0x00024FBF
		public ulong BestSeasonID { get; set; }

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x00026DC8 File Offset: 0x00024FC8
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x00026DD0 File Offset: 0x00024FD0
		public uint BestSeasonPoints { get; set; }

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x00026DD9 File Offset: 0x00024FD9
		// (set) Token: 0x0600437B RID: 17275 RVA: 0x00026DE1 File Offset: 0x00024FE1
		public bool AcceptingApplications { get; set; }

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x00026DEA File Offset: 0x00024FEA
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x00026DF2 File Offset: 0x00024FF2
		public List<MMREntry> GuildMMR { get; set; }

		// Token: 0x0600437E RID: 17278 RVA: 0x001220C0 File Offset: 0x001202C0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Rank);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Tag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MemberCount);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ActiveGuildPoints);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BestSeasonID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.BestSeasonPoints);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.AcceptingApplications);
			ArrayManager.WriteListMMREntry(ref newArray, ref newSize, this.GuildMMR);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x00122184 File Offset: 0x00120384
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Rank = ArrayManager.ReadUInt32(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.Tag = ArrayManager.ReadString(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
			this.MemberCount = ArrayManager.ReadUInt64(data, ref num);
			this.ActiveGuildPoints = ArrayManager.ReadUInt32(data, ref num);
			this.BestSeasonID = ArrayManager.ReadUInt64(data, ref num);
			this.BestSeasonPoints = ArrayManager.ReadUInt32(data, ref num);
			this.AcceptingApplications = ArrayManager.ReadBoolean(data, ref num);
			this.GuildMMR = ArrayManager.ReadListMMREntry(data, ref num);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x00122230 File Offset: 0x00120430
		private void InitRefTypes()
		{
			this.Rank = 0u;
			this.GuildID = 0UL;
			this.Name = string.Empty;
			this.Tag = string.Empty;
			this.Description = string.Empty;
			this.MemberCount = 0UL;
			this.ActiveGuildPoints = 0u;
			this.BestSeasonID = 0UL;
			this.BestSeasonPoints = 0u;
			this.AcceptingApplications = false;
			this.GuildMMR = new List<MMREntry>();
		}
	}
}
