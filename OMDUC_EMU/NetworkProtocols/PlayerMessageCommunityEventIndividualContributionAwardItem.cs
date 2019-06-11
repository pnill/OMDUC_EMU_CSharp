using System;

namespace NetworkProtocols
{
	// Token: 0x02000562 RID: 1378
	public class PlayerMessageCommunityEventIndividualContributionAwardItem : BaseAwardItem
	{
		// Token: 0x06002EE4 RID: 12004 RVA: 0x00018DEC File Offset: 0x00016FEC
		public PlayerMessageCommunityEventIndividualContributionAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2074030368u;
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x00018E05 File Offset: 0x00017005
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00018E0D File Offset: 0x0001700D
		public ulong AccountSUID { get; set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x00018E16 File Offset: 0x00017016
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x00018E1E File Offset: 0x0001701E
		public ulong EventID { get; set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00018E27 File Offset: 0x00017027
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00018E2F File Offset: 0x0001702F
		public ulong GoalID { get; set; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x00018E38 File Offset: 0x00017038
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x00018E40 File Offset: 0x00017040
		public ulong IndividualContributionID { get; set; }

		// Token: 0x06002EED RID: 12013 RVA: 0x001004FC File Offset: 0x000FE6FC
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

		// Token: 0x06002EEE RID: 12014 RVA: 0x00100588 File Offset: 0x000FE788
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

		// Token: 0x06002EEF RID: 12015 RVA: 0x00018E49 File Offset: 0x00017049
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.IndividualContributionID = 0UL;
		}
	}
}
