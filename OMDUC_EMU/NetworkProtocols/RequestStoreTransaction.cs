using System;

namespace NetworkProtocols
{
	// Token: 0x020005A1 RID: 1441
	public class RequestStoreTransaction : BotNetMessage
	{
		// Token: 0x06003213 RID: 12819 RVA: 0x0001AE2B File Offset: 0x0001902B
		public RequestStoreTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 3796957890u;
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x0001AE44 File Offset: 0x00019044
		public RequestStoreTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3796957890u;
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0001AE64 File Offset: 0x00019064
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0001AE6C File Offset: 0x0001906C
		public ulong OfferID { get; set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x0001AE75 File Offset: 0x00019075
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x0001AE7D File Offset: 0x0001907D
		public int Quantity { get; set; }

		// Token: 0x06003219 RID: 12825 RVA: 0x00104A1C File Offset: 0x00102C1C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.Quantity);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00104AA8 File Offset: 0x00102CA8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.Quantity = ArrayManager.ReadInt32(data, ref num);
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x0001AE86 File Offset: 0x00019086
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
			this.Quantity = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C2E RID: 7214
		public const uint cPacketType = 3796957890u;
	}
}
