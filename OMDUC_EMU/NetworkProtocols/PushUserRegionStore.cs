using System;

namespace NetworkProtocols
{
	// Token: 0x0200058F RID: 1423
	public class PushUserRegionStore : BotNetMessage
	{
		// Token: 0x0600312C RID: 12588 RVA: 0x0001A581 File Offset: 0x00018781
		public PushUserRegionStore()
		{
			this.InitRefTypes();
			base.PacketType = 1931475128u;
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x0001A59A File Offset: 0x0001879A
		public PushUserRegionStore(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1931475128u;
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0001A5BA File Offset: 0x000187BA
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x0001A5C2 File Offset: 0x000187C2
		public ePriceCurrencyType CurrentStoreRegion { get; set; }

		// Token: 0x06003130 RID: 12592 RVA: 0x00103864 File Offset: 0x00101A64
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
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.CurrentStoreRegion);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x001038E4 File Offset: 0x00101AE4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CurrentStoreRegion = ArrayManager.ReadePriceCurrencyType(data, ref num);
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x0001A5CB File Offset: 0x000187CB
		private void InitRefTypes()
		{
			this.CurrentStoreRegion = ePriceCurrencyType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BDA RID: 7130
		public const uint cPacketType = 1931475128u;
	}
}
