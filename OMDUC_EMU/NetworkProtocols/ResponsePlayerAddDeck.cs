using System;

namespace NetworkProtocols
{
	// Token: 0x02000587 RID: 1415
	public class ResponsePlayerAddDeck : BotNetMessage
	{
		// Token: 0x060030C0 RID: 12480 RVA: 0x0001A0BF File Offset: 0x000182BF
		public ResponsePlayerAddDeck()
		{
			this.InitRefTypes();
			base.PacketType = 727990549u;
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0001A0D8 File Offset: 0x000182D8
		public ResponsePlayerAddDeck(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 727990549u;
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x0001A0F8 File Offset: 0x000182F8
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x0001A100 File Offset: 0x00018300
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x0001A109 File Offset: 0x00018309
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x0001A111 File Offset: 0x00018311
		public ulong Value { get; set; }

		// Token: 0x060030C6 RID: 12486 RVA: 0x00102D5C File Offset: 0x00100F5C
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
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x00102DE8 File Offset: 0x00100FE8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EventCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0001A11A File Offset: 0x0001831A
		private void InitRefTypes()
		{
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BB0 RID: 7088
		public const uint cPacketType = 727990549u;
	}
}
