using System;

namespace NetworkProtocols
{
	// Token: 0x02000510 RID: 1296
	public class ItemDebit : BaseAwardEntry
	{
		// Token: 0x06002CE6 RID: 11494 RVA: 0x00017D6B File Offset: 0x00015F6B
		public ItemDebit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3628712547u;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x00017D84 File Offset: 0x00015F84
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x00017D8C File Offset: 0x00015F8C
		public ulong AwardInventoryGUID { get; set; }

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000FE584 File Offset: 0x000FC784
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

		// Token: 0x06002CEA RID: 11498 RVA: 0x000FE5E4 File Offset: 0x000FC7E4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AwardInventoryGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00017D95 File Offset: 0x00015F95
		private void InitRefTypes()
		{
			this.AwardInventoryGUID = 0UL;
		}
	}
}
