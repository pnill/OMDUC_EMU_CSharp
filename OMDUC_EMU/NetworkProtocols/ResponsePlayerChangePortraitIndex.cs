using System;

namespace NetworkProtocols
{
	// Token: 0x02000581 RID: 1409
	public class ResponsePlayerChangePortraitIndex : BotNetMessage
	{
		// Token: 0x06003077 RID: 12407 RVA: 0x00019DC1 File Offset: 0x00017FC1
		public ResponsePlayerChangePortraitIndex()
		{
			this.InitRefTypes();
			base.PacketType = 665343859u;
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00019DDA File Offset: 0x00017FDA
		public ResponsePlayerChangePortraitIndex(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 665343859u;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x00019DFA File Offset: 0x00017FFA
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x00019E02 File Offset: 0x00018002
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x00019E0B File Offset: 0x0001800B
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x00019E13 File Offset: 0x00018013
		public ulong Value { get; set; }

		// Token: 0x0600307D RID: 12413 RVA: 0x00102784 File Offset: 0x00100984
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

		// Token: 0x0600307E RID: 12414 RVA: 0x00102810 File Offset: 0x00100A10
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

		// Token: 0x0600307F RID: 12415 RVA: 0x00019E1C File Offset: 0x0001801C
		private void InitRefTypes()
		{
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B96 RID: 7062
		public const uint cPacketType = 665343859u;
	}
}
