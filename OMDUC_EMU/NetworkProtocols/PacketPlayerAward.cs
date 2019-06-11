using System;

namespace NetworkProtocols
{
	// Token: 0x020005A9 RID: 1449
	public class PacketPlayerAward
	{
		// Token: 0x0600326C RID: 12908 RVA: 0x0001B1F0 File Offset: 0x000193F0
		public PacketPlayerAward()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x0001B1FE File Offset: 0x000193FE
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x0001B206 File Offset: 0x00019406
		public ePlayerAwardType AwardType { get; set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x0001B20F File Offset: 0x0001940F
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x0001B217 File Offset: 0x00019417
		public ulong Value { get; set; }

		// Token: 0x06003271 RID: 12913 RVA: 0x001051FC File Offset: 0x001033FC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteePlayerAwardType(ref newArray, ref newSize, this.AwardType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x00105238 File Offset: 0x00103438
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AwardType = ArrayManager.ReadePlayerAwardType(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x0001B220 File Offset: 0x00019420
		private void InitRefTypes()
		{
			this.AwardType = ePlayerAwardType.NoReward;
			this.Value = 0UL;
		}
	}
}
