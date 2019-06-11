using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005C5 RID: 1477
	public class PushCanceledQuests : BotNetMessage
	{
		// Token: 0x0600337C RID: 13180 RVA: 0x0001BCDE File Offset: 0x00019EDE
		public PushCanceledQuests()
		{
			this.InitRefTypes();
			base.PacketType = 3125105559u;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x0001BCF7 File Offset: 0x00019EF7
		public PushCanceledQuests(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3125105559u;
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x0001BD17 File Offset: 0x00019F17
		// (set) Token: 0x0600337F RID: 13183 RVA: 0x0001BD1F File Offset: 0x00019F1F
		public List<QuestForNetwork> Quests { get; set; }

		// Token: 0x06003380 RID: 13184 RVA: 0x00106758 File Offset: 0x00104958
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteListQuestForNetwork(ref newArray, ref newSize, this.Quests);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x001067D8 File Offset: 0x001049D8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Quests = ArrayManager.ReadListQuestForNetwork(data, ref num);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x0001BD28 File Offset: 0x00019F28
		private void InitRefTypes()
		{
			this.Quests = new List<QuestForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001CA4 RID: 7332
		public const uint cPacketType = 3125105559u;
	}
}
