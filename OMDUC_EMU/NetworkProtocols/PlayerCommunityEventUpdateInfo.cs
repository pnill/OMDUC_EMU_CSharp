using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004A0 RID: 1184
	public class PlayerCommunityEventUpdateInfo
	{
		// Token: 0x06002A7A RID: 10874 RVA: 0x000163EF File Offset: 0x000145EF
		public PlayerCommunityEventUpdateInfo()
		{
			this.InitRefTypes();
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000163FD File Offset: 0x000145FD
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x00016405 File Offset: 0x00014605
		public ulong EventID { get; set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x0001640E File Offset: 0x0001460E
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x00016416 File Offset: 0x00014616
		public bool FullEventCompletedSuccess { get; set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x0001641F File Offset: 0x0001461F
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x00016427 File Offset: 0x00014627
		public bool FullEventCompletedFailure { get; set; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x00016430 File Offset: 0x00014630
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x00016438 File Offset: 0x00014638
		public bool PartialEventCompletedSuccess { get; set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x00016441 File Offset: 0x00014641
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x00016449 File Offset: 0x00014649
		public bool PartialEventCompletedFailure { get; set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x00016452 File Offset: 0x00014652
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0001645A File Offset: 0x0001465A
		public List<PlayerCommunityGoalUpdateInfo> GoalContributions { get; set; }

		// Token: 0x06002A87 RID: 10887 RVA: 0x000FB6D0 File Offset: 0x000F98D0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EventID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FullEventCompletedSuccess);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FullEventCompletedFailure);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.PartialEventCompletedSuccess);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.PartialEventCompletedFailure);
			ArrayManager.WriteListPlayerCommunityGoalUpdateInfo(ref newArray, ref newSize, this.GoalContributions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000FB748 File Offset: 0x000F9948
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.FullEventCompletedSuccess = ArrayManager.ReadBoolean(data, ref num);
			this.FullEventCompletedFailure = ArrayManager.ReadBoolean(data, ref num);
			this.PartialEventCompletedSuccess = ArrayManager.ReadBoolean(data, ref num);
			this.PartialEventCompletedFailure = ArrayManager.ReadBoolean(data, ref num);
			this.GoalContributions = ArrayManager.ReadListPlayerCommunityGoalUpdateInfo(data, ref num);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00016463 File Offset: 0x00014663
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.FullEventCompletedSuccess = false;
			this.FullEventCompletedFailure = false;
			this.PartialEventCompletedSuccess = false;
			this.PartialEventCompletedFailure = false;
			this.GoalContributions = new List<PlayerCommunityGoalUpdateInfo>();
		}
	}
}
