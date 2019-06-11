using System;

namespace NetworkProtocols
{
	// Token: 0x02000715 RID: 1813
	public class RequestCreateFriendRequestByAccountSUID : BotNetMessage
	{
		// Token: 0x06004056 RID: 16470 RVA: 0x000248C0 File Offset: 0x00022AC0
		public RequestCreateFriendRequestByAccountSUID()
		{
			this.InitRefTypes();
			base.PacketType = 296893264u;
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x000248D9 File Offset: 0x00022AD9
		public RequestCreateFriendRequestByAccountSUID(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 296893264u;
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x000248F9 File Offset: 0x00022AF9
		// (set) Token: 0x06004059 RID: 16473 RVA: 0x00024901 File Offset: 0x00022B01
		public ulong AccountSUID { get; set; }

		// Token: 0x0600405A RID: 16474 RVA: 0x0011CF1C File Offset: 0x0011B11C
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

		// Token: 0x0600405B RID: 16475 RVA: 0x0011CF9C File Offset: 0x0011B19C
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

		// Token: 0x0600405C RID: 16476 RVA: 0x0002490A File Offset: 0x00022B0A
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400220C RID: 8716
		public const uint cPacketType = 296893264u;
	}
}
