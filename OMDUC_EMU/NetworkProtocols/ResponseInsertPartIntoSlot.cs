using System;

namespace NetworkProtocols
{
	// Token: 0x0200057E RID: 1406
	public class ResponseInsertPartIntoSlot : BotNetMessage
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x00019C81 File Offset: 0x00017E81
		public ResponseInsertPartIntoSlot()
		{
			this.InitRefTypes();
			base.PacketType = 1556993237u;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00019C9A File Offset: 0x00017E9A
		public ResponseInsertPartIntoSlot(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1556993237u;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x00019CBA File Offset: 0x00017EBA
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x00019CC2 File Offset: 0x00017EC2
		public bool WasPartInserted { get; set; }

		// Token: 0x06003062 RID: 12386 RVA: 0x00102494 File Offset: 0x00100694
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.WasPartInserted);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00102514 File Offset: 0x00100714
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.WasPartInserted = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00019CCB File Offset: 0x00017ECB
		private void InitRefTypes()
		{
			this.WasPartInserted = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B8E RID: 7054
		public const uint cPacketType = 1556993237u;
	}
}
