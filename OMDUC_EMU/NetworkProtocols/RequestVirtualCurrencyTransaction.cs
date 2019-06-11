using System;

namespace NetworkProtocols
{
	// Token: 0x020005A3 RID: 1443
	public class RequestVirtualCurrencyTransaction : BotNetMessage
	{
		// Token: 0x06003229 RID: 12841 RVA: 0x0001AF46 File Offset: 0x00019146
		public RequestVirtualCurrencyTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 141406647u;
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0001AF5F File Offset: 0x0001915F
		public RequestVirtualCurrencyTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 141406647u;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x0001AF7F File Offset: 0x0001917F
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x0001AF87 File Offset: 0x00019187
		public ulong OfferID { get; set; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x0001AF90 File Offset: 0x00019190
		// (set) Token: 0x0600322E RID: 12846 RVA: 0x0001AF98 File Offset: 0x00019198
		public ulong LimitedTimeOfferID { get; set; }

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x0001AFA1 File Offset: 0x000191A1
		// (set) Token: 0x06003230 RID: 12848 RVA: 0x0001AFA9 File Offset: 0x000191A9
		public decimal Price { get; set; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x0001AFB2 File Offset: 0x000191B2
		// (set) Token: 0x06003232 RID: 12850 RVA: 0x0001AFBA File Offset: 0x000191BA
		public ePriceCurrencyType CurrencyType { get; set; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x0001AFC3 File Offset: 0x000191C3
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x0001AFCB File Offset: 0x000191CB
		public int Quantity { get; set; }

		// Token: 0x06003235 RID: 12853 RVA: 0x00104C60 File Offset: 0x00102E60
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LimitedTimeOfferID);
			ArrayManager.WriteDecimal(ref newArray, ref newSize, this.Price);
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.CurrencyType);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.Quantity);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00104D1C File Offset: 0x00102F1C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.LimitedTimeOfferID = ArrayManager.ReadUInt64(data, ref num);
			this.Price = ArrayManager.ReadDecimal(data, ref num);
			this.CurrencyType = ArrayManager.ReadePriceCurrencyType(data, ref num);
			this.Quantity = ArrayManager.ReadInt32(data, ref num);
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x0001AFD4 File Offset: 0x000191D4
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
			this.LimitedTimeOfferID = 0UL;
			this.Price = 0m;
			this.CurrencyType = ePriceCurrencyType.None;
			this.Quantity = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C36 RID: 7222
		public const uint cPacketType = 141406647u;
	}
}
