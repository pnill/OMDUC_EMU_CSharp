using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000751 RID: 1873
	public class GuildDetail
	{
		// Token: 0x0600426C RID: 17004 RVA: 0x000261AF File Offset: 0x000243AF
		public GuildDetail()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x000261BD File Offset: 0x000243BD
		// (set) Token: 0x0600426E RID: 17006 RVA: 0x000261C5 File Offset: 0x000243C5
		public ulong ID { get; set; }

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x000261CE File Offset: 0x000243CE
		// (set) Token: 0x06004270 RID: 17008 RVA: 0x000261D6 File Offset: 0x000243D6
		public string Name { get; set; }

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x000261DF File Offset: 0x000243DF
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x000261E7 File Offset: 0x000243E7
		public string Tag { get; set; }

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x000261F0 File Offset: 0x000243F0
		// (set) Token: 0x06004274 RID: 17012 RVA: 0x000261F8 File Offset: 0x000243F8
		public ulong ActivePoints { get; set; }

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x00026201 File Offset: 0x00024401
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x00026209 File Offset: 0x00024409
		public ulong LifetimePoints { get; set; }

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x00026212 File Offset: 0x00024412
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x0002621A File Offset: 0x0002441A
		public bool AcceptingApplications { get; set; }

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x00026223 File Offset: 0x00024423
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x0002622B File Offset: 0x0002442B
		public List<MMREntry> GuildMMR { get; set; }

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00026234 File Offset: 0x00024434
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x0002623C File Offset: 0x0002443C
		public string MOTD { get; set; }

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x00026245 File Offset: 0x00024445
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x0002624D File Offset: 0x0002444D
		public string Description { get; set; }

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x00026256 File Offset: 0x00024456
		// (set) Token: 0x06004280 RID: 17024 RVA: 0x0002625E File Offset: 0x0002445E
		public List<GuildLogEntryForNetwork> TransactionLog { get; set; }

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x00026267 File Offset: 0x00024467
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x0002626F File Offset: 0x0002446F
		public DateTime FoundedOn { get; set; }

		// Token: 0x06004283 RID: 17027 RVA: 0x001206B0 File Offset: 0x0011E8B0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Tag);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ActivePoints);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LifetimePoints);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.AcceptingApplications);
			ArrayManager.WriteListMMREntry(ref newArray, ref newSize, this.GuildMMR);
			ArrayManager.WriteString(ref newArray, ref newSize, this.MOTD);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteListGuildLogEntryForNetwork(ref newArray, ref newSize, this.TransactionLog);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.FoundedOn);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x00120774 File Offset: 0x0011E974
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.Tag = ArrayManager.ReadString(data, ref num);
			this.ActivePoints = ArrayManager.ReadUInt64(data, ref num);
			this.LifetimePoints = ArrayManager.ReadUInt64(data, ref num);
			this.AcceptingApplications = ArrayManager.ReadBoolean(data, ref num);
			this.GuildMMR = ArrayManager.ReadListMMREntry(data, ref num);
			this.MOTD = ArrayManager.ReadString(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
			this.TransactionLog = ArrayManager.ReadListGuildLogEntryForNetwork(data, ref num);
			this.FoundedOn = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x00120820 File Offset: 0x0011EA20
		private void InitRefTypes()
		{
			this.ID = 0UL;
			this.Name = string.Empty;
			this.Tag = string.Empty;
			this.ActivePoints = 0UL;
			this.LifetimePoints = 0UL;
			this.AcceptingApplications = false;
			this.GuildMMR = new List<MMREntry>();
			this.MOTD = string.Empty;
			this.Description = string.Empty;
			this.TransactionLog = new List<GuildLogEntryForNetwork>();
			this.FoundedOn = default(DateTime);
		}
	}
}
