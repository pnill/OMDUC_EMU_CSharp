using System;

namespace NetworkProtocols
{
	// Token: 0x020004EB RID: 1259
	public class RequestPlayerPostDeckUpdateDetail
	{
		// Token: 0x06002B9A RID: 11162 RVA: 0x0001711A File Offset: 0x0001531A
		public RequestPlayerPostDeckUpdateDetail()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x00017128 File Offset: 0x00015328
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x00017130 File Offset: 0x00015330
		public ulong InventoryProtoGUID { get; set; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x00017139 File Offset: 0x00015339
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x00017141 File Offset: 0x00015341
		public uint Slot { get; set; }

		// Token: 0x06002B9F RID: 11167 RVA: 0x000FCDD4 File Offset: 0x000FAFD4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InventoryProtoGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Slot);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000FCE10 File Offset: 0x000FB010
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InventoryProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Slot = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0001714A File Offset: 0x0001534A
		private void InitRefTypes()
		{
			this.InventoryProtoGUID = 0UL;
			this.Slot = 0u;
		}
	}
}
