using System;

namespace NetworkProtocols
{
	// Token: 0x020006F1 RID: 1777
	public class ServerAckPromoteNewLeader : BotNetMessage
	{
		// Token: 0x06003F64 RID: 16228 RVA: 0x00023DBC File Offset: 0x00021FBC
		public ServerAckPromoteNewLeader()
		{
			this.InitRefTypes();
			base.PacketType = 4112255981u;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x00023DD5 File Offset: 0x00021FD5
		public ServerAckPromoteNewLeader(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4112255981u;
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x00023DF5 File Offset: 0x00021FF5
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x00023DFD File Offset: 0x00021FFD
		public ulong PartyID { get; set; }

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00023E06 File Offset: 0x00022006
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x00023E0E File Offset: 0x0002200E
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x00023E17 File Offset: 0x00022017
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x00023E1F File Offset: 0x0002201F
		public ulong AccountSUID { get; set; }

		// Token: 0x06003F6C RID: 16236 RVA: 0x0011B90C File Offset: 0x00119B0C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x0011B9A8 File Offset: 0x00119BA8
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
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00023E28 File Offset: 0x00022028
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.Status = ePartyOperationStatus.Failure;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002150 RID: 8528
		public const uint cPacketType = 4112255981u;
	}
}
