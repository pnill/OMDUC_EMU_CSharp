using System;

namespace NetworkProtocols
{
	// Token: 0x020005C2 RID: 1474
	public class CanReplaceQuests
	{
		// Token: 0x06003364 RID: 13156 RVA: 0x0001BBC5 File Offset: 0x00019DC5
		public CanReplaceQuests()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x0001BBD3 File Offset: 0x00019DD3
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x0001BBDB File Offset: 0x00019DDB
		public ulong QuestDefinitionProtoGUID { get; set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x0001BBE4 File Offset: 0x00019DE4
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x0001BBEC File Offset: 0x00019DEC
		public bool CanReplaceQuest { get; set; }

		// Token: 0x06003369 RID: 13161 RVA: 0x00106504 File Offset: 0x00104704
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.QuestDefinitionProtoGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.CanReplaceQuest);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00106540 File Offset: 0x00104740
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.QuestDefinitionProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.CanReplaceQuest = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x0001BBF5 File Offset: 0x00019DF5
		private void InitRefTypes()
		{
			this.QuestDefinitionProtoGUID = 0UL;
			this.CanReplaceQuest = false;
		}
	}
}
