using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004A1 RID: 1185
	public class PlayerCommunityGoalUpdateInfo
	{
		// Token: 0x06002A8A RID: 10890 RVA: 0x00016494 File Offset: 0x00014694
		public PlayerCommunityGoalUpdateInfo()
		{
			this.InitRefTypes();
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000164A2 File Offset: 0x000146A2
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x000164AA File Offset: 0x000146AA
		public ulong GoalID { get; set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000164B3 File Offset: 0x000146B3
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x000164BB File Offset: 0x000146BB
		public ulong CurrentCount { get; set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000164C4 File Offset: 0x000146C4
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x000164CC File Offset: 0x000146CC
		public ulong TotalCount { get; set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000164D5 File Offset: 0x000146D5
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x000164DD File Offset: 0x000146DD
		public int GoalPriority { get; set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000164E6 File Offset: 0x000146E6
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x000164EE File Offset: 0x000146EE
		public bool GoalCompletedSuccess { get; set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000164F7 File Offset: 0x000146F7
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x000164FF File Offset: 0x000146FF
		public bool GoalCompletedFailure { get; set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x00016508 File Offset: 0x00014708
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00016510 File Offset: 0x00014710
		public List<PlayerIndividualGoalUpdateInfo> IndividualContributions { get; set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x00016519 File Offset: 0x00014719
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x00016521 File Offset: 0x00014721
		public bool AutoStartAfterPreviousGoal { get; set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x0001652A File Offset: 0x0001472A
		// (set) Token: 0x06002A9C RID: 10908 RVA: 0x00016532 File Offset: 0x00014732
		public bool AutoStartOnlyOnSuccess { get; set; }

		// Token: 0x06002A9D RID: 10909 RVA: 0x000FB7AC File Offset: 0x000F99AC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CurrentCount);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TotalCount);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.GoalPriority);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GoalCompletedSuccess);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GoalCompletedFailure);
			ArrayManager.WriteListPlayerIndividualGoalUpdateInfo(ref newArray, ref newSize, this.IndividualContributions);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.AutoStartAfterPreviousGoal);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.AutoStartOnlyOnSuccess);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000FB854 File Offset: 0x000F9A54
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.CurrentCount = ArrayManager.ReadUInt64(data, ref num);
			this.TotalCount = ArrayManager.ReadUInt64(data, ref num);
			this.GoalPriority = ArrayManager.ReadInt32(data, ref num);
			this.GoalCompletedSuccess = ArrayManager.ReadBoolean(data, ref num);
			this.GoalCompletedFailure = ArrayManager.ReadBoolean(data, ref num);
			this.IndividualContributions = ArrayManager.ReadListPlayerIndividualGoalUpdateInfo(data, ref num);
			this.AutoStartAfterPreviousGoal = ArrayManager.ReadBoolean(data, ref num);
			this.AutoStartOnlyOnSuccess = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000FB8E4 File Offset: 0x000F9AE4
		private void InitRefTypes()
		{
			this.GoalID = 0UL;
			this.CurrentCount = 0UL;
			this.TotalCount = 0UL;
			this.GoalPriority = 0;
			this.GoalCompletedSuccess = false;
			this.GoalCompletedFailure = false;
			this.IndividualContributions = new List<PlayerIndividualGoalUpdateInfo>();
			this.AutoStartAfterPreviousGoal = false;
			this.AutoStartOnlyOnSuccess = false;
		}
	}
}
