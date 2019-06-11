using System;

namespace NetworkProtocols
{
	// Token: 0x02000619 RID: 1561
	public class ResponseInitiateSteamTransaction : BotNetMessage
	{
		// Token: 0x06003673 RID: 13939 RVA: 0x0001DBDA File Offset: 0x0001BDDA
		public ResponseInitiateSteamTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 320520079u;
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0001DBF3 File Offset: 0x0001BDF3
		public ResponseInitiateSteamTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 320520079u;
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x0001DC13 File Offset: 0x0001BE13
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x0001DC1B File Offset: 0x0001BE1B
		public ulong TransactionID { get; set; }

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x0001DC24 File Offset: 0x0001BE24
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x0001DC2C File Offset: 0x0001BE2C
		public eStoreTransactionRequestStatus Status { get; set; }

		// Token: 0x06003679 RID: 13945 RVA: 0x0010B014 File Offset: 0x00109214
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

		// Token: 0x0600367A RID: 13946 RVA: 0x0010B0A0 File Offset: 0x001092A0
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

		// Token: 0x0600367B RID: 13947 RVA: 0x0001DC35 File Offset: 0x0001BE35
		private void InitRefTypes()
		{
			this.TransactionID = 0UL;
			this.Status = eStoreTransactionRequestStatus.Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D88 RID: 7560
		public const uint cPacketType = 320520079u;
	}
}
