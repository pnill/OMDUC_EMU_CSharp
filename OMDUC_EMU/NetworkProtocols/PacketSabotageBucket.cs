using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000641 RID: 1601
	public class PacketSabotageBucket
	{
		// Token: 0x060037D2 RID: 14290 RVA: 0x0001EA01 File Offset: 0x0001CC01
		public PacketSabotageBucket()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x0001EA0F File Offset: 0x0001CC0F
		// (set) Token: 0x060037D4 RID: 14292 RVA: 0x0001EA17 File Offset: 0x0001CC17
		public ulong BucketID { get; set; }

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x0001EA20 File Offset: 0x0001CC20
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x0001EA28 File Offset: 0x0001CC28
		public int AverageLevel { get; set; }

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x0001EA31 File Offset: 0x0001CC31
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x0001EA39 File Offset: 0x0001CC39
		public List<ulong> GameMaps { get; set; }

		// Token: 0x060037D9 RID: 14297 RVA: 0x0010CFCC File Offset: 0x0010B1CC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BucketID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.AverageLevel);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.GameMaps);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x0010D018 File Offset: 0x0010B218
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.AverageLevel = ArrayManager.ReadInt32(data, ref num);
			this.GameMaps = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x0001EA42 File Offset: 0x0001CC42
		private void InitRefTypes()
		{
			this.BucketID = 0UL;
			this.AverageLevel = 0;
			this.GameMaps = new List<ulong>();
		}
	}
}
