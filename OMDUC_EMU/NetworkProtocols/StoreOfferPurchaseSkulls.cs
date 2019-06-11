using System;

namespace NetworkProtocols
{
	// Token: 0x0200051F RID: 1311
	public class StoreOfferPurchaseSkulls : BaseAwardEntry
	{
		// Token: 0x06002D3C RID: 11580 RVA: 0x00018031 File Offset: 0x00016231
		public StoreOfferPurchaseSkulls()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2800248408u;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002D3E RID: 11582 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
