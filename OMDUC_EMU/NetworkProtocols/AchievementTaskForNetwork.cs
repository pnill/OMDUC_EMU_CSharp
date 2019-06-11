using System;

namespace NetworkProtocols
{
	// Token: 0x020005FC RID: 1532
	public class AchievementTaskForNetwork
	{
		// Token: 0x06003551 RID: 13649 RVA: 0x0001CE5B File Offset: 0x0001B05B
		public AchievementTaskForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x0001CE69 File Offset: 0x0001B069
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x0001CE71 File Offset: 0x0001B071
		public uint TaskGUID { get; set; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x0001CE7A File Offset: 0x0001B07A
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x0001CE82 File Offset: 0x0001B082
		public bool Completed { get; set; }

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x0001CE8B File Offset: 0x0001B08B
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x0001CE93 File Offset: 0x0001B093
		public ulong Numerator { get; set; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x0001CE9C File Offset: 0x0001B09C
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x0001CEA4 File Offset: 0x0001B0A4
		public ulong Denominator { get; set; }

		// Token: 0x0600355A RID: 13658 RVA: 0x001090CC File Offset: 0x001072CC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TaskGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Completed);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Numerator);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Denominator);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00109128 File Offset: 0x00107328
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.TaskGUID = ArrayManager.ReadUInt32(data, ref num);
			this.Completed = ArrayManager.ReadBoolean(data, ref num);
			this.Numerator = ArrayManager.ReadUInt64(data, ref num);
			this.Denominator = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0001CEAD File Offset: 0x0001B0AD
		private void InitRefTypes()
		{
			this.TaskGUID = 0u;
			this.Completed = false;
			this.Numerator = 0UL;
			this.Denominator = 0UL;
		}
	}
}
