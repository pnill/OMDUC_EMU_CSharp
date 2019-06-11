using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000574 RID: 1396
	public class PushPlayerInventoryUpdate : BotNetMessage
	{
		// Token: 0x06002FDB RID: 12251 RVA: 0x00019747 File Offset: 0x00017947
		public PushPlayerInventoryUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 1226402870u;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00019760 File Offset: 0x00017960
		public PushPlayerInventoryUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1226402870u;
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x00019780 File Offset: 0x00017980
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x00019788 File Offset: 0x00017988
		public List<InventoryEntry> Items { get; set; }

		// Token: 0x06002FDF RID: 12255 RVA: 0x001018B0 File Offset: 0x000FFAB0
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
			ArrayManager.WriteListInventoryEntry(ref newArray, ref newSize, this.Items);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00101930 File Offset: 0x000FFB30
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Items = ArrayManager.ReadListInventoryEntry(data, ref num);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x00019791 File Offset: 0x00017991
		private void InitRefTypes()
		{
			this.Items = new List<InventoryEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B5D RID: 7005
		public const uint cPacketType = 1226402870u;
	}
}
