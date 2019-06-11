using System;

namespace NetworkProtocols
{
	// Token: 0x02000542 RID: 1346
	public class ReferralItemAward : BaseAwardItem
	{
		// Token: 0x06002DE2 RID: 11746 RVA: 0x000184EA File Offset: 0x000166EA
		public ReferralItemAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2387174811u;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x00018503 File Offset: 0x00016703
		// (set) Token: 0x06002DE4 RID: 11748 RVA: 0x0001850B File Offset: 0x0001670B
		public eReferralRewardEventType EventType { get; set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x00018514 File Offset: 0x00016714
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x0001851C File Offset: 0x0001671C
		public uint EventCount { get; set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x00018525 File Offset: 0x00016725
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x0001852D File Offset: 0x0001672D
		public string ReferralName { get; set; }

		// Token: 0x06002DE9 RID: 11753 RVA: 0x000FF12C File Offset: 0x000FD32C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x06002DEA RID: 11754 RVA: 0x000FF1AC File Offset: 0x000FD3AC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventType = ArrayManager.ReadeReferralRewardEventType(data, ref num);
			this.EventCount = ArrayManager.ReadUInt32(data, ref num);
			this.ReferralName = ArrayManager.ReadString(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00018536 File Offset: 0x00016736
		private void InitRefTypes()
		{
			this.EventType = eReferralRewardEventType.None;
			this.EventCount = 0u;
			this.ReferralName = string.Empty;
		}
	}
}
