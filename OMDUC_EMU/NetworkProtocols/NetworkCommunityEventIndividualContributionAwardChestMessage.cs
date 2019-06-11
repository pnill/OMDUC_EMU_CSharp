using System;

namespace NetworkProtocols
{
	// Token: 0x02000634 RID: 1588
	public class NetworkCommunityEventIndividualContributionAwardChestMessage : NetworkPlayerMessage
	{
		// Token: 0x06003743 RID: 14147 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		public NetworkCommunityEventIndividualContributionAwardChestMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2810766173u;
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x0001E4BD File Offset: 0x0001C6BD
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x0001E4C5 File Offset: 0x0001C6C5
		public ulong EventID { get; set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x0001E4CE File Offset: 0x0001C6CE
		// (set) Token: 0x06003747 RID: 14151 RVA: 0x0001E4D6 File Offset: 0x0001C6D6
		public ulong GoalID { get; set; }

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x0001E4DF File Offset: 0x0001C6DF
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x0001E4E7 File Offset: 0x0001C6E7
		public ulong ContributionID { get; set; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0001E4F0 File Offset: 0x0001C6F0
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		public ulong EventChestID { get; set; }

		// Token: 0x0600374C RID: 14156 RVA: 0x0010C378 File Offset: 0x0010A578
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.ContributionID);
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

		// Token: 0x0600374D RID: 14157 RVA: 0x0010C404 File Offset: 0x0010A604
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.ContributionID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0001E501 File Offset: 0x0001C701
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.ContributionID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
