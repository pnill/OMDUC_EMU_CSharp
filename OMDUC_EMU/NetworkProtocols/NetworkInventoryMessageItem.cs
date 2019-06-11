using System;

namespace NetworkProtocols
{
	// Token: 0x0200062A RID: 1578
	public class NetworkInventoryMessageItem : NetworkMessageItemBase
	{
		// Token: 0x060036ED RID: 14061 RVA: 0x0001E15B File Offset: 0x0001C35B
		public NetworkInventoryMessageItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2679080640u;
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x0001E174 File Offset: 0x0001C374
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x0001E17C File Offset: 0x0001C37C
		public ulong InventoryProtoGUID { get; set; }

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x0001E185 File Offset: 0x0001C385
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x0001E18D File Offset: 0x0001C38D
		public int Count { get; set; }

		// Token: 0x060036F2 RID: 14066 RVA: 0x0010BBD8 File Offset: 0x00109DD8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.InventoryProtoGUID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.Count);
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

		// Token: 0x060036F3 RID: 14067 RVA: 0x0010BC48 File Offset: 0x00109E48
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InventoryProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Count = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x0001E196 File Offset: 0x0001C396
		private void InitRefTypes()
		{
			this.InventoryProtoGUID = 0UL;
			this.Count = 0;
		}
	}
}
