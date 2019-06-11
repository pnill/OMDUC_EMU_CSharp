using System;

namespace NetworkProtocols
{
	// Token: 0x02000568 RID: 1384
	public class CommunityEventGoalAwardItem : BaseAwardItem
	{
		// Token: 0x06002F22 RID: 12066 RVA: 0x00019069 File Offset: 0x00017269
		public CommunityEventGoalAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 139461025u;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x00019082 File Offset: 0x00017282
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x0001908A File Offset: 0x0001728A
		public ulong AccountSUID { get; set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x00019093 File Offset: 0x00017293
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x0001909B File Offset: 0x0001729B
		public ulong EventID { get; set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x000190A4 File Offset: 0x000172A4
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x000190AC File Offset: 0x000172AC
		public ulong GoalID { get; set; }

		// Token: 0x06002F29 RID: 12073 RVA: 0x00100A28 File Offset: 0x000FEC28
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
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

		// Token: 0x06002F2A RID: 12074 RVA: 0x00100AA8 File Offset: 0x000FECA8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000190B5 File Offset: 0x000172B5
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
		}
	}
}
