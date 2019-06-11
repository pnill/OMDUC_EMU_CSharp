using System;

namespace NetworkProtocols
{
	// Token: 0x0200056A RID: 1386
	public class CommunityEventIndividualContributionAwardItem : BaseAwardItem
	{
		// Token: 0x06002F38 RID: 12088 RVA: 0x0001914E File Offset: 0x0001734E
		public CommunityEventIndividualContributionAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 73304286u;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x00019167 File Offset: 0x00017367
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x0001916F File Offset: 0x0001736F
		public ulong AccountSUID { get; set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x00019178 File Offset: 0x00017378
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x00019180 File Offset: 0x00017380
		public ulong EventID { get; set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x00019189 File Offset: 0x00017389
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x00019191 File Offset: 0x00017391
		public ulong GoalID { get; set; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x0001919A File Offset: 0x0001739A
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x000191A2 File Offset: 0x000173A2
		public ulong IndividualContributionID { get; set; }

		// Token: 0x06002F41 RID: 12097 RVA: 0x00100BF4 File Offset: 0x000FEDF4
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.IndividualContributionID);
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

		// Token: 0x06002F42 RID: 12098 RVA: 0x00100C80 File Offset: 0x000FEE80
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.IndividualContributionID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000191AB File Offset: 0x000173AB
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.IndividualContributionID = 0UL;
		}
	}
}
