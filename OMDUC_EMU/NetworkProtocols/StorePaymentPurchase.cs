using System;

namespace NetworkProtocols
{
	// Token: 0x02000544 RID: 1348
	public class StorePaymentPurchase : BaseAwardItem
	{
		// Token: 0x06002DF0 RID: 11760 RVA: 0x0001856A File Offset: 0x0001676A
		public StorePaymentPurchase()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2897637950u;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00018583 File Offset: 0x00016783
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x0001858B File Offset: 0x0001678B
		public ulong OfferID { get; set; }

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000FF204 File Offset: 0x000FD404
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.OfferID);
			byte[] array = base.SerializeMessage();
			if (array.Length + num > newArray.Length)
			{
				Array.Resize<byte>(ref newArray, array.Length + num);
			}
			Array.Copy(array, 0, newArray, num, array.Length);
			num += array.Length;
			Array.Resize<byte>(ref newArray, num);
			return newArray;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000FF264 File Offset: 0x000FD464
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00018594 File Offset: 0x00016794
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
		}
	}
}
