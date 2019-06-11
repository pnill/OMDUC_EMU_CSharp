using System;

namespace NetworkProtocols
{
	// Token: 0x02000737 RID: 1847
	public class GuildApplication
	{
		// Token: 0x0600416A RID: 16746 RVA: 0x000256C5 File Offset: 0x000238C5
		public GuildApplication()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x000256D3 File Offset: 0x000238D3
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x000256DB File Offset: 0x000238DB
		public ulong ApplicationID { get; set; }

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x000256E4 File Offset: 0x000238E4
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x000256EC File Offset: 0x000238EC
		public ulong PlayerAccountID { get; set; }

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x000256F5 File Offset: 0x000238F5
		// (set) Token: 0x06004170 RID: 16752 RVA: 0x000256FD File Offset: 0x000238FD
		public string PlayerName { get; set; }

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x00025706 File Offset: 0x00023906
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x0002570E File Offset: 0x0002390E
		public ulong GuildID { get; set; }

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x00025717 File Offset: 0x00023917
		// (set) Token: 0x06004174 RID: 16756 RVA: 0x0002571F File Offset: 0x0002391F
		public string GuildName { get; set; }

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x00025728 File Offset: 0x00023928
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x00025730 File Offset: 0x00023930
		public string GuildTag { get; set; }

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x00025739 File Offset: 0x00023939
		// (set) Token: 0x06004178 RID: 16760 RVA: 0x00025741 File Offset: 0x00023941
		public string Message { get; set; }

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x0002574A File Offset: 0x0002394A
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x00025752 File Offset: 0x00023952
		public eApplicationStatus Status { get; set; }

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x0002575B File Offset: 0x0002395B
		// (set) Token: 0x0600417C RID: 16764 RVA: 0x00025763 File Offset: 0x00023963
		public DateTime RequestDate { get; set; }

		// Token: 0x0600417D RID: 16765 RVA: 0x0011EE68 File Offset: 0x0011D068
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ApplicationID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerAccountID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Message);
			ArrayManager.WriteeApplicationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.RequestDate);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x0011EF10 File Offset: 0x0011D110
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ApplicationID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerAccountID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.Message = ArrayManager.ReadString(data, ref num);
			this.Status = ArrayManager.ReadeApplicationStatus(data, ref num);
			this.RequestDate = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x0011EFA0 File Offset: 0x0011D1A0
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			this.PlayerAccountID = 0UL;
			this.PlayerName = string.Empty;
			this.GuildID = 0UL;
			this.GuildName = string.Empty;
			this.GuildTag = string.Empty;
			this.Message = string.Empty;
			this.Status = eApplicationStatus.None;
			this.RequestDate = default(DateTime);
		}
	}
}
