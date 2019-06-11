using System;

namespace NetworkProtocols
{
	// Token: 0x0200061B RID: 1563
	public class ResponseFinalizeSteamTransaction : BotNetMessage
	{
		// Token: 0x06003685 RID: 13957 RVA: 0x0001DCC1 File Offset: 0x0001BEC1
		public ResponseFinalizeSteamTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 514742386u;
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x0001DCDA File Offset: 0x0001BEDA
		public ResponseFinalizeSteamTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 514742386u;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x0001DCFA File Offset: 0x0001BEFA
		// (set) Token: 0x06003688 RID: 13960 RVA: 0x0001DD02 File Offset: 0x0001BF02
		public ulong TransactionID { get; set; }

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0001DD0B File Offset: 0x0001BF0B
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x0001DD13 File Offset: 0x0001BF13
		public eStoreTransactionRequestStatus Status { get; set; }

		// Token: 0x0600368B RID: 13963 RVA: 0x0010B21C File Offset: 0x0010941C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TransactionID);
			ArrayManager.WriteeStoreTransactionRequestStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x0010B2A8 File Offset: 0x001094A8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TransactionID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeStoreTransactionRequestStatus(data, ref num);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x0001DD1C File Offset: 0x0001BF1C
		private void InitRefTypes()
		{
			this.TransactionID = 0UL;
			this.Status = eStoreTransactionRequestStatus.Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D8E RID: 7566
		public const uint cPacketType = 514742386u;
	}
}
