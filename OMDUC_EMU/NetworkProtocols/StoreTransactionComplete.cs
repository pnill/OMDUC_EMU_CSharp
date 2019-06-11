using System;

namespace NetworkProtocols
{
	// Token: 0x020004B1 RID: 1201
	public class StoreTransactionComplete : BotNetMessage
	{
		// Token: 0x06002B06 RID: 11014 RVA: 0x000169F2 File Offset: 0x00014BF2
		public StoreTransactionComplete()
		{
			this.InitRefTypes();
			base.PacketType = 3084580504u;
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00016A0B File Offset: 0x00014C0B
		public StoreTransactionComplete(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3084580504u;
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x00016A2B File Offset: 0x00014C2B
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x00016A33 File Offset: 0x00014C33
		public ulong OfferID { get; set; }

		// Token: 0x06002B0A RID: 11018 RVA: 0x000FC090 File Offset: 0x000FA290
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000FC110 File Offset: 0x000FA310
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
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00016A3C File Offset: 0x00014C3C
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040017A9 RID: 6057
		public const uint cPacketType = 3084580504u;
	}
}
