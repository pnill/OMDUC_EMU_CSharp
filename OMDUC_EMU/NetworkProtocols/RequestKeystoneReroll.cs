using System;

namespace NetworkProtocols
{
	// Token: 0x0200066C RID: 1644
	public class RequestKeystoneReroll : BotNetMessage
	{
		// Token: 0x060039AD RID: 14765 RVA: 0x0001FDFC File Offset: 0x0001DFFC
		public RequestKeystoneReroll()
		{
			this.InitRefTypes();
			base.PacketType = 3720101895u;
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x0001FE15 File Offset: 0x0001E015
		public RequestKeystoneReroll(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3720101895u;
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x0001FE35 File Offset: 0x0001E035
		// (set) Token: 0x060039B0 RID: 14768 RVA: 0x0001FE3D File Offset: 0x0001E03D
		public ulong KeystoneInstanceID { get; set; }

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x0001FE46 File Offset: 0x0001E046
		// (set) Token: 0x060039B2 RID: 14770 RVA: 0x0001FE4E File Offset: 0x0001E04E
		public ulong OfferID { get; set; }

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060039B3 RID: 14771 RVA: 0x0001FE57 File Offset: 0x0001E057
		// (set) Token: 0x060039B4 RID: 14772 RVA: 0x0001FE5F File Offset: 0x0001E05F
		public decimal Price { get; set; }

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060039B5 RID: 14773 RVA: 0x0001FE68 File Offset: 0x0001E068
		// (set) Token: 0x060039B6 RID: 14774 RVA: 0x0001FE70 File Offset: 0x0001E070
		public ePriceCurrencyType CurrencyType { get; set; }

		// Token: 0x060039B7 RID: 14775 RVA: 0x0010FB7C File Offset: 0x0010DD7C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneInstanceID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteDecimal(ref newArray, ref newSize, this.Price);
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.CurrencyType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0010FC28 File Offset: 0x0010DE28
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.KeystoneInstanceID = ArrayManager.ReadUInt64(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.Price = ArrayManager.ReadDecimal(data, ref num);
			this.CurrencyType = ArrayManager.ReadePriceCurrencyType(data, ref num);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0001FE79 File Offset: 0x0001E079
		private void InitRefTypes()
		{
			this.KeystoneInstanceID = 0UL;
			this.OfferID = 0UL;
			this.Price = 0m;
			this.CurrencyType = ePriceCurrencyType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E98 RID: 7832
		public const uint cPacketType = 3720101895u;
	}
}
