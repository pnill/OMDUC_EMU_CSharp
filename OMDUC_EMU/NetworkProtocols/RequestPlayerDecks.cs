using System;

namespace NetworkProtocols
{
	// Token: 0x020004E6 RID: 1254
	public class RequestPlayerDecks : BotNetMessage
	{
		// Token: 0x06002B71 RID: 11121 RVA: 0x00016F05 File Offset: 0x00015105
		public RequestPlayerDecks()
		{
			this.InitRefTypes();
			base.PacketType = 1835714875u;
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00016F1E File Offset: 0x0001511E
		public RequestPlayerDecks(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1835714875u;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06002B74 RID: 11124 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06002B75 RID: 11125 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A3A RID: 6714
		public const uint cPacketType = 1835714875u;
	}
}
