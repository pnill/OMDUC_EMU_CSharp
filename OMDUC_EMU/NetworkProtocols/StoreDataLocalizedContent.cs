using System;

namespace NetworkProtocols
{
	// Token: 0x0200059B RID: 1435
	public class StoreDataLocalizedContent
	{
		// Token: 0x060031C1 RID: 12737 RVA: 0x0001AB15 File Offset: 0x00018D15
		public StoreDataLocalizedContent()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x0001AB23 File Offset: 0x00018D23
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x0001AB2B File Offset: 0x00018D2B
		public string Locale { get; set; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x0001AB34 File Offset: 0x00018D34
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x0001AB3C File Offset: 0x00018D3C
		public string LocalizedString { get; set; }

		// Token: 0x060031C6 RID: 12742 RVA: 0x00104408 File Offset: 0x00102608
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.Locale);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LocalizedString);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00104444 File Offset: 0x00102644
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Locale = ArrayManager.ReadString(data, ref num);
			this.LocalizedString = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x0001AB45 File Offset: 0x00018D45
		private void InitRefTypes()
		{
			this.Locale = string.Empty;
			this.LocalizedString = string.Empty;
		}
	}
}
