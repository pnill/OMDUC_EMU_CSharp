using System;

namespace NetworkProtocols
{
	// Token: 0x0200067E RID: 1662
	public class SabotageGuildInfoForNetwork
	{
		// Token: 0x06003A3D RID: 14909 RVA: 0x00020436 File Offset: 0x0001E636
		public SabotageGuildInfoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x00020444 File Offset: 0x0001E644
		// (set) Token: 0x06003A3F RID: 14911 RVA: 0x0002044C File Offset: 0x0001E64C
		public ulong GuildID { get; set; }

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x00020455 File Offset: 0x0001E655
		// (set) Token: 0x06003A41 RID: 14913 RVA: 0x0002045D File Offset: 0x0001E65D
		public string GuildName { get; set; }

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x00020466 File Offset: 0x0001E666
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x0002046E File Offset: 0x0001E66E
		public string GuildTag { get; set; }

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003A44 RID: 14916 RVA: 0x00020477 File Offset: 0x0001E677
		// (set) Token: 0x06003A45 RID: 14917 RVA: 0x0002047F File Offset: 0x0001E67F
		public double MMRValue { get; set; }

		// Token: 0x06003A46 RID: 14918 RVA: 0x0011097C File Offset: 0x0010EB7C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.MMRValue);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x001109D8 File Offset: 0x0010EBD8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.MMRValue = ArrayManager.ReadDouble(data, ref num);
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x00020488 File Offset: 0x0001E688
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
			this.GuildName = string.Empty;
			this.GuildTag = string.Empty;
			this.MMRValue = 0.0;
		}
	}
}
