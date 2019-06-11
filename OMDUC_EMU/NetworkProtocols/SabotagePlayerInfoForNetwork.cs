using System;

namespace NetworkProtocols
{
	// Token: 0x0200067B RID: 1659
	public class SabotagePlayerInfoForNetwork
	{
		// Token: 0x06003A1F RID: 14879 RVA: 0x000202C9 File Offset: 0x0001E4C9
		public SabotagePlayerInfoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x000202D7 File Offset: 0x0001E4D7
		// (set) Token: 0x06003A21 RID: 14881 RVA: 0x000202DF File Offset: 0x0001E4DF
		public ulong AccountSUID { get; set; }

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x000202E8 File Offset: 0x0001E4E8
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x000202F0 File Offset: 0x0001E4F0
		public string PlayerName { get; set; }

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x000202F9 File Offset: 0x0001E4F9
		// (set) Token: 0x06003A25 RID: 14885 RVA: 0x00020301 File Offset: 0x0001E501
		public string GuildName { get; set; }

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x0002030A File Offset: 0x0001E50A
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x00020312 File Offset: 0x0001E512
		public string GuildTag { get; set; }

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x0002031B File Offset: 0x0001E51B
		// (set) Token: 0x06003A29 RID: 14889 RVA: 0x00020323 File Offset: 0x0001E523
		public double MMRValue { get; set; }

		// Token: 0x06003A2A RID: 14890 RVA: 0x001106CC File Offset: 0x0010E8CC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.MMRValue);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x00110738 File Offset: 0x0010E938
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.MMRValue = ArrayManager.ReadDouble(data, ref num);
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x0002032C File Offset: 0x0001E52C
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			this.GuildName = string.Empty;
			this.GuildTag = string.Empty;
			this.MMRValue = 0.0;
		}
	}
}
