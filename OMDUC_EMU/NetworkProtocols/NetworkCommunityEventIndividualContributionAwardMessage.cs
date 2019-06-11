using System;

namespace NetworkProtocols
{
	// Token: 0x02000633 RID: 1587
	public class NetworkCommunityEventIndividualContributionAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x06003739 RID: 14137 RVA: 0x0001E43E File Offset: 0x0001C63E
		public NetworkCommunityEventIndividualContributionAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4161863552u;
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x0001E457 File Offset: 0x0001C657
		// (set) Token: 0x0600373B RID: 14139 RVA: 0x0001E45F File Offset: 0x0001C65F
		public ulong EventID { get; set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x0001E468 File Offset: 0x0001C668
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x0001E470 File Offset: 0x0001C670
		public ulong GoalID { get; set; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x0001E479 File Offset: 0x0001C679
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x0001E481 File Offset: 0x0001C681
		public ulong ContributionID { get; set; }

		// Token: 0x06003740 RID: 14144 RVA: 0x0010C2A0 File Offset: 0x0010A4A0
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.ContributionID);
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

		// Token: 0x06003741 RID: 14145 RVA: 0x0010C320 File Offset: 0x0010A520
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.ContributionID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0001E48A File Offset: 0x0001C68A
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.ContributionID = 0UL;
		}
	}
}
