using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005C3 RID: 1475
	public class PushActiveQuests : BotNetMessage
	{
		// Token: 0x0600336C RID: 13164 RVA: 0x0001BC06 File Offset: 0x00019E06
		public PushActiveQuests()
		{
			this.InitRefTypes();
			base.PacketType = 588538868u;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0001BC1F File Offset: 0x00019E1F
		public PushActiveQuests(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 588538868u;
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x0001BC3F File Offset: 0x00019E3F
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x0001BC47 File Offset: 0x00019E47
		public List<CanReplaceQuests> CanReplaceQuests { get; set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x0001BC50 File Offset: 0x00019E50
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x0001BC58 File Offset: 0x00019E58
		public List<QuestForNetwork> Quests { get; set; }

		// Token: 0x06003372 RID: 13170 RVA: 0x0010656C File Offset: 0x0010476C
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
			ArrayManager.WriteListCanReplaceQuests(ref newArray, ref newSize, this.CanReplaceQuests);
			ArrayManager.WriteListQuestForNetwork(ref newArray, ref newSize, this.Quests);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x001065F8 File Offset: 0x001047F8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CanReplaceQuests = ArrayManager.ReadListCanReplaceQuests(data, ref num);
			this.Quests = ArrayManager.ReadListQuestForNetwork(data, ref num);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x0001BC61 File Offset: 0x00019E61
		private void InitRefTypes()
		{
			this.CanReplaceQuests = new List<CanReplaceQuests>();
			this.Quests = new List<QuestForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C9F RID: 7327
		public const uint cPacketType = 588538868u;
	}
}
