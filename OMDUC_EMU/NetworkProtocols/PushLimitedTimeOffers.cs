using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005BD RID: 1469
	public class PushLimitedTimeOffers : BotNetMessage
	{
		// Token: 0x06003342 RID: 13122 RVA: 0x0001BA31 File Offset: 0x00019C31
		public PushLimitedTimeOffers()
		{
			this.InitRefTypes();
			base.PacketType = 357701359u;
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x0001BA4A File Offset: 0x00019C4A
		public PushLimitedTimeOffers(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 357701359u;
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x0001BA6A File Offset: 0x00019C6A
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x0001BA72 File Offset: 0x00019C72
		public List<StoreDataOffer> Offers { get; set; }

		// Token: 0x06003346 RID: 13126 RVA: 0x001061E4 File Offset: 0x001043E4
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
			ArrayManager.WriteListStoreDataOffer(ref newArray, ref newSize, this.Offers);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00106264 File Offset: 0x00104464
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Offers = ArrayManager.ReadListStoreDataOffer(data, ref num);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0001BA7B File Offset: 0x00019C7B
		private void InitRefTypes()
		{
			this.Offers = new List<StoreDataOffer>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C94 RID: 7316
		public const uint cPacketType = 357701359u;
	}
}
