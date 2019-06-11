using System;

namespace NetworkProtocols
{
	// Token: 0x02000580 RID: 1408
	public class ResponseRemovePartFromSlot : BotNetMessage
	{
		// Token: 0x06003070 RID: 12400 RVA: 0x00019D67 File Offset: 0x00017F67
		public ResponseRemovePartFromSlot()
		{
			this.InitRefTypes();
			base.PacketType = 2167140336u;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00019D80 File Offset: 0x00017F80
		public ResponseRemovePartFromSlot(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2167140336u;
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x00019DA0 File Offset: 0x00017FA0
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x00019DA8 File Offset: 0x00017FA8
		public bool WasPartRemoved { get; set; }

		// Token: 0x06003074 RID: 12404 RVA: 0x0010269C File Offset: 0x0010089C
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.WasPartRemoved);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0010271C File Offset: 0x0010091C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.WasPartRemoved = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00019DB1 File Offset: 0x00017FB1
		private void InitRefTypes()
		{
			this.WasPartRemoved = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B94 RID: 7060
		public const uint cPacketType = 2167140336u;
	}
}
