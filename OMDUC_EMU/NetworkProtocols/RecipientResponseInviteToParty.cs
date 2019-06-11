using System;

namespace NetworkProtocols
{
	// Token: 0x020006EA RID: 1770
	public class RecipientResponseInviteToParty : BotNetMessage
	{
		// Token: 0x06003F25 RID: 16165 RVA: 0x00023A89 File Offset: 0x00021C89
		public RecipientResponseInviteToParty()
		{
			this.InitRefTypes();
			base.PacketType = 3405142812u;
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00023AA2 File Offset: 0x00021CA2
		public RecipientResponseInviteToParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3405142812u;
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x00023AC2 File Offset: 0x00021CC2
		// (set) Token: 0x06003F28 RID: 16168 RVA: 0x00023ACA File Offset: 0x00021CCA
		public ulong PartyID { get; set; }

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x00023AD3 File Offset: 0x00021CD3
		// (set) Token: 0x06003F2A RID: 16170 RVA: 0x00023ADB File Offset: 0x00021CDB
		public ulong AccountSUID { get; set; }

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x00023AE4 File Offset: 0x00021CE4
		// (set) Token: 0x06003F2C RID: 16172 RVA: 0x00023AEC File Offset: 0x00021CEC
		public NetworkPartyMember PartyMember { get; set; }

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x00023AF5 File Offset: 0x00021CF5
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x00023AFD File Offset: 0x00021CFD
		public ePartyJoinResponses DidJoin { get; set; }

		// Token: 0x06003F2F RID: 16175 RVA: 0x0011B1EC File Offset: 0x001193EC
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
			ArrayManager.WriteNetworkPartyMember(ref newArray, ref newSize, this.PartyMember);
			ArrayManager.WriteePartyJoinResponses(ref newArray, ref newSize, this.DidJoin);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0011B298 File Offset: 0x00119498
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
			this.PartyMember = ArrayManager.ReadNetworkPartyMember(data, ref num);
			this.DidJoin = ArrayManager.ReadePartyJoinResponses(data, ref num);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x00023B06 File Offset: 0x00021D06
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.AccountSUID = 0UL;
			this.PartyMember = new NetworkPartyMember();
			this.DidJoin = ePartyJoinResponses.Joined;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400213B RID: 8507
		public const uint cPacketType = 3405142812u;
	}
}
