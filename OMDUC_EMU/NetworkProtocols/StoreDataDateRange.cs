using System;

namespace NetworkProtocols
{
	// Token: 0x02000599 RID: 1433
	public class StoreDataDateRange
	{
		// Token: 0x0600319B RID: 12699 RVA: 0x0001A9E2 File Offset: 0x00018BE2
		public StoreDataDateRange()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x0001A9F0 File Offset: 0x00018BF0
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		public string StartDate { get; set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x0001AA01 File Offset: 0x00018C01
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x0001AA09 File Offset: 0x00018C09
		public string EndDate { get; set; }

		// Token: 0x060031A0 RID: 12704 RVA: 0x0010417C File Offset: 0x0010237C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.StartDate);
			ArrayManager.WriteString(ref newArray, ref newSize, this.EndDate);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x001041B8 File Offset: 0x001023B8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.StartDate = ArrayManager.ReadString(data, ref num);
			this.EndDate = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0001AA12 File Offset: 0x00018C12
		private void InitRefTypes()
		{
			this.StartDate = string.Empty;
			this.EndDate = string.Empty;
		}
	}
}
