using System;

namespace NetworkProtocols
{
	// Token: 0x02000756 RID: 1878
	public class GuildCreationRequirements
	{
		// Token: 0x060042B9 RID: 17081 RVA: 0x0002649E File Offset: 0x0002469E
		public GuildCreationRequirements()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x000264AC File Offset: 0x000246AC
		// (set) Token: 0x060042BB RID: 17083 RVA: 0x000264B4 File Offset: 0x000246B4
		public uint MinLevelToCreateGuild { get; set; }

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x000264BD File Offset: 0x000246BD
		// (set) Token: 0x060042BD RID: 17085 RVA: 0x000264C5 File Offset: 0x000246C5
		public uint CostSkullsToCreateGuild { get; set; }

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x000264CE File Offset: 0x000246CE
		// (set) Token: 0x060042BF RID: 17087 RVA: 0x000264D6 File Offset: 0x000246D6
		public uint MaximumRosterSize { get; set; }

		// Token: 0x060042C0 RID: 17088 RVA: 0x00120D58 File Offset: 0x0011EF58
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MinLevelToCreateGuild);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.CostSkullsToCreateGuild);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MaximumRosterSize);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00120DA4 File Offset: 0x0011EFA4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.MinLevelToCreateGuild = ArrayManager.ReadUInt32(data, ref num);
			this.CostSkullsToCreateGuild = ArrayManager.ReadUInt32(data, ref num);
			this.MaximumRosterSize = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000264DF File Offset: 0x000246DF
		private void InitRefTypes()
		{
			this.MinLevelToCreateGuild = 0u;
			this.CostSkullsToCreateGuild = 0u;
			this.MaximumRosterSize = 0u;
		}
	}
}
