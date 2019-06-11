using System;

namespace NetworkProtocols
{
	// Token: 0x020004E0 RID: 1248
	public class ResponseRemoveNewInventoryFlag : BotNetMessage
	{
		// Token: 0x06002B41 RID: 11073 RVA: 0x00016CED File Offset: 0x00014EED
		public ResponseRemoveNewInventoryFlag()
		{
			this.InitRefTypes();
			base.PacketType = 875959173u;
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00016D06 File Offset: 0x00014F06
		public ResponseRemoveNewInventoryFlag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 875959173u;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000FBC5C File Offset: 0x000F9E5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A2C RID: 6700
		public const uint cPacketType = 875959173u;
	}
}
