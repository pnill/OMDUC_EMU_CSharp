using System;

namespace NetworkProtocols
{
	// Token: 0x020006E6 RID: 1766
	public class ServerAckInviteToParty : BotNetMessage
	{
		// Token: 0x06003EFF RID: 16127 RVA: 0x000238A0 File Offset: 0x00021AA0
		public ServerAckInviteToParty()
		{
			this.InitRefTypes();
			base.PacketType = 182542086u;
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x000238B9 File Offset: 0x00021AB9
		public ServerAckInviteToParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 182542086u;
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x000238D9 File Offset: 0x00021AD9
		// (set) Token: 0x06003F02 RID: 16130 RVA: 0x000238E1 File Offset: 0x00021AE1
		public ulong PartyID { get; set; }

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x000238EA File Offset: 0x00021AEA
		// (set) Token: 0x06003F04 RID: 16132 RVA: 0x000238F2 File Offset: 0x00021AF2
		public ulong AccountSUID { get; set; }

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x000238FB File Offset: 0x00021AFB
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00023903 File Offset: 0x00021B03
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x06003F07 RID: 16135 RVA: 0x0011ADC0 File Offset: 0x00118FC0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteePartyOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0011AE5C File Offset: 0x0011905C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadePartyOperationStatus(data, ref num);
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0002390C File Offset: 0x00021B0C
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.AccountSUID = 0UL;
			this.Status = ePartyOperationStatus.Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400212E RID: 8494
		public const uint cPacketType = 182542086u;
	}
}
