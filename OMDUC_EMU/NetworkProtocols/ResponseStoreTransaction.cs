using System;

namespace NetworkProtocols
{
	// Token: 0x020005A2 RID: 1442
	public class ResponseStoreTransaction : BotNetMessage
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x0001AE9E File Offset: 0x0001909E
		public ResponseStoreTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 261889549u;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x0001AEB7 File Offset: 0x000190B7
		public ResponseStoreTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 261889549u;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x0001AED7 File Offset: 0x000190D7
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x0001AEDF File Offset: 0x000190DF
		public ulong TransactionID { get; set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x0001AEE8 File Offset: 0x000190E8
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x0001AEF0 File Offset: 0x000190F0
		public ulong OfferID { get; set; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x0001AEF9 File Offset: 0x000190F9
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x0001AF01 File Offset: 0x00019101
		public string StoreCheckoutURL { get; set; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x0001AF0A File Offset: 0x0001910A
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x0001AF12 File Offset: 0x00019112
		public eStoreTransactionRequestStatus Status { get; set; }

		// Token: 0x06003226 RID: 12838 RVA: 0x00104B20 File Offset: 0x00102D20
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TransactionID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.StoreCheckoutURL);
			ArrayManager.WriteeStoreTransactionRequestStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00104BCC File Offset: 0x00102DCC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TransactionID = ArrayManager.ReadUInt64(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.StoreCheckoutURL = ArrayManager.ReadString(data, ref num);
			this.Status = ArrayManager.ReadeStoreTransactionRequestStatus(data, ref num);
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x0001AF1B File Offset: 0x0001911B
		private void InitRefTypes()
		{
			this.TransactionID = 0UL;
			this.OfferID = 0UL;
			this.StoreCheckoutURL = string.Empty;
			this.Status = eStoreTransactionRequestStatus.Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C31 RID: 7217
		public const uint cPacketType = 261889549u;
	}
}
