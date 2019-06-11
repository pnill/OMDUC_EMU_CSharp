using System;

namespace NetworkProtocols
{
	// Token: 0x020005B1 RID: 1457
	public class PacketDailyLoginPeriodEntry
	{
		// Token: 0x060032A8 RID: 12968 RVA: 0x0001B460 File Offset: 0x00019660
		public PacketDailyLoginPeriodEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x0001B46E File Offset: 0x0001966E
		// (set) Token: 0x060032AA RID: 12970 RVA: 0x0001B476 File Offset: 0x00019676
		public uint Day { get; set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x0001B47F File Offset: 0x0001967F
		// (set) Token: 0x060032AC RID: 12972 RVA: 0x0001B487 File Offset: 0x00019687
		public BaseAwardItem AwardItem { get; set; }

		// Token: 0x060032AD RID: 12973 RVA: 0x00105674 File Offset: 0x00103874
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Day);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.AwardItem);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x001056B0 File Offset: 0x001038B0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Day = ArrayManager.ReadUInt32(data, ref num);
			this.AwardItem = ArrayManager.ReadBaseAwardItem(data, ref num);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x0001B490 File Offset: 0x00019690
		private void InitRefTypes()
		{
			this.Day = 0u;
			this.AwardItem = new BaseAwardItem();
		}
	}
}
