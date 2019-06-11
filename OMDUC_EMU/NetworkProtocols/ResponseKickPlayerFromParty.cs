using System;

namespace NetworkProtocols
{
	// Token: 0x020006F9 RID: 1785
	public class ResponseKickPlayerFromParty : BotNetMessage
	{
		// Token: 0x06003FC1 RID: 16321 RVA: 0x000241E9 File Offset: 0x000223E9
		public ResponseKickPlayerFromParty()
		{
			this.InitRefTypes();
			base.PacketType = 4252966287u;
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00024202 File Offset: 0x00022402
		public ResponseKickPlayerFromParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4252966287u;
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x00024222 File Offset: 0x00022422
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x0002422A File Offset: 0x0002242A
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x00024233 File Offset: 0x00022433
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x0002423B File Offset: 0x0002243B
		public ulong PartyID { get; set; }

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x00024244 File Offset: 0x00022444
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x0002424C File Offset: 0x0002244C
		public ulong AccountSUID { get; set; }

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0011C240 File Offset: 0x0011A440
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
			ArrayManager.WriteePartyOperationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x0011C2DC File Offset: 0x0011A4DC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadePartyOperationStatus(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00024255 File Offset: 0x00022455
		private void InitRefTypes()
		{
			this.Status = ePartyOperationStatus.Failure;
			this.PartyID = 0UL;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002172 RID: 8562
		public const uint cPacketType = 4252966287u;
	}
}
