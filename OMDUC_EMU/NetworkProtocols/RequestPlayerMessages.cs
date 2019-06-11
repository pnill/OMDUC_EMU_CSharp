using System;

namespace NetworkProtocols
{
	// Token: 0x02000621 RID: 1569
	public class RequestPlayerMessages : BotNetMessage
	{
		// Token: 0x060036B2 RID: 14002 RVA: 0x0001DEE1 File Offset: 0x0001C0E1
		public RequestPlayerMessages()
		{
			this.InitRefTypes();
			base.PacketType = 1244073833u;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0001DEFA File Offset: 0x0001C0FA
		public RequestPlayerMessages(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1244073833u;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x060036B5 RID: 14005 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x060036B6 RID: 14006 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D9B RID: 7579
		public const uint cPacketType = 1244073833u;
	}
}
