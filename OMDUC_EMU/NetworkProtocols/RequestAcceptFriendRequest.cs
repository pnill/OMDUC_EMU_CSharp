using System;

namespace NetworkProtocols
{
	// Token: 0x02000719 RID: 1817
	public class RequestAcceptFriendRequest : BotNetMessage
	{
		// Token: 0x06004076 RID: 16502 RVA: 0x00024A5C File Offset: 0x00022C5C
		public RequestAcceptFriendRequest()
		{
			this.InitRefTypes();
			base.PacketType = 2162058774u;
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x00024A75 File Offset: 0x00022C75
		public RequestAcceptFriendRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2162058774u;
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x00024A95 File Offset: 0x00022C95
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x00024A9D File Offset: 0x00022C9D
		public ulong AccountSUID { get; set; }

		// Token: 0x0600407A RID: 16506 RVA: 0x0011D2F4 File Offset: 0x0011B4F4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0011D374 File Offset: 0x0011B574
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00024AA6 File Offset: 0x00022CA6
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002216 RID: 8726
		public const uint cPacketType = 2162058774u;
	}
}
