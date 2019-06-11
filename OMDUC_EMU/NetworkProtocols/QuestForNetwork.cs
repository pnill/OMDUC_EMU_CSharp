using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005C6 RID: 1478
	public class QuestForNetwork
	{
		// Token: 0x06003383 RID: 13187 RVA: 0x0001BD3C File Offset: 0x00019F3C
		public QuestForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x0001BD4A File Offset: 0x00019F4A
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x0001BD52 File Offset: 0x00019F52
		public ulong QuestGUID { get; set; }

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x0001BD5B File Offset: 0x00019F5B
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x0001BD63 File Offset: 0x00019F63
		public ulong QuestDefinitionGUID { get; set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x0001BD6C File Offset: 0x00019F6C
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x0001BD74 File Offset: 0x00019F74
		public string Icon { get; set; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x0001BD7D File Offset: 0x00019F7D
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x0001BD85 File Offset: 0x00019F85
		public List<QuestTaskForNetwork> QuestTasksForNetwork { get; set; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x0001BD8E File Offset: 0x00019F8E
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x0001BD96 File Offset: 0x00019F96
		public QuestAward AwardItem { get; set; }

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x0001BD9F File Offset: 0x00019F9F
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x0001BDA7 File Offset: 0x00019FA7
		public bool Completed { get; set; }

		// Token: 0x06003390 RID: 13200 RVA: 0x00106840 File Offset: 0x00104A40
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.QuestGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.QuestDefinitionGUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Icon);
			ArrayManager.WriteListQuestTaskForNetwork(ref newArray, ref newSize, this.QuestTasksForNetwork);
			ArrayManager.WriteQuestAward(ref newArray, ref newSize, this.AwardItem);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Completed);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x001068B8 File Offset: 0x00104AB8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.QuestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.QuestDefinitionGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Icon = ArrayManager.ReadString(data, ref num);
			this.QuestTasksForNetwork = ArrayManager.ReadListQuestTaskForNetwork(data, ref num);
			this.AwardItem = ArrayManager.ReadQuestAward(data, ref num);
			this.Completed = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		private void InitRefTypes()
		{
			this.QuestGUID = 0UL;
			this.QuestDefinitionGUID = 0UL;
			this.Icon = string.Empty;
			this.QuestTasksForNetwork = new List<QuestTaskForNetwork>();
			this.AwardItem = new QuestAward();
			this.Completed = false;
		}
	}
}
