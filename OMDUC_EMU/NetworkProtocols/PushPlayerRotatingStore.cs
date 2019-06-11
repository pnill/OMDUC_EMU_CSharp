using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000655 RID: 1621
	public class PushPlayerRotatingStore : BotNetMessage
	{
		// Token: 0x0600388E RID: 14478 RVA: 0x0001F25B File Offset: 0x0001D45B
		public PushPlayerRotatingStore()
		{
			this.InitRefTypes();
			base.PacketType = 164379719u;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x0001F274 File Offset: 0x0001D474
		public PushPlayerRotatingStore(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 164379719u;
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x0001F294 File Offset: 0x0001D494
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x0001F29C File Offset: 0x0001D49C
		public List<StoreDataOffer> Offers { get; set; }

		// Token: 0x06003892 RID: 14482 RVA: 0x0010E1D0 File Offset: 0x0010C3D0
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

		// Token: 0x06003893 RID: 14483 RVA: 0x0010E250 File Offset: 0x0010C450
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

		// Token: 0x06003894 RID: 14484 RVA: 0x0001F2A5 File Offset: 0x0001D4A5
		private void InitRefTypes()
		{
			this.Offers = new List<StoreDataOffer>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E2E RID: 7726
		public const uint cPacketType = 164379719u;
	}
}
