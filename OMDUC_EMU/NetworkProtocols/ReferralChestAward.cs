using System;

namespace NetworkProtocols
{
	// Token: 0x02000541 RID: 1345
	public class ReferralChestAward : BaseAwardItem
	{
		// Token: 0x06002DD6 RID: 11734 RVA: 0x0001846A File Offset: 0x0001666A
		public ReferralChestAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2565207263u;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x00018483 File Offset: 0x00016683
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x0001848B File Offset: 0x0001668B
		public ulong EventChestGUID { get; set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x00018494 File Offset: 0x00016694
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x0001849C File Offset: 0x0001669C
		public eReferralRewardEventType EventType { get; set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x000184A5 File Offset: 0x000166A5
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x000184AD File Offset: 0x000166AD
		public uint EventCount { get; set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x000184B6 File Offset: 0x000166B6
		// (set) Token: 0x06002DDE RID: 11742 RVA: 0x000184BE File Offset: 0x000166BE
		public string ReferralName { get; set; }

		// Token: 0x06002DDF RID: 11743 RVA: 0x000FF038 File Offset: 0x000FD238
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestGUID);
			ArrayManager.WriteeReferralRewardEventType(ref newArray, ref num, this.EventType);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.EventCount);
			ArrayManager.WriteString(ref newArray, ref num, this.ReferralName);
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

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000FF0C4 File Offset: 0x000FD2C4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventType = ArrayManager.ReadeReferralRewardEventType(data, ref num);
			this.EventCount = ArrayManager.ReadUInt32(data, ref num);
			this.ReferralName = ArrayManager.ReadString(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000184C7 File Offset: 0x000166C7
		private void InitRefTypes()
		{
			this.EventChestGUID = 0UL;
			this.EventType = eReferralRewardEventType.None;
			this.EventCount = 0u;
			this.ReferralName = string.Empty;
		}
	}
}
