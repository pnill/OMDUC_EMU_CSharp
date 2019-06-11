using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005B6 RID: 1462
	public class GuildCreationRegex
	{
		// Token: 0x060032D5 RID: 13013 RVA: 0x0001B61E File Offset: 0x0001981E
		public GuildCreationRegex()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x0001B62C File Offset: 0x0001982C
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x0001B634 File Offset: 0x00019834
		public eGuildCreationField Field { get; set; }

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x0001B63D File Offset: 0x0001983D
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x0001B645 File Offset: 0x00019845
		public List<GuildRegexPattern> Patterns { get; set; }

		// Token: 0x060032DA RID: 13018 RVA: 0x00105958 File Offset: 0x00103B58
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeGuildCreationField(ref newArray, ref newSize, this.Field);
			ArrayManager.WriteListGuildRegexPattern(ref newArray, ref newSize, this.Patterns);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00105994 File Offset: 0x00103B94
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Field = ArrayManager.ReadeGuildCreationField(data, ref num);
			this.Patterns = ArrayManager.ReadListGuildRegexPattern(data, ref num);
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0001B64E File Offset: 0x0001984E
		private void InitRefTypes()
		{
			this.Field = eGuildCreationField.None;
			this.Patterns = new List<GuildRegexPattern>();
		}
	}
}
