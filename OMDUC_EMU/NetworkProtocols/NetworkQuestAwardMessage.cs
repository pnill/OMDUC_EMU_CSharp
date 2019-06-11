using System;

namespace NetworkProtocols
{
	// Token: 0x0200062F RID: 1583
	public class NetworkQuestAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x06003719 RID: 14105 RVA: 0x0001E30B File Offset: 0x0001C50B
		public NetworkQuestAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 292252294u;
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x0001E324 File Offset: 0x0001C524
		// (set) Token: 0x0600371B RID: 14107 RVA: 0x0001E32C File Offset: 0x0001C52C
		public ulong QuestGUID { get; set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x0001E335 File Offset: 0x0001C535
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x0001E33D File Offset: 0x0001C53D
		public ulong QuestDefinitionGUID { get; set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x0001E346 File Offset: 0x0001C546
		// (set) Token: 0x0600371F RID: 14111 RVA: 0x0001E34E File Offset: 0x0001C54E
		public ulong BucketID { get; set; }

		// Token: 0x06003720 RID: 14112 RVA: 0x0010BFB8 File Offset: 0x0010A1B8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.QuestGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.QuestDefinitionGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
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

		// Token: 0x06003721 RID: 14113 RVA: 0x0010C038 File Offset: 0x0010A238
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.QuestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.QuestDefinitionGUID = ArrayManager.ReadUInt64(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0001E357 File Offset: 0x0001C557
		private void InitRefTypes()
		{
			this.QuestGUID = 0UL;
			this.QuestDefinitionGUID = 0UL;
			this.BucketID = 0UL;
		}
	}
}
