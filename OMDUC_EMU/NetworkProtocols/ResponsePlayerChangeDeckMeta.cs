using System;

namespace NetworkProtocols
{
	// Token: 0x02000589 RID: 1417
	public class ResponsePlayerChangeDeckMeta : BotNetMessage
	{
		// Token: 0x060030D2 RID: 12498 RVA: 0x0001A1A5 File Offset: 0x000183A5
		public ResponsePlayerChangeDeckMeta()
		{
			this.InitRefTypes();
			base.PacketType = 1215984841u;
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0001A1BE File Offset: 0x000183BE
		public ResponsePlayerChangeDeckMeta(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1215984841u;
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x0001A1DE File Offset: 0x000183DE
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x0001A1E6 File Offset: 0x000183E6
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x0001A1EF File Offset: 0x000183EF
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x0001A1F7 File Offset: 0x000183F7
		public ulong Value { get; set; }

		// Token: 0x060030D8 RID: 12504 RVA: 0x00102F64 File Offset: 0x00101164
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

		// Token: 0x060030D9 RID: 12505 RVA: 0x00102FF0 File Offset: 0x001011F0
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

		// Token: 0x060030DA RID: 12506 RVA: 0x0001A200 File Offset: 0x00018400
		private void InitRefTypes()
		{
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BB6 RID: 7094
		public const uint cPacketType = 1215984841u;
	}
}
