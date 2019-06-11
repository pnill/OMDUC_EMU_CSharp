using System;

namespace NetworkProtocols
{
	// Token: 0x0200072A RID: 1834
	public class ResponseRejectGuildInvite : BotNetMessage
	{
		// Token: 0x06004103 RID: 16643 RVA: 0x0002517C File Offset: 0x0002337C
		public ResponseRejectGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 44440897u;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00025195 File Offset: 0x00023395
		public ResponseRejectGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 44440897u;
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x000251B5 File Offset: 0x000233B5
		// (set) Token: 0x06004106 RID: 16646 RVA: 0x000251BD File Offset: 0x000233BD
		public ulong InviteID { get; set; }

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06004107 RID: 16647 RVA: 0x000251C6 File Offset: 0x000233C6
		// (set) Token: 0x06004108 RID: 16648 RVA: 0x000251CE File Offset: 0x000233CE
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004109 RID: 16649 RVA: 0x0011E1F8 File Offset: 0x0011C3F8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InviteID);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x0011E284 File Offset: 0x0011C484
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.InviteID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x000251D7 File Offset: 0x000233D7
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002243 RID: 8771
		public const uint cPacketType = 44440897u;
	}
}
