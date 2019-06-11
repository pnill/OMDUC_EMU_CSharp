using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000595 RID: 1429
	public class ResponseStoreData : BotNetMessage
	{
		// Token: 0x06003162 RID: 12642 RVA: 0x0001A7EE File Offset: 0x000189EE
		public ResponseStoreData()
		{
			this.InitRefTypes();
			base.PacketType = 1962576938u;
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0001A807 File Offset: 0x00018A07
		public ResponseStoreData(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1962576938u;
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x0001A827 File Offset: 0x00018A27
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x0001A82F File Offset: 0x00018A2F
		public List<StoreDataOffer> Offers { get; set; }

		// Token: 0x06003166 RID: 12646 RVA: 0x00103D38 File Offset: 0x00101F38
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

		// Token: 0x06003167 RID: 12647 RVA: 0x00103DB8 File Offset: 0x00101FB8
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

		// Token: 0x06003168 RID: 12648 RVA: 0x0001A838 File Offset: 0x00018A38
		private void InitRefTypes()
		{
			this.Offers = new List<StoreDataOffer>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BEC RID: 7148
		public const uint cPacketType = 1962576938u;
	}
}
