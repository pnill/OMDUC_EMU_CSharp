using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005FB RID: 1531
	public class AchievementForNetwork
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x0001CDFE File Offset: 0x0001AFFE
		public AchievementForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x0001CE0C File Offset: 0x0001B00C
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x0001CE14 File Offset: 0x0001B014
		public ulong AchievementGUID { get; set; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x0001CE1D File Offset: 0x0001B01D
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x0001CE25 File Offset: 0x0001B025
		public bool Completed { get; set; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x0001CE2E File Offset: 0x0001B02E
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x0001CE36 File Offset: 0x0001B036
		public List<AchievementTaskForNetwork> AchievementTasksForNetwork { get; set; }

		// Token: 0x0600354E RID: 13646 RVA: 0x00109044 File Offset: 0x00107244
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AchievementGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Completed);
			ArrayManager.WriteListAchievementTaskForNetwork(ref newArray, ref newSize, this.AchievementTasksForNetwork);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00109090 File Offset: 0x00107290
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Completed = ArrayManager.ReadBoolean(data, ref num);
			this.AchievementTasksForNetwork = ArrayManager.ReadListAchievementTaskForNetwork(data, ref num);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0001CE3F File Offset: 0x0001B03F
		private void InitRefTypes()
		{
			this.AchievementGUID = 0UL;
			this.Completed = false;
			this.AchievementTasksForNetwork = new List<AchievementTaskForNetwork>();
		}
	}
}
