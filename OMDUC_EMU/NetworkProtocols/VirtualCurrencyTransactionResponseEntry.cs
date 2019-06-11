using System;

namespace NetworkProtocols
{
	// Token: 0x020005A4 RID: 1444
	public class VirtualCurrencyTransactionResponseEntry
	{
		// Token: 0x06003238 RID: 12856 RVA: 0x0001B007 File Offset: 0x00019207
		public VirtualCurrencyTransactionResponseEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x0001B015 File Offset: 0x00019215
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x0001B01D File Offset: 0x0001921D
		public ulong OfferID { get; set; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x0001B026 File Offset: 0x00019226
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x0001B02E File Offset: 0x0001922E
		public eVirtualCurrencyTransactionStatus Status { get; set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x0001B037 File Offset: 0x00019237
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x0001B03F File Offset: 0x0001923F
		public PlayerAwardNotification Notification { get; set; }

		// Token: 0x0600323F RID: 12863 RVA: 0x00104DBC File Offset: 0x00102FBC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteeVirtualCurrencyTransactionStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WritePlayerAwardNotification(ref newArray, ref newSize, this.Notification);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x00104E08 File Offset: 0x00103008
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeVirtualCurrencyTransactionStatus(data, ref num);
			this.Notification = ArrayManager.ReadPlayerAwardNotification(data, ref num);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x0001B048 File Offset: 0x00019248
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
			this.Status = eVirtualCurrencyTransactionStatus.Success;
			this.Notification = new PlayerAwardNotification();
		}
	}
}
