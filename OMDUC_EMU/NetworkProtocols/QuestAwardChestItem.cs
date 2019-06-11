using System;

namespace NetworkProtocols
{
	// Token: 0x02000547 RID: 1351
	public class QuestAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002E08 RID: 11784 RVA: 0x0001862F File Offset: 0x0001682F
		public QuestAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2003165386u;
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x00018648 File Offset: 0x00016848
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x00018650 File Offset: 0x00016850
		public ulong BucketID { get; set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x00018659 File Offset: 0x00016859
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x00018661 File Offset: 0x00016861
		public ulong QuestGUID { get; set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x0001866A File Offset: 0x0001686A
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x00018672 File Offset: 0x00016872
		public ulong QuestDefinitionGUID { get; set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x0001867B File Offset: 0x0001687B
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x00018683 File Offset: 0x00016883
		public ulong EventChestGUID { get; set; }

		// Token: 0x06002E11 RID: 11793 RVA: 0x000FF464 File Offset: 0x000FD664
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.QuestGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.QuestDefinitionGUID);
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

		// Token: 0x06002E12 RID: 11794 RVA: 0x000FF4F0 File Offset: 0x000FD6F0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.QuestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.QuestDefinitionGUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0001868C File Offset: 0x0001688C
		private void InitRefTypes()
		{
			this.BucketID = 0UL;
			this.QuestGUID = 0UL;
			this.QuestDefinitionGUID = 0UL;
			this.EventChestGUID = 0UL;
		}
	}
}
