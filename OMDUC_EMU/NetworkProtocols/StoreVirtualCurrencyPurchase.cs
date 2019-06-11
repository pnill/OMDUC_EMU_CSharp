using System;

namespace NetworkProtocols
{
	// Token: 0x02000545 RID: 1349
	public class StoreVirtualCurrencyPurchase : BaseAwardItem
	{
		// Token: 0x06002DF6 RID: 11766 RVA: 0x0001859E File Offset: 0x0001679E
		public StoreVirtualCurrencyPurchase()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3397734902u;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x000185B7 File Offset: 0x000167B7
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x000185BF File Offset: 0x000167BF
		public ulong OfferID { get; set; }

		// Token: 0x06002DF9 RID: 11769 RVA: 0x000FF2A0 File Offset: 0x000FD4A0
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

		// Token: 0x06002DFA RID: 11770 RVA: 0x000FF300 File Offset: 0x000FD500
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x000185C8 File Offset: 0x000167C8
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
		}
	}
}
