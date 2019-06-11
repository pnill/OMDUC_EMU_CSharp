using System;

namespace NetworkProtocols
{
	// Token: 0x02000677 RID: 1655
	public class SabotageRankingDefinitionForNetwork
	{
		// Token: 0x060039E1 RID: 14817 RVA: 0x0002009A File Offset: 0x0001E29A
		public SabotageRankingDefinitionForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x000200A8 File Offset: 0x0001E2A8
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x000200B0 File Offset: 0x0001E2B0
		public eSabotageTiers TierType { get; set; }

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x000200B9 File Offset: 0x0001E2B9
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x000200C1 File Offset: 0x0001E2C1
		public ulong TierID { get; set; }

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x000200CA File Offset: 0x0001E2CA
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x000200D2 File Offset: 0x0001E2D2
		public string TierName { get; set; }

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x000200DB File Offset: 0x0001E2DB
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x000200E3 File Offset: 0x0001E2E3
		public double PlayerMinMMR { get; set; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x000200EC File Offset: 0x0001E2EC
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x000200F4 File Offset: 0x0001E2F4
		public double PlayerMaxMMR { get; set; }

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x000200FD File Offset: 0x0001E2FD
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x00020105 File Offset: 0x0001E305
		public double GuildMinMMR { get; set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x0002010E File Offset: 0x0001E30E
		// (set) Token: 0x060039EF RID: 14831 RVA: 0x00020116 File Offset: 0x0001E316
		public double GuildMaxMMR { get; set; }

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x0002011F File Offset: 0x0001E31F
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x00020127 File Offset: 0x0001E327
		public uint TierNumber { get; set; }

		// Token: 0x060039F2 RID: 14834 RVA: 0x0011017C File Offset: 0x0010E37C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeSabotageTiers(ref newArray, ref newSize, this.TierType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TierID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.TierName);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.PlayerMinMMR);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.PlayerMaxMMR);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.GuildMinMMR);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.GuildMaxMMR);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TierNumber);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00110214 File Offset: 0x0010E414
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.TierType = ArrayManager.ReadeSabotageTiers(data, ref num);
			this.TierID = ArrayManager.ReadUInt64(data, ref num);
			this.TierName = ArrayManager.ReadString(data, ref num);
			this.PlayerMinMMR = ArrayManager.ReadDouble(data, ref num);
			this.PlayerMaxMMR = ArrayManager.ReadDouble(data, ref num);
			this.GuildMinMMR = ArrayManager.ReadDouble(data, ref num);
			this.GuildMaxMMR = ArrayManager.ReadDouble(data, ref num);
			this.TierNumber = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00110294 File Offset: 0x0010E494
		private void InitRefTypes()
		{
			this.TierType = eSabotageTiers.Diamond;
			this.TierID = 0UL;
			this.TierName = string.Empty;
			this.PlayerMinMMR = 0.0;
			this.PlayerMaxMMR = 0.0;
			this.GuildMinMMR = 0.0;
			this.GuildMaxMMR = 0.0;
			this.TierNumber = 0u;
		}
	}
}
