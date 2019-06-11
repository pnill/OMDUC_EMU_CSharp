using System;

namespace NetworkProtocols
{
	// Token: 0x020006B7 RID: 1719
	public class BotDetail
	{
		// Token: 0x06003D9D RID: 15773 RVA: 0x0002278E File Offset: 0x0002098E
		public BotDetail()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x0002279C File Offset: 0x0002099C
		// (set) Token: 0x06003D9F RID: 15775 RVA: 0x000227A4 File Offset: 0x000209A4
		public ulong BotGUID { get; set; }

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x000227AD File Offset: 0x000209AD
		// (set) Token: 0x06003DA1 RID: 15777 RVA: 0x000227B5 File Offset: 0x000209B5
		public string BotName { get; set; }

		// Token: 0x06003DA2 RID: 15778 RVA: 0x001156D4 File Offset: 0x001138D4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BotGUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.BotName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00115710 File Offset: 0x00113910
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BotGUID = ArrayManager.ReadUInt64(data, ref num);
			this.BotName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x000227BE File Offset: 0x000209BE
		private void InitRefTypes()
		{
			this.BotGUID = 0UL;
			this.BotName = string.Empty;
		}
	}
}
