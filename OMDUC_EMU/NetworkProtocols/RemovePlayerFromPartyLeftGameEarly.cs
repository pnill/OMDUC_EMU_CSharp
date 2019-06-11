using System;

namespace NetworkProtocols
{
	// Token: 0x020006FB RID: 1787
	public class RemovePlayerFromPartyLeftGameEarly : BotNetMessage
	{
		// Token: 0x06003FD5 RID: 16341 RVA: 0x000242E9 File Offset: 0x000224E9
		public RemovePlayerFromPartyLeftGameEarly()
		{
			this.InitRefTypes();
			base.PacketType = 2373787869u;
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x00024302 File Offset: 0x00022502
		public RemovePlayerFromPartyLeftGameEarly(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2373787869u;
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06003FD8 RID: 16344 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06003FD9 RID: 16345 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002179 RID: 8569
		public const uint cPacketType = 2373787869u;
	}
}
