using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005C4 RID: 1476
	public class PushCompletedQuests : BotNetMessage
	{
		// Token: 0x06003375 RID: 13173 RVA: 0x0001BC80 File Offset: 0x00019E80
		public PushCompletedQuests()
		{
			this.InitRefTypes();
			base.PacketType = 2981829448u;
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0001BC99 File Offset: 0x00019E99
		public PushCompletedQuests(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2981829448u;
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x0001BCB9 File Offset: 0x00019EB9
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x0001BCC1 File Offset: 0x00019EC1
		public List<QuestForNetwork> Quests { get; set; }

		// Token: 0x06003379 RID: 13177 RVA: 0x00106670 File Offset: 0x00104870
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

		// Token: 0x0600337A RID: 13178 RVA: 0x001066F0 File Offset: 0x001048F0
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

		// Token: 0x0600337B RID: 13179 RVA: 0x0001BCCA File Offset: 0x00019ECA
		private void InitRefTypes()
		{
			this.Quests = new List<QuestForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001CA2 RID: 7330
		public const uint cPacketType = 2981829448u;
	}
}
