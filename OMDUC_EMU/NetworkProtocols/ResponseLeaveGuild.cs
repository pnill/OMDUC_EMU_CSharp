using System;

namespace NetworkProtocols
{
	// Token: 0x0200074A RID: 1866
	public class ResponseLeaveGuild : BotNetMessage
	{
		// Token: 0x0600420F RID: 16911 RVA: 0x00025E33 File Offset: 0x00024033
		public ResponseLeaveGuild()
		{
			this.InitRefTypes();
			base.PacketType = 4131534742u;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00025E4C File Offset: 0x0002404C
		public ResponseLeaveGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4131534742u;
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x00025E6C File Offset: 0x0002406C
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x00025E74 File Offset: 0x00024074
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004213 RID: 16915 RVA: 0x0011FEB4 File Offset: 0x0011E0B4
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0011FF34 File Offset: 0x0011E134
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x00025E7D File Offset: 0x0002407D
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002298 RID: 8856
		public const uint cPacketType = 4131534742u;
	}
}
