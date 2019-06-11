using System;

namespace NetworkProtocols
{
	// Token: 0x02000665 RID: 1637
	public class PlayerCommunityEventsIndividualContributionsForNetwork
	{
		// Token: 0x0600392A RID: 14634 RVA: 0x0001F950 File Offset: 0x0001DB50
		public PlayerCommunityEventsIndividualContributionsForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x0001F95E File Offset: 0x0001DB5E
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x0001F966 File Offset: 0x0001DB66
		public ulong CountToReach { get; set; }

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x0001F96F File Offset: 0x0001DB6F
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x0001F977 File Offset: 0x0001DB77
		public BaseAwardItem IndividualContributionRewards { get; set; }

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x0001F980 File Offset: 0x0001DB80
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x0001F988 File Offset: 0x0001DB88
		public ulong ContributionID { get; set; }

		// Token: 0x06003931 RID: 14641 RVA: 0x0010F0E0 File Offset: 0x0010D2E0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CountToReach);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.IndividualContributionRewards);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ContributionID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x0010F12C File Offset: 0x0010D32C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.CountToReach = ArrayManager.ReadUInt64(data, ref num);
			this.IndividualContributionRewards = ArrayManager.ReadBaseAwardItem(data, ref num);
			this.ContributionID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0001F991 File Offset: 0x0001DB91
		private void InitRefTypes()
		{
			this.CountToReach = 0UL;
			this.IndividualContributionRewards = new BaseAwardItem();
			this.ContributionID = 0UL;
		}
	}
}
