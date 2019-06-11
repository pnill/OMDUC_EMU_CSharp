using System;

namespace NetworkProtocols
{
	// Token: 0x0200058C RID: 1420
	public class UserRegisterResponse : BotNetMessage
	{
		// Token: 0x060030FB RID: 12539 RVA: 0x0001A35D File Offset: 0x0001855D
		public UserRegisterResponse()
		{
			this.InitRefTypes();
			base.PacketType = 2448266203u;
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0001A376 File Offset: 0x00018576
		public UserRegisterResponse(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2448266203u;
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x0001A396 File Offset: 0x00018596
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x0001A39E File Offset: 0x0001859E
		public string Username { get; set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x0001A3A7 File Offset: 0x000185A7
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x0001A3AF File Offset: 0x000185AF
		public ulong AccountSUID { get; set; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x0001A3B8 File Offset: 0x000185B8
		// (set) Token: 0x06003102 RID: 12546 RVA: 0x0001A3C0 File Offset: 0x000185C0
		public eRegistrationStatus Status { get; set; }

		// Token: 0x06003103 RID: 12547 RVA: 0x001033AC File Offset: 0x001015AC
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

		// Token: 0x06003104 RID: 12548 RVA: 0x00103448 File Offset: 0x00101648
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

		// Token: 0x06003105 RID: 12549 RVA: 0x0001A3C9 File Offset: 0x000185C9
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.AccountSUID = 0UL;
			this.Status = eRegistrationStatus.eRegistrationStatus_Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BC6 RID: 7110
		public const uint cPacketType = 2448266203u;
	}
}
