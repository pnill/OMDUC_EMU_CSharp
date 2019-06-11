using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000666 RID: 1638
	public class PlayerCommunityEventGoalsForNetwork
	{
		// Token: 0x06003934 RID: 14644 RVA: 0x0001F9AE File Offset: 0x0001DBAE
		public PlayerCommunityEventGoalsForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x0001F9C4 File Offset: 0x0001DBC4
		public eGoalType GoalType { get; set; }

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0001F9CD File Offset: 0x0001DBCD
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x0001F9D5 File Offset: 0x0001DBD5
		public eGameType GameType { get; set; }

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0001F9DE File Offset: 0x0001DBDE
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x0001F9E6 File Offset: 0x0001DBE6
		public ulong CountToReach { get; set; }

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x0001F9EF File Offset: 0x0001DBEF
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x0001F9F7 File Offset: 0x0001DBF7
		public string GoalIconName { get; set; }

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x0001FA00 File Offset: 0x0001DC00
		// (set) Token: 0x0600393E RID: 14654 RVA: 0x0001FA08 File Offset: 0x0001DC08
		public string GoalContributionTextSingular { get; set; }

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x0001FA11 File Offset: 0x0001DC11
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x0001FA19 File Offset: 0x0001DC19
		public string GoalContributionTextPlural { get; set; }

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x0001FA22 File Offset: 0x0001DC22
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x0001FA2A File Offset: 0x0001DC2A
		public BaseAwardItem GoalEventRewards { get; set; }

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x0001FA33 File Offset: 0x0001DC33
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x0001FA3B File Offset: 0x0001DC3B
		public ulong GoalID { get; set; }

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x0001FA44 File Offset: 0x0001DC44
		// (set) Token: 0x06003946 RID: 14662 RVA: 0x0001FA4C File Offset: 0x0001DC4C
		public string GoalName { get; set; }

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x0001FA55 File Offset: 0x0001DC55
		// (set) Token: 0x06003948 RID: 14664 RVA: 0x0001FA5D File Offset: 0x0001DC5D
		public string GoalDescription { get; set; }

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0001FA66 File Offset: 0x0001DC66
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x0001FA6E File Offset: 0x0001DC6E
		public DateTime StartDate { get; set; }

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x0001FA77 File Offset: 0x0001DC77
		// (set) Token: 0x0600394C RID: 14668 RVA: 0x0001FA7F File Offset: 0x0001DC7F
		public DateTime EndDate { get; set; }

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x0001FA88 File Offset: 0x0001DC88
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x0001FA90 File Offset: 0x0001DC90
		public bool GoalCompletionSuccess { get; set; }

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0001FA99 File Offset: 0x0001DC99
		// (set) Token: 0x06003950 RID: 14672 RVA: 0x0001FAA1 File Offset: 0x0001DCA1
		public bool GoalCompletionFailure { get; set; }

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0001FAAA File Offset: 0x0001DCAA
		// (set) Token: 0x06003952 RID: 14674 RVA: 0x0001FAB2 File Offset: 0x0001DCB2
		public List<PlayerCommunityEventsIndividualContributionsForNetwork> IndividualContributions { get; set; }

		// Token: 0x06003953 RID: 14675 RVA: 0x0010F168 File Offset: 0x0010D368
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeGoalType(ref newArray, ref newSize, this.GoalType);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CountToReach);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GoalIconName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GoalContributionTextSingular);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GoalContributionTextPlural);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.GoalEventRewards);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GoalID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GoalName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GoalDescription);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.StartDate);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.EndDate);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GoalCompletionSuccess);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GoalCompletionFailure);
			ArrayManager.WriteListPlayerCommunityEventsIndividualContributionsForNetwork(ref newArray, ref newSize, this.IndividualContributions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0010F268 File Offset: 0x0010D468
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GoalType = ArrayManager.ReadeGoalType(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.CountToReach = ArrayManager.ReadUInt64(data, ref num);
			this.GoalIconName = ArrayManager.ReadString(data, ref num);
			this.GoalContributionTextSingular = ArrayManager.ReadString(data, ref num);
			this.GoalContributionTextPlural = ArrayManager.ReadString(data, ref num);
			this.GoalEventRewards = ArrayManager.ReadBaseAwardItem(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalName = ArrayManager.ReadString(data, ref num);
			this.GoalDescription = ArrayManager.ReadString(data, ref num);
			this.StartDate = ArrayManager.ReadDateTime(data, ref num);
			this.EndDate = ArrayManager.ReadDateTime(data, ref num);
			this.GoalCompletionSuccess = ArrayManager.ReadBoolean(data, ref num);
			this.GoalCompletionFailure = ArrayManager.ReadBoolean(data, ref num);
			this.IndividualContributions = ArrayManager.ReadListPlayerCommunityEventsIndividualContributionsForNetwork(data, ref num);
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0010F34C File Offset: 0x0010D54C
		private void InitRefTypes()
		{
			this.GoalType = eGoalType.None;
			this.GameType = eGameType.None;
			this.CountToReach = 0UL;
			this.GoalIconName = string.Empty;
			this.GoalContributionTextSingular = string.Empty;
			this.GoalContributionTextPlural = string.Empty;
			this.GoalEventRewards = new BaseAwardItem();
			this.GoalID = 0UL;
			this.GoalName = string.Empty;
			this.GoalDescription = string.Empty;
			this.StartDate = default(DateTime);
			this.EndDate = default(DateTime);
			this.GoalCompletionSuccess = false;
			this.GoalCompletionFailure = false;
			this.IndividualContributions = new List<PlayerCommunityEventsIndividualContributionsForNetwork>();
		}
	}
}
