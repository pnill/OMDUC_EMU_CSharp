using System;

namespace NetworkProtocols
{
	// Token: 0x0200074D RID: 1869
	public class GuildEntry
	{
		// Token: 0x06004222 RID: 16930 RVA: 0x00025F20 File Offset: 0x00024120
		public GuildEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x00025F2E File Offset: 0x0002412E
		// (set) Token: 0x06004224 RID: 16932 RVA: 0x00025F36 File Offset: 0x00024136
		public ulong GuildID { get; set; }

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x00025F3F File Offset: 0x0002413F
		// (set) Token: 0x06004226 RID: 16934 RVA: 0x00025F47 File Offset: 0x00024147
		public string Name { get; set; }

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x00025F50 File Offset: 0x00024150
		// (set) Token: 0x06004228 RID: 16936 RVA: 0x00025F58 File Offset: 0x00024158
		public string Tag { get; set; }

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x00025F61 File Offset: 0x00024161
		// (set) Token: 0x0600422A RID: 16938 RVA: 0x00025F69 File Offset: 0x00024169
		public uint ActivePoints { get; set; }

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x00025F72 File Offset: 0x00024172
		// (set) Token: 0x0600422C RID: 16940 RVA: 0x00025F7A File Offset: 0x0002417A
		public uint TotalPoints { get; set; }

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600422D RID: 16941 RVA: 0x00025F83 File Offset: 0x00024183
		// (set) Token: 0x0600422E RID: 16942 RVA: 0x00025F8B File Offset: 0x0002418B
		public string MOTD { get; set; }

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x00025F94 File Offset: 0x00024194
		// (set) Token: 0x06004230 RID: 16944 RVA: 0x00025F9C File Offset: 0x0002419C
		public string Description { get; set; }

		// Token: 0x06004231 RID: 16945 RVA: 0x00120084 File Offset: 0x0011E284
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Tag);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ActivePoints);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TotalPoints);
			ArrayManager.WriteString(ref newArray, ref newSize, this.MOTD);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0012010C File Offset: 0x0011E30C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.Tag = ArrayManager.ReadString(data, ref num);
			this.ActivePoints = ArrayManager.ReadUInt32(data, ref num);
			this.TotalPoints = ArrayManager.ReadUInt32(data, ref num);
			this.MOTD = ArrayManager.ReadString(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x00120180 File Offset: 0x0011E380
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
			this.Name = string.Empty;
			this.Tag = string.Empty;
			this.ActivePoints = 0u;
			this.TotalPoints = 0u;
			this.MOTD = string.Empty;
			this.Description = string.Empty;
		}
	}
}
