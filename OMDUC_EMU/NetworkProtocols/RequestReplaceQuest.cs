using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005BE RID: 1470
	public class RequestReplaceQuest : BotNetMessage
	{
		// Token: 0x06003349 RID: 13129 RVA: 0x0001BA8F File Offset: 0x00019C8F
		public RequestReplaceQuest()
		{
			this.InitRefTypes();
			base.PacketType = 790618283u;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0001BAA8 File Offset: 0x00019CA8
		public RequestReplaceQuest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 790618283u;
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		public List<ulong> QuestGUIDs { get; set; }

		// Token: 0x0600334D RID: 13133 RVA: 0x001062CC File Offset: 0x001044CC
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
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.QuestGUIDs);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0010634C File Offset: 0x0010454C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.QuestGUIDs = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0001BAD9 File Offset: 0x00019CD9
		private void InitRefTypes()
		{
			this.QuestGUIDs = new List<ulong>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C96 RID: 7318
		public const uint cPacketType = 790618283u;
	}
}
