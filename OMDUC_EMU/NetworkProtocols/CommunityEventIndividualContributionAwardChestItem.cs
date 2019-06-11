using System;

namespace NetworkProtocols
{
	// Token: 0x0200056B RID: 1387
	public class CommunityEventIndividualContributionAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002F44 RID: 12100 RVA: 0x000191CD File Offset: 0x000173CD
		public CommunityEventIndividualContributionAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3483218029u;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x000191E6 File Offset: 0x000173E6
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x000191EE File Offset: 0x000173EE
		public ulong AccountSUID { get; set; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x000191F7 File Offset: 0x000173F7
		// (set) Token: 0x06002F48 RID: 12104 RVA: 0x000191FF File Offset: 0x000173FF
		public ulong EventID { get; set; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x00019208 File Offset: 0x00017408
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x00019210 File Offset: 0x00017410
		public ulong GoalID { get; set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x00019219 File Offset: 0x00017419
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x00019221 File Offset: 0x00017421
		public ulong IndividualContributionID { get; set; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0001922A File Offset: 0x0001742A
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x00019232 File Offset: 0x00017432
		public ulong EventChestID { get; set; }

		// Token: 0x06002F4F RID: 12111 RVA: 0x00100CE8 File Offset: 0x000FEEE8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.IndividualContributionID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestID);
			byte[] array = base.SerializeMessage();
			if (array.Length + num > newArray.Length)
			{
				Array.Resize<byte>(ref newArray, array.Length + num);
			}
			Array.Copy(array, 0, newArray, num, array.Length);
			num += array.Length;
			Array.Resize<byte>(ref newArray, num);
			return newArray;
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00100D84 File Offset: 0x000FEF84
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.IndividualContributionID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x0001923B File Offset: 0x0001743B
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.IndividualContributionID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
