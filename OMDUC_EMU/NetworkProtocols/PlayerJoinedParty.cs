using System;

namespace NetworkProtocols
{
	// Token: 0x020006EB RID: 1771
	public class PlayerJoinedParty : BotNetMessage
	{
		// Token: 0x06003F32 RID: 16178 RVA: 0x00023B31 File Offset: 0x00021D31
		public PlayerJoinedParty()
		{
			this.InitRefTypes();
			base.PacketType = 2633880644u;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00023B4A File Offset: 0x00021D4A
		public PlayerJoinedParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2633880644u;
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x00023B6A File Offset: 0x00021D6A
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x00023B72 File Offset: 0x00021D72
		public ulong PartyID { get; set; }

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x00023B7B File Offset: 0x00021D7B
		// (set) Token: 0x06003F37 RID: 16183 RVA: 0x00023B83 File Offset: 0x00021D83
		public NetworkPartyMember PartyMember { get; set; }

		// Token: 0x06003F38 RID: 16184 RVA: 0x0011B32C File Offset: 0x0011952C
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

		// Token: 0x06003F39 RID: 16185 RVA: 0x0011B3B8 File Offset: 0x001195B8
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

		// Token: 0x06003F3A RID: 16186 RVA: 0x00023B8C File Offset: 0x00021D8C
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.PartyMember = new NetworkPartyMember();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002140 RID: 8512
		public const uint cPacketType = 2633880644u;
	}
}
