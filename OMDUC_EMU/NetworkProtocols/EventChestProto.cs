using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005B8 RID: 1464
	public class EventChestProto
	{
		// Token: 0x060032E5 RID: 13029 RVA: 0x0001B6A2 File Offset: 0x000198A2
		public EventChestProto()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x0001B6B0 File Offset: 0x000198B0
		// (set) Token: 0x060032E7 RID: 13031 RVA: 0x0001B6B8 File Offset: 0x000198B8
		public ulong EventChestGUID { get; set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x0001B6C1 File Offset: 0x000198C1
		// (set) Token: 0x060032E9 RID: 13033 RVA: 0x0001B6C9 File Offset: 0x000198C9
		public List<EventChestProtoItem> Items { get; set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x0001B6D2 File Offset: 0x000198D2
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x0001B6DA File Offset: 0x000198DA
		public bool IsBulkPurchasable { get; set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x0001B6E3 File Offset: 0x000198E3
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x0001B6EB File Offset: 0x000198EB
		public List<int> BulkPurchaseQuantities { get; set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x0001B6F4 File Offset: 0x000198F4
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x0001B6FC File Offset: 0x000198FC
		public bool ShouldShowItems { get; set; }

		// Token: 0x060032F0 RID: 13040 RVA: 0x00105A28 File Offset: 0x00103C28
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EventChestGUID);
			ArrayManager.WriteListEventChestProtoItem(ref newArray, ref newSize, this.Items);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsBulkPurchasable);
			ArrayManager.WriteListInt32(ref newArray, ref newSize, this.BulkPurchaseQuantities);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ShouldShowItems);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x00105A94 File Offset: 0x00103C94
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Items = ArrayManager.ReadListEventChestProtoItem(data, ref num);
			this.IsBulkPurchasable = ArrayManager.ReadBoolean(data, ref num);
			this.BulkPurchaseQuantities = ArrayManager.ReadListInt32(data, ref num);
			this.ShouldShowItems = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x0001B705 File Offset: 0x00019905
		private void InitRefTypes()
		{
			this.EventChestGUID = 0UL;
			this.Items = new List<EventChestProtoItem>();
			this.IsBulkPurchasable = false;
			this.BulkPurchaseQuantities = new List<int>();
			this.ShouldShowItems = false;
		}
	}
}
