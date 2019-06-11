using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000576 RID: 1398
	public class InventoryEntry
	{
		// Token: 0x06002FE9 RID: 12265 RVA: 0x00019803 File Offset: 0x00017A03
		public InventoryEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x00019811 File Offset: 0x00017A11
		// (set) Token: 0x06002FEB RID: 12267 RVA: 0x00019819 File Offset: 0x00017A19
		public ulong InventoryProtoGUID { get; set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x00019822 File Offset: 0x00017A22
		// (set) Token: 0x06002FED RID: 12269 RVA: 0x0001982A File Offset: 0x00017A2A
		public ulong Count { get; set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x00019833 File Offset: 0x00017A33
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x0001983B File Offset: 0x00017A3B
		public bool IsBanned { get; set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x00019844 File Offset: 0x00017A44
		// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x0001984C File Offset: 0x00017A4C
		public bool DoesOwn { get; set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x00019855 File Offset: 0x00017A55
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x0001985D File Offset: 0x00017A5D
		public eInventoryProtoType InventoryProtoType { get; set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x00019866 File Offset: 0x00017A66
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x0001986E File Offset: 0x00017A6E
		public bool NewItem { get; set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x00019877 File Offset: 0x00017A77
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x0001987F File Offset: 0x00017A7F
		public bool AlwaysOwned { get; set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x00019888 File Offset: 0x00017A88
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x00019890 File Offset: 0x00017A90
		public bool IsUpgradable { get; set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x00019899 File Offset: 0x00017A99
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x000198A1 File Offset: 0x00017AA1
		public uint Strength { get; set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000198AA File Offset: 0x00017AAA
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x000198B2 File Offset: 0x00017AB2
		public List<ulong> Slots { get; set; }

		// Token: 0x06002FFE RID: 12286 RVA: 0x00101A80 File Offset: 0x000FFC80
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InventoryProtoGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Count);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsBanned);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DoesOwn);
			ArrayManager.WriteeInventoryProtoType(ref newArray, ref newSize, this.InventoryProtoType);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.NewItem);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.AlwaysOwned);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsUpgradable);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Strength);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.Slots);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00101B34 File Offset: 0x000FFD34
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InventoryProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Count = ArrayManager.ReadUInt64(data, ref num);
			this.IsBanned = ArrayManager.ReadBoolean(data, ref num);
			this.DoesOwn = ArrayManager.ReadBoolean(data, ref num);
			this.InventoryProtoType = ArrayManager.ReadeInventoryProtoType(data, ref num);
			this.NewItem = ArrayManager.ReadBoolean(data, ref num);
			this.AlwaysOwned = ArrayManager.ReadBoolean(data, ref num);
			this.IsUpgradable = ArrayManager.ReadBoolean(data, ref num);
			this.Strength = ArrayManager.ReadUInt32(data, ref num);
			this.Slots = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00101BD0 File Offset: 0x000FFDD0
		private void InitRefTypes()
		{
			this.InventoryProtoGUID = 0UL;
			this.Count = 0UL;
			this.IsBanned = false;
			this.DoesOwn = false;
			this.InventoryProtoType = eInventoryProtoType.None;
			this.NewItem = false;
			this.AlwaysOwned = false;
			this.IsUpgradable = false;
			this.Strength = 0u;
			this.Slots = new List<ulong>();
		}
	}
}
