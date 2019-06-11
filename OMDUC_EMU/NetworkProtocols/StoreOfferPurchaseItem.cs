using System;

namespace NetworkProtocols
{
	// Token: 0x02000520 RID: 1312
	public class StoreOfferPurchaseItem : BaseAwardEntry
	{
		// Token: 0x06002D40 RID: 11584 RVA: 0x0001804A File Offset: 0x0001624A
		public StoreOfferPurchaseItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2677075076u;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x00018063 File Offset: 0x00016263
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x0001806B File Offset: 0x0001626B
		public ulong AwardInventoryGUID { get; set; }

		// Token: 0x06002D43 RID: 11587 RVA: 0x000FEB04 File Offset: 0x000FCD04
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AwardInventoryGUID);
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

		// Token: 0x06002D44 RID: 11588 RVA: 0x000FEB64 File Offset: 0x000FCD64
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AwardInventoryGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00018074 File Offset: 0x00016274
		private void InitRefTypes()
		{
			this.AwardInventoryGUID = 0UL;
		}
	}
}
