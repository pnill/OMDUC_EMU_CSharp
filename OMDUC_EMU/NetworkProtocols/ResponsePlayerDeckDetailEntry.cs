using System;

namespace NetworkProtocols
{
	// Token: 0x02000585 RID: 1413
	public class ResponsePlayerDeckDetailEntry
	{
		// Token: 0x060030AB RID: 12459 RVA: 0x00019FD6 File Offset: 0x000181D6
		public ResponsePlayerDeckDetailEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x00019FE4 File Offset: 0x000181E4
		// (set) Token: 0x060030AD RID: 12461 RVA: 0x00019FEC File Offset: 0x000181EC
		public ulong InventoryItemGUID { get; set; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x00019FF5 File Offset: 0x000181F5
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x00019FFD File Offset: 0x000181FD
		public uint Slot { get; set; }

		// Token: 0x060030B0 RID: 12464 RVA: 0x00102BB4 File Offset: 0x00100DB4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InventoryItemGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Slot);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00102BF0 File Offset: 0x00100DF0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InventoryItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Slot = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0001A006 File Offset: 0x00018206
		private void InitRefTypes()
		{
			this.InventoryItemGUID = 0UL;
			this.Slot = 0u;
		}
	}
}
