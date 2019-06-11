using System;

namespace NetworkProtocols
{
	// Token: 0x020005B9 RID: 1465
	public class EventChestProtoItem
	{
		// Token: 0x060032F3 RID: 13043 RVA: 0x0001B733 File Offset: 0x00019933
		public EventChestProtoItem()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x0001B741 File Offset: 0x00019941
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x0001B749 File Offset: 0x00019949
		public ulong InventoryItemGUID { get; set; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x0001B752 File Offset: 0x00019952
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x0001B75A File Offset: 0x0001995A
		public uint Quantity { get; set; }

		// Token: 0x060032F8 RID: 13048 RVA: 0x00105AEC File Offset: 0x00103CEC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InventoryItemGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Quantity);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00105B28 File Offset: 0x00103D28
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InventoryItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Quantity = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0001B763 File Offset: 0x00019963
		private void InitRefTypes()
		{
			this.InventoryItemGUID = 0UL;
			this.Quantity = 0u;
		}
	}
}
