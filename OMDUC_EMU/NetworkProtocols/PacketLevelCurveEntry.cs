using System;

namespace NetworkProtocols
{
	// Token: 0x020005AE RID: 1454
	public class PacketLevelCurveEntry
	{
		// Token: 0x06003293 RID: 12947 RVA: 0x0001B3A7 File Offset: 0x000195A7
		public PacketLevelCurveEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x0001B3B5 File Offset: 0x000195B5
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x0001B3BD File Offset: 0x000195BD
		public uint Level { get; set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x0001B3C6 File Offset: 0x000195C6
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x0001B3CE File Offset: 0x000195CE
		public uint XP { get; set; }

		// Token: 0x06003298 RID: 12952 RVA: 0x001055A4 File Offset: 0x001037A4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.XP);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x001055E0 File Offset: 0x001037E0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.XP = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x0001B3D7 File Offset: 0x000195D7
		private void InitRefTypes()
		{
			this.Level = 0u;
			this.XP = 0u;
		}
	}
}
