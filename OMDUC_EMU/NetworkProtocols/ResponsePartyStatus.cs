using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006F5 RID: 1781
	public class ResponsePartyStatus : BotNetMessage
	{
		// Token: 0x06003F99 RID: 16281 RVA: 0x00023FE3 File Offset: 0x000221E3
		public ResponsePartyStatus()
		{
			this.InitRefTypes();
			base.PacketType = 4193931842u;
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00023FFC File Offset: 0x000221FC
		public ResponsePartyStatus(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4193931842u;
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x0002401C File Offset: 0x0002221C
		// (set) Token: 0x06003F9C RID: 16284 RVA: 0x00024024 File Offset: 0x00022224
		public ulong PartyID { get; set; }

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x0002402D File Offset: 0x0002222D
		// (set) Token: 0x06003F9E RID: 16286 RVA: 0x00024035 File Offset: 0x00022235
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x0002403E File Offset: 0x0002223E
		// (set) Token: 0x06003FA0 RID: 16288 RVA: 0x00024046 File Offset: 0x00022246
		public List<NetworkPartyMember> Members { get; set; }

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x0002404F File Offset: 0x0002224F
		// (set) Token: 0x06003FA2 RID: 16290 RVA: 0x00024057 File Offset: 0x00022257
		public List<NetworkPartyMember> Invitees { get; set; }

		// Token: 0x06003FA3 RID: 16291 RVA: 0x0011BDF4 File Offset: 0x00119FF4
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
			ArrayManager.WriteListNetworkPartyMember(ref newArray, ref newSize, this.Members);
			ArrayManager.WriteListNetworkPartyMember(ref newArray, ref newSize, this.Invitees);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x0011BEA0 File Offset: 0x0011A0A0
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
			this.Members = ArrayManager.ReadListNetworkPartyMember(data, ref num);
			this.Invitees = ArrayManager.ReadListNetworkPartyMember(data, ref num);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00024060 File Offset: 0x00022260
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.Status = ePartyOperationStatus.Failure;
			this.Members = new List<NetworkPartyMember>();
			this.Invitees = new List<NetworkPartyMember>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002164 RID: 8548
		public const uint cPacketType = 4193931842u;
	}
}
