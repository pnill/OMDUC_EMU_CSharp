using System;

namespace NetworkProtocols
{
	// Token: 0x020004A2 RID: 1186
	public class PlayerIndividualGoalUpdateInfo
	{
		// Token: 0x06002AA0 RID: 10912 RVA: 0x0001653B File Offset: 0x0001473B
		public PlayerIndividualGoalUpdateInfo()
		{
			this.InitRefTypes();
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x00016549 File Offset: 0x00014749
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x00016551 File Offset: 0x00014751
		public ulong ContribID { get; set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x0001655A File Offset: 0x0001475A
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x00016562 File Offset: 0x00014762
		public ulong CurrentCount { get; set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x0001656B File Offset: 0x0001476B
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x00016573 File Offset: 0x00014773
		public ulong TotalCount { get; set; }

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000FB938 File Offset: 0x000F9B38
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ContribID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CurrentCount);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TotalCount);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000FB984 File Offset: 0x000F9B84
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ContribID = ArrayManager.ReadUInt64(data, ref num);
			this.CurrentCount = ArrayManager.ReadUInt64(data, ref num);
			this.TotalCount = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0001657C File Offset: 0x0001477C
		private void InitRefTypes()
		{
			this.ContribID = 0UL;
			this.CurrentCount = 0UL;
			this.TotalCount = 0UL;
		}
	}
}
