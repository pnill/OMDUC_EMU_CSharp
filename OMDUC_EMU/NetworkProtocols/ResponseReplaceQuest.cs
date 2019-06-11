using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005C1 RID: 1473
	public class ResponseReplaceQuest : BotNetMessage
	{
		// Token: 0x0600335D RID: 13149 RVA: 0x0001BB67 File Offset: 0x00019D67
		public ResponseReplaceQuest()
		{
			this.InitRefTypes();
			base.PacketType = 2554494830u;
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0001BB80 File Offset: 0x00019D80
		public ResponseReplaceQuest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2554494830u;
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		public List<ReplaceQuestStatus> ReplaceQuestStatus { get; set; }

		// Token: 0x06003361 RID: 13153 RVA: 0x0010641C File Offset: 0x0010461C
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
			ArrayManager.WriteListReplaceQuestStatus(ref newArray, ref newSize, this.ReplaceQuestStatus);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x0010649C File Offset: 0x0010469C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ReplaceQuestStatus = ArrayManager.ReadListReplaceQuestStatus(data, ref num);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x0001BBB1 File Offset: 0x00019DB1
		private void InitRefTypes()
		{
			this.ReplaceQuestStatus = new List<ReplaceQuestStatus>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C9B RID: 7323
		public const uint cPacketType = 2554494830u;
	}
}
