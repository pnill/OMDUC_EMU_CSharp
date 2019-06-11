using System;

namespace NetworkProtocols
{
	// Token: 0x0200048D RID: 1165
	public class ResponseChatFilterOptionChange : BotNetMessage
	{
		// Token: 0x06002A2D RID: 10797 RVA: 0x00016001 File Offset: 0x00014201
		public ResponseChatFilterOptionChange()
		{
			this.InitRefTypes();
			base.PacketType = 4030005612u;
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x0001601A File Offset: 0x0001421A
		public ResponseChatFilterOptionChange(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4030005612u;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x0001603A File Offset: 0x0001423A
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00016042 File Offset: 0x00014242
		public eAccountDataEventCodes ResponseCode { get; set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0001604B File Offset: 0x0001424B
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x00016053 File Offset: 0x00014253
		public bool ChatFilterDisabled { get; set; }

		// Token: 0x06002A33 RID: 10803 RVA: 0x000FADE4 File Offset: 0x000F8FE4
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
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.ResponseCode);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ChatFilterDisabled);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000FAE70 File Offset: 0x000F9070
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ResponseCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.ChatFilterDisabled = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0001605C File Offset: 0x0001425C
		private void InitRefTypes()
		{
			this.ResponseCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.ChatFilterDisabled = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016D7 RID: 5847
		public const uint cPacketType = 4030005612u;
	}
}
