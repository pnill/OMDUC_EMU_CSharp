using System;

namespace NetworkProtocols
{
	// Token: 0x020006EE RID: 1774
	public class PlayerLeftParty : BotNetMessage
	{
		// Token: 0x06003F4B RID: 16203 RVA: 0x00023C76 File Offset: 0x00021E76
		public PlayerLeftParty()
		{
			this.InitRefTypes();
			base.PacketType = 282448013u;
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00023C8F File Offset: 0x00021E8F
		public PlayerLeftParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 282448013u;
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x00023CAF File Offset: 0x00021EAF
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x00023CB7 File Offset: 0x00021EB7
		public ulong PartyID { get; set; }

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x00023CC0 File Offset: 0x00021EC0
		// (set) Token: 0x06003F50 RID: 16208 RVA: 0x00023CC8 File Offset: 0x00021EC8
		public NetworkPartyMember PartyMember { get; set; }

		// Token: 0x06003F51 RID: 16209 RVA: 0x0011B61C File Offset: 0x0011981C
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
			ArrayManager.WriteNetworkPartyMember(ref newArray, ref newSize, this.PartyMember);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0011B6A8 File Offset: 0x001198A8
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
			this.PartyMember = ArrayManager.ReadNetworkPartyMember(data, ref num);
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x00023CD1 File Offset: 0x00021ED1
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.PartyMember = new NetworkPartyMember();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002148 RID: 8520
		public const uint cPacketType = 282448013u;
	}
}
