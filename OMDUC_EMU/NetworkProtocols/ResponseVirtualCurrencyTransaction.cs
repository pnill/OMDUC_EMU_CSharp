using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005A5 RID: 1445
	public class ResponseVirtualCurrencyTransaction : BotNetMessage
	{
		// Token: 0x06003242 RID: 12866 RVA: 0x0001B064 File Offset: 0x00019264
		public ResponseVirtualCurrencyTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 2843582931u;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0001B07D File Offset: 0x0001927D
		public ResponseVirtualCurrencyTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2843582931u;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x0001B09D File Offset: 0x0001929D
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x0001B0A5 File Offset: 0x000192A5
		public List<VirtualCurrencyTransactionResponseEntry> Transactions { get; set; }

		// Token: 0x06003246 RID: 12870 RVA: 0x00104E44 File Offset: 0x00103044
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
			ArrayManager.WriteListVirtualCurrencyTransactionResponseEntry(ref newArray, ref newSize, this.Transactions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00104EC4 File Offset: 0x001030C4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Transactions = ArrayManager.ReadListVirtualCurrencyTransactionResponseEntry(data, ref num);
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0001B0AE File Offset: 0x000192AE
		private void InitRefTypes()
		{
			this.Transactions = new List<VirtualCurrencyTransactionResponseEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C3F RID: 7231
		public const uint cPacketType = 2843582931u;
	}
}
