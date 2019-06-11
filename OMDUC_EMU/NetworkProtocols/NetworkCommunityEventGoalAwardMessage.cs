using System;

namespace NetworkProtocols
{
	// Token: 0x02000635 RID: 1589
	public class NetworkCommunityEventGoalAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x0600374F RID: 14159 RVA: 0x0001E523 File Offset: 0x0001C723
		public NetworkCommunityEventGoalAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 402948204u;
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x0001E53C File Offset: 0x0001C73C
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x0001E544 File Offset: 0x0001C744
		public ulong EventID { get; set; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0001E54D File Offset: 0x0001C74D
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x0001E555 File Offset: 0x0001C755
		public ulong GoalID { get; set; }

		// Token: 0x06003754 RID: 14164 RVA: 0x0010C46C File Offset: 0x0010A66C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x06003755 RID: 14165 RVA: 0x0010C4DC File Offset: 0x0010A6DC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x0001E55E File Offset: 0x0001C75E
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.GoalID = 0UL;
		}
	}
}
