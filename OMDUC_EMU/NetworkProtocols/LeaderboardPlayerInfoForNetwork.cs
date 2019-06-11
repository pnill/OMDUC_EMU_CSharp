using System;

namespace NetworkProtocols
{
	// Token: 0x02000679 RID: 1657
	public class LeaderboardPlayerInfoForNetwork
	{
		// Token: 0x060039FC RID: 14844 RVA: 0x0002018E File Offset: 0x0001E38E
		public LeaderboardPlayerInfoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x0002019C File Offset: 0x0001E39C
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x000201A4 File Offset: 0x0001E3A4
		public ulong AccountSUID { get; set; }

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x000201AD File Offset: 0x0001E3AD
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x000201B5 File Offset: 0x0001E3B5
		public string Username { get; set; }

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x000201BE File Offset: 0x0001E3BE
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x000201C6 File Offset: 0x0001E3C6
		public string GuildTag { get; set; }

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x000201CF File Offset: 0x0001E3CF
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x000201D7 File Offset: 0x0001E3D7
		public string GuildName { get; set; }

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000201E0 File Offset: 0x0001E3E0
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x000201E8 File Offset: 0x0001E3E8
		public bool IsRobotEmployee { get; set; }

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x000201F1 File Offset: 0x0001E3F1
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x000201F9 File Offset: 0x0001E3F9
		public string PlayedOn { get; set; }

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x00020202 File Offset: 0x0001E402
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x0002020A File Offset: 0x0001E40A
		public string FounderLevel { get; set; }

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x00020213 File Offset: 0x0001E413
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x0002021B File Offset: 0x0001E41B
		public uint Wave { get; set; }

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00020224 File Offset: 0x0001E424
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x0002022C File Offset: 0x0001E42C
		public uint Score { get; set; }

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003A0F RID: 14863 RVA: 0x00020235 File Offset: 0x0001E435
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x0002023D File Offset: 0x0001E43D
		public uint Rank { get; set; }

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x00020246 File Offset: 0x0001E446
		// (set) Token: 0x06003A12 RID: 14866 RVA: 0x0002024E File Offset: 0x0001E44E
		public uint StarsEarned { get; set; }

		// Token: 0x06003A13 RID: 14867 RVA: 0x001103E8 File Offset: 0x0010E5E8
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayedOn);
			ArrayManager.WriteString(ref newArray, ref newSize, this.FounderLevel);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Wave);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Score);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Rank);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.StarsEarned);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x001104AC File Offset: 0x0010E6AC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.PlayedOn = ArrayManager.ReadString(data, ref num);
			this.FounderLevel = ArrayManager.ReadString(data, ref num);
			this.Wave = ArrayManager.ReadUInt32(data, ref num);
			this.Score = ArrayManager.ReadUInt32(data, ref num);
			this.Rank = ArrayManager.ReadUInt32(data, ref num);
			this.StarsEarned = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00110558 File Offset: 0x0010E758
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Username = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.IsRobotEmployee = false;
			this.PlayedOn = string.Empty;
			this.FounderLevel = string.Empty;
			this.Wave = 0u;
			this.Score = 0u;
			this.Rank = 0u;
			this.StarsEarned = 0u;
		}
	}
}
