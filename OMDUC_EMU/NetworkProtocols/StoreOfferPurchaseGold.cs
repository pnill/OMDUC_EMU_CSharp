using System;

namespace NetworkProtocols
{
	// Token: 0x0200051D RID: 1309
	public class StoreOfferPurchaseGold : BaseAwardEntry
	{
		// Token: 0x06002D32 RID: 11570 RVA: 0x00017FE4 File Offset: 0x000161E4
		public StoreOfferPurchaseGold()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3340948683u;
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000FE11C File Offset: 0x000FC31C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x06002D34 RID: 11572 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
