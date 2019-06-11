using System;

namespace NetworkProtocols
{
	// Token: 0x0200065C RID: 1628
	public class ResponseRegisterEUPlayer : BotNetMessage
	{
		// Token: 0x060038CA RID: 14538 RVA: 0x0001F4FA File Offset: 0x0001D6FA
		public ResponseRegisterEUPlayer()
		{
			this.InitRefTypes();
			base.PacketType = 3648286461u;
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x0001F513 File Offset: 0x0001D713
		public ResponseRegisterEUPlayer(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3648286461u;
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0001F533 File Offset: 0x0001D733
		// (set) Token: 0x060038CD RID: 14541 RVA: 0x0001F53B File Offset: 0x0001D73B
		public string Username { get; set; }

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x0001F544 File Offset: 0x0001D744
		// (set) Token: 0x060038CF RID: 14543 RVA: 0x0001F54C File Offset: 0x0001D74C
		public ulong AccountSUID { get; set; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x0001F555 File Offset: 0x0001D755
		// (set) Token: 0x060038D1 RID: 14545 RVA: 0x0001F55D File Offset: 0x0001D75D
		public eRegistrationStatus Status { get; set; }

		// Token: 0x060038D2 RID: 14546 RVA: 0x0010E7C8 File Offset: 0x0010C9C8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteeRegistrationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0010E864 File Offset: 0x0010CA64
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeRegistrationStatus(data, ref num);
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0001F566 File Offset: 0x0001D766
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.AccountSUID = 0UL;
			this.Status = eRegistrationStatus.eRegistrationStatus_Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E41 RID: 7745
		public const uint cPacketType = 3648286461u;
	}
}
