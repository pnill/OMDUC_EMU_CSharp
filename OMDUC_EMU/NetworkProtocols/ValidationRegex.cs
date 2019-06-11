using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005B5 RID: 1461
	public class ValidationRegex
	{
		// Token: 0x060032CD RID: 13005 RVA: 0x0001B5DA File Offset: 0x000197DA
		public ValidationRegex()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x0001B5E8 File Offset: 0x000197E8
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public eValidationField Field { get; set; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x0001B5F9 File Offset: 0x000197F9
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x0001B601 File Offset: 0x00019801
		public List<RegexPattern> Patterns { get; set; }

		// Token: 0x060032D2 RID: 13010 RVA: 0x001058F0 File Offset: 0x00103AF0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeValidationField(ref newArray, ref newSize, this.Field);
			ArrayManager.WriteListRegexPattern(ref newArray, ref newSize, this.Patterns);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x0010592C File Offset: 0x00103B2C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Field = ArrayManager.ReadeValidationField(data, ref num);
			this.Patterns = ArrayManager.ReadListRegexPattern(data, ref num);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0001B60A File Offset: 0x0001980A
		private void InitRefTypes()
		{
			this.Field = eValidationField.None;
			this.Patterns = new List<RegexPattern>();
		}
	}
}
