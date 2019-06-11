using System;

namespace NetworkProtocols
{
	// Token: 0x0200068B RID: 1675
	public class KeystonePlayerInfoForNetwork
	{
		// Token: 0x06003ACD RID: 15053 RVA: 0x00020B62 File Offset: 0x0001ED62
		public KeystonePlayerInfoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x00020B70 File Offset: 0x0001ED70
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00020B78 File Offset: 0x0001ED78
		public ulong AccountSUID { get; set; }

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x00020B81 File Offset: 0x0001ED81
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x00020B89 File Offset: 0x0001ED89
		public ulong BucketID { get; set; }

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00020B92 File Offset: 0x0001ED92
		// (set) Token: 0x06003AD3 RID: 15059 RVA: 0x00020B9A File Offset: 0x0001ED9A
		public string Username { get; set; }

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x00020BAB File Offset: 0x0001EDAB
		public string GuildTag { get; set; }

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public string GuildName { get; set; }

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x00020BC5 File Offset: 0x0001EDC5
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x00020BCD File Offset: 0x0001EDCD
		public uint Level { get; set; }

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		// (set) Token: 0x06003ADB RID: 15067 RVA: 0x00020BDE File Offset: 0x0001EDDE
		public ulong RunningScore { get; set; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x00020BE7 File Offset: 0x0001EDE7
		// (set) Token: 0x06003ADD RID: 15069 RVA: 0x00020BEF File Offset: 0x0001EDEF
		public uint Rank { get; set; }

		// Token: 0x06003ADE RID: 15070 RVA: 0x001117B0 File Offset: 0x0010F9B0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BucketID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RunningScore);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Rank);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00111848 File Offset: 0x0010FA48
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.RunningScore = ArrayManager.ReadUInt64(data, ref num);
			this.Rank = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x001118C8 File Offset: 0x0010FAC8
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.BucketID = 0UL;
			this.Username = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Level = 0u;
			this.RunningScore = 0UL;
			this.Rank = 0u;
		}
	}
}
