using System;

namespace NetworkProtocols
{
	// Token: 0x0200071B RID: 1819
	public class RequestDenyFriendRequest : BotNetMessage
	{
		// Token: 0x06004086 RID: 16518 RVA: 0x00024B2A File Offset: 0x00022D2A
		public RequestDenyFriendRequest()
		{
			this.InitRefTypes();
			base.PacketType = 491869017u;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00024B43 File Offset: 0x00022D43
		public RequestDenyFriendRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 491869017u;
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x00024B63 File Offset: 0x00022D63
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x00024B6B File Offset: 0x00022D6B
		public ulong AccountSUID { get; set; }

		// Token: 0x0600408A RID: 16522 RVA: 0x0011D4E0 File Offset: 0x0011B6E0
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

		// Token: 0x0600408B RID: 16523 RVA: 0x0011D560 File Offset: 0x0011B760
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

		// Token: 0x0600408C RID: 16524 RVA: 0x00024B74 File Offset: 0x00022D74
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400221B RID: 8731
		public const uint cPacketType = 491869017u;
	}
}
