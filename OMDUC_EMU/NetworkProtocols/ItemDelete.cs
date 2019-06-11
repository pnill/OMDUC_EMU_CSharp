using System;

namespace NetworkProtocols
{
	// Token: 0x02000511 RID: 1297
	public class ItemDelete : BaseAwardEntry
	{
		// Token: 0x06002CEC RID: 11500 RVA: 0x00017D9F File Offset: 0x00015F9F
		public ItemDelete()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3531377965u;
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x00017DB8 File Offset: 0x00015FB8
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x00017DC0 File Offset: 0x00015FC0
		public ulong AwardInventoryGUID { get; set; }

		// Token: 0x06002CEF RID: 11503 RVA: 0x000FE620 File Offset: 0x000FC820
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

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000FE680 File Offset: 0x000FC880
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AwardInventoryGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00017DC9 File Offset: 0x00015FC9
		private void InitRefTypes()
		{
			this.AwardInventoryGUID = 0UL;
		}
	}
}
