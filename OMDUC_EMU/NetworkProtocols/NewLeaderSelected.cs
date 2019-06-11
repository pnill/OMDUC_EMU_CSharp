using System;

namespace NetworkProtocols
{
	// Token: 0x020006F2 RID: 1778
	public class NewLeaderSelected : BotNetMessage
	{
		// Token: 0x06003F6F RID: 16239 RVA: 0x00023E48 File Offset: 0x00022048
		public NewLeaderSelected()
		{
			this.InitRefTypes();
			base.PacketType = 3452175722u;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00023E61 File Offset: 0x00022061
		public NewLeaderSelected(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3452175722u;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x00023E81 File Offset: 0x00022081
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x00023E89 File Offset: 0x00022089
		public ulong PartyID { get; set; }

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x00023E92 File Offset: 0x00022092
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x00023E9A File Offset: 0x0002209A
		public NetworkPartyMember NewLeader { get; set; }

		// Token: 0x06003F75 RID: 16245 RVA: 0x0011BA2C File Offset: 0x00119C2C
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
			ArrayManager.WriteNetworkPartyMember(ref newArray, ref newSize, this.NewLeader);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x0011BAB8 File Offset: 0x00119CB8
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
			this.NewLeader = ArrayManager.ReadNetworkPartyMember(data, ref num);
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00023EA3 File Offset: 0x000220A3
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.NewLeader = new NetworkPartyMember();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002154 RID: 8532
		public const uint cPacketType = 3452175722u;
	}
}
