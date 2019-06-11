using System;

namespace NetworkProtocols
{
	// Token: 0x02000549 RID: 1353
	public class AchievementAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002E1C RID: 11804 RVA: 0x000186E9 File Offset: 0x000168E9
		public AchievementAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2665923518u;
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00018702 File Offset: 0x00016902
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x0001870A File Offset: 0x0001690A
		public ulong BucketID { get; set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x00018713 File Offset: 0x00016913
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0001871B File Offset: 0x0001691B
		public ulong AchievementGUID { get; set; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x00018724 File Offset: 0x00016924
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0001872C File Offset: 0x0001692C
		public ulong EventChestGUID { get; set; }

		// Token: 0x06002E23 RID: 11811 RVA: 0x000FF638 File Offset: 0x000FD838
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AchievementGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestGUID);
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

		// Token: 0x06002E24 RID: 11812 RVA: 0x000FF6B8 File Offset: 0x000FD8B8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00018735 File Offset: 0x00016935
		private void InitRefTypes()
		{
			this.BucketID = 0UL;
			this.AchievementGUID = 0UL;
			this.EventChestGUID = 0UL;
		}
	}
}
