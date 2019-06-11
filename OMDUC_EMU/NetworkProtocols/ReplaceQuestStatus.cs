using System;

namespace NetworkProtocols
{
	// Token: 0x020005C0 RID: 1472
	public class ReplaceQuestStatus
	{
		// Token: 0x06003355 RID: 13141 RVA: 0x0001BB26 File Offset: 0x00019D26
		public ReplaceQuestStatus()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x0001BB34 File Offset: 0x00019D34
		// (set) Token: 0x06003357 RID: 13143 RVA: 0x0001BB3C File Offset: 0x00019D3C
		public ulong QuestGUID { get; set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x0001BB45 File Offset: 0x00019D45
		// (set) Token: 0x06003359 RID: 13145 RVA: 0x0001BB4D File Offset: 0x00019D4D
		public eQuestOperationStatus Status { get; set; }

		// Token: 0x0600335A RID: 13146 RVA: 0x001063B4 File Offset: 0x001045B4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.QuestGUID);
			ArrayManager.WriteeQuestOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x001063F0 File Offset: 0x001045F0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.QuestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeQuestOperationStatus(data, ref num);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x0001BB56 File Offset: 0x00019D56
		private void InitRefTypes()
		{
			this.QuestGUID = 0UL;
			this.Status = eQuestOperationStatus.Failure;
		}
	}
}
