using System;

namespace NetworkProtocols
{
	// Token: 0x0200057F RID: 1407
	public class RequestRemovePartFromSlot : BotNetMessage
	{
		// Token: 0x06003065 RID: 12389 RVA: 0x00019CDB File Offset: 0x00017EDB
		public RequestRemovePartFromSlot()
		{
			this.InitRefTypes();
			base.PacketType = 1781460956u;
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00019CF4 File Offset: 0x00017EF4
		public RequestRemovePartFromSlot(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1781460956u;
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x00019D14 File Offset: 0x00017F14
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x00019D1C File Offset: 0x00017F1C
		public ulong TrapProtoGUID { get; set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x00019D25 File Offset: 0x00017F25
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x00019D2D File Offset: 0x00017F2D
		public ulong PartProtoGUID { get; set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x00019D36 File Offset: 0x00017F36
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x00019D3E File Offset: 0x00017F3E
		public uint SlotNumber { get; set; }

		// Token: 0x0600306D RID: 12397 RVA: 0x0010257C File Offset: 0x0010077C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TrapProtoGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartProtoGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SlotNumber);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00102618 File Offset: 0x00100818
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TrapProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.PartProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.SlotNumber = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00019D47 File Offset: 0x00017F47
		private void InitRefTypes()
		{
			this.TrapProtoGUID = 0UL;
			this.PartProtoGUID = 0UL;
			this.SlotNumber = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B90 RID: 7056
		public const uint cPacketType = 1781460956u;
	}
}
