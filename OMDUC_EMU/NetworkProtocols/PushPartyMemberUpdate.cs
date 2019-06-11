using System;

namespace NetworkProtocols
{
	// Token: 0x020006FC RID: 1788
	public class PushPartyMemberUpdate : BotNetMessage
	{
		// Token: 0x06003FDA RID: 16346 RVA: 0x00024322 File Offset: 0x00022522
		public PushPartyMemberUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 2558117204u;
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x0002433B File Offset: 0x0002253B
		public PushPartyMemberUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2558117204u;
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x0002435B File Offset: 0x0002255B
		// (set) Token: 0x06003FDD RID: 16349 RVA: 0x00024363 File Offset: 0x00022563
		public ulong PartyID { get; set; }

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003FDE RID: 16350 RVA: 0x0002436C File Offset: 0x0002256C
		// (set) Token: 0x06003FDF RID: 16351 RVA: 0x00024374 File Offset: 0x00022574
		public NetworkPartyMember PartyMember { get; set; }

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0011C464 File Offset: 0x0011A664
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

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0011C4F0 File Offset: 0x0011A6F0
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

		// Token: 0x06003FE2 RID: 16354 RVA: 0x0002437D File Offset: 0x0002257D
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.PartyMember = new NetworkPartyMember();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400217A RID: 8570
		public const uint cPacketType = 2558117204u;
	}
}
