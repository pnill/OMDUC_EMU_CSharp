using System;

namespace NetworkProtocols
{
	// Token: 0x02000597 RID: 1431
	public class StoreDataPrice
	{
		// Token: 0x0600318B RID: 12683 RVA: 0x0001A959 File Offset: 0x00018B59
		public StoreDataPrice()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x0001A967 File Offset: 0x00018B67
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x0001A96F File Offset: 0x00018B6F
		public ePriceCurrencyType CurrencyType { get; set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x0001A978 File Offset: 0x00018B78
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x0001A980 File Offset: 0x00018B80
		public decimal Amount { get; set; }

		// Token: 0x06003190 RID: 12688 RVA: 0x001040AC File Offset: 0x001022AC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.CurrencyType);
			ArrayManager.WriteDecimal(ref newArray, ref newSize, this.Amount);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x001040E8 File Offset: 0x001022E8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.CurrencyType = ArrayManager.ReadePriceCurrencyType(data, ref num);
			this.Amount = ArrayManager.ReadDecimal(data, ref num);
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0001A989 File Offset: 0x00018B89
		private void InitRefTypes()
		{
			this.CurrencyType = ePriceCurrencyType.None;
			this.Amount = 0m;
		}
	}
}
