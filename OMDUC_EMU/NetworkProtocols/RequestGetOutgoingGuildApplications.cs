using System;

namespace NetworkProtocols
{
	// Token: 0x02000784 RID: 1924
	public class RequestGetOutgoingGuildApplications : BotNetMessage
	{
		// Token: 0x06004412 RID: 17426 RVA: 0x0002739A File Offset: 0x0002559A
		public RequestGetOutgoingGuildApplications()
		{
			this.InitRefTypes();
			base.PacketType = 487879128u;
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x000273B3 File Offset: 0x000255B3
		public RequestGetOutgoingGuildApplications(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 487879128u;
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06004415 RID: 17429 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06004416 RID: 17430 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002339 RID: 9017
		public const uint cPacketType = 487879128u;
	}
}
