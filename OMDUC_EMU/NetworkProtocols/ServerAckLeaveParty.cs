using System;

namespace NetworkProtocols
{
	// Token: 0x020006ED RID: 1773
	public class ServerAckLeaveParty : BotNetMessage
	{
		// Token: 0x06003F42 RID: 16194 RVA: 0x00023C03 File Offset: 0x00021E03
		public ServerAckLeaveParty()
		{
			this.InitRefTypes();
			base.PacketType = 4177834193u;
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x00023C1C File Offset: 0x00021E1C
		public ServerAckLeaveParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4177834193u;
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x00023C3C File Offset: 0x00021E3C
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x00023C44 File Offset: 0x00021E44
		public ulong PartyID { get; set; }

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x00023C4D File Offset: 0x00021E4D
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x00023C55 File Offset: 0x00021E55
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x06003F48 RID: 16200 RVA: 0x0011B518 File Offset: 0x00119718
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
			ArrayManager.WriteePartyOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0011B5A4 File Offset: 0x001197A4
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
			this.Status = ArrayManager.ReadePartyOperationStatus(data, ref num);
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x00023C5E File Offset: 0x00021E5E
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.Status = ePartyOperationStatus.Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002145 RID: 8517
		public const uint cPacketType = 4177834193u;
	}
}
