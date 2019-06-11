using System;

namespace NetworkProtocols
{
	// Token: 0x0200057D RID: 1405
	public class RequestInsertPartIntoSlot : BotNetMessage
	{
		// Token: 0x06003053 RID: 12371 RVA: 0x00019BF5 File Offset: 0x00017DF5
		public RequestInsertPartIntoSlot()
		{
			this.InitRefTypes();
			base.PacketType = 3083392249u;
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00019C0E File Offset: 0x00017E0E
		public RequestInsertPartIntoSlot(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3083392249u;
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x00019C2E File Offset: 0x00017E2E
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x00019C36 File Offset: 0x00017E36
		public ulong TrapProtoGUID { get; set; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x00019C3F File Offset: 0x00017E3F
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x00019C47 File Offset: 0x00017E47
		public ulong PartProtoGUID { get; set; }

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x00019C50 File Offset: 0x00017E50
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x00019C58 File Offset: 0x00017E58
		public uint SlotNumber { get; set; }

		// Token: 0x0600305B RID: 12379 RVA: 0x00102374 File Offset: 0x00100574
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

		// Token: 0x0600305C RID: 12380 RVA: 0x00102410 File Offset: 0x00100610
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

		// Token: 0x0600305D RID: 12381 RVA: 0x00019C61 File Offset: 0x00017E61
		private void InitRefTypes()
		{
			this.TrapProtoGUID = 0UL;
			this.PartProtoGUID = 0UL;
			this.SlotNumber = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B8A RID: 7050
		public const uint cPacketType = 3083392249u;
	}
}
