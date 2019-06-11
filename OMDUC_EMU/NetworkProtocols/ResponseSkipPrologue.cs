using System;

namespace NetworkProtocols
{
	// Token: 0x0200065A RID: 1626
	public class ResponseSkipPrologue : BotNetMessage
	{
		// Token: 0x060038B0 RID: 14512 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		public ResponseSkipPrologue()
		{
			this.InitRefTypes();
			base.PacketType = 2968550505u;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0001F409 File Offset: 0x0001D609
		public ResponseSkipPrologue(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2968550505u;
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060038B2 RID: 14514 RVA: 0x0001F429 File Offset: 0x0001D629
		// (set) Token: 0x060038B3 RID: 14515 RVA: 0x0001F431 File Offset: 0x0001D631
		public eCampaignOperationStatus Status { get; set; }

		// Token: 0x060038B4 RID: 14516 RVA: 0x0010E4F0 File Offset: 0x0010C6F0
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
			ArrayManager.WriteeCampaignOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x0010E570 File Offset: 0x0010C770
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeCampaignOperationStatus(data, ref num);
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0001F43A File Offset: 0x0001D63A
		private void InitRefTypes()
		{
			this.Status = eCampaignOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E37 RID: 7735
		public const uint cPacketType = 2968550505u;
	}
}
