using System;

namespace NetworkProtocols
{
	// Token: 0x020004A4 RID: 1188
	public class IndividualPlayerContributionForGoal
	{
		// Token: 0x06002AB2 RID: 10930 RVA: 0x000165DB File Offset: 0x000147DB
		public IndividualPlayerContributionForGoal()
		{
			this.InitRefTypes();
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000165E9 File Offset: 0x000147E9
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x000165F1 File Offset: 0x000147F1
		public ulong GoalID { get; set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000165FA File Offset: 0x000147FA
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x00016602 File Offset: 0x00014802
		public ulong ContributionValue { get; set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0001660B File Offset: 0x0001480B
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x00016613 File Offset: 0x00014813
		public string PlayerName { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x0001661C File Offset: 0x0001481C
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x00016624 File Offset: 0x00014824
		public DateTime ContributionTime { get; set; }

		// Token: 0x06002ABB RID: 10939 RVA: 0x000FBA28 File Offset: 0x000F9C28
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ContributionValue);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.ContributionTime);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000FBA84 File Offset: 0x000F9C84
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.ContributionValue = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.ContributionTime = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000FBACC File Offset: 0x000F9CCC
		private void InitRefTypes()
		{
			this.GoalID = 0UL;
			this.ContributionValue = 0UL;
			this.PlayerName = string.Empty;
			this.ContributionTime = default(DateTime);
		}
	}
}
