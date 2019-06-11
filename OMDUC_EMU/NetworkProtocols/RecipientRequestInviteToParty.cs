using System;

namespace NetworkProtocols
{
	// Token: 0x020006E9 RID: 1769
	public class RecipientRequestInviteToParty : BotNetMessage
	{
		// Token: 0x06003F1C RID: 16156 RVA: 0x00023A12 File Offset: 0x00021C12
		public RecipientRequestInviteToParty()
		{
			this.InitRefTypes();
			base.PacketType = 3426490374u;
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00023A2B File Offset: 0x00021C2B
		public RecipientRequestInviteToParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3426490374u;
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x00023A4B File Offset: 0x00021C4B
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x00023A53 File Offset: 0x00021C53
		public ulong PartyID { get; set; }

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x00023A5C File Offset: 0x00021C5C
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x00023A64 File Offset: 0x00021C64
		public NetworkPartyMember Leader { get; set; }

		// Token: 0x06003F22 RID: 16162 RVA: 0x0011B0E8 File Offset: 0x001192E8
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
			ArrayManager.WriteNetworkPartyMember(ref newArray, ref newSize, this.Leader);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0011B174 File Offset: 0x00119374
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
			this.Leader = ArrayManager.ReadNetworkPartyMember(data, ref num);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x00023A6D File Offset: 0x00021C6D
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.Leader = new NetworkPartyMember();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002138 RID: 8504
		public const uint cPacketType = 3426490374u;
	}
}
