using System;

namespace NetworkProtocols
{
	// Token: 0x0200057C RID: 1404
	public class ResponseUpgradeTrap : BotNetMessage
	{
		// Token: 0x06003046 RID: 12358 RVA: 0x00019B52 File Offset: 0x00017D52
		public ResponseUpgradeTrap()
		{
			this.InitRefTypes();
			base.PacketType = 82359087u;
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x00019B6B File Offset: 0x00017D6B
		public ResponseUpgradeTrap(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 82359087u;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x00019B8B File Offset: 0x00017D8B
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x00019B93 File Offset: 0x00017D93
		public ulong TrapGUID { get; set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x00019B9C File Offset: 0x00017D9C
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00019BA4 File Offset: 0x00017DA4
		public uint TrapTier { get; set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x00019BAD File Offset: 0x00017DAD
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x00019BB5 File Offset: 0x00017DB5
		public bool WasTrapUpgraded { get; set; }

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x00019BBE File Offset: 0x00017DBE
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x00019BC6 File Offset: 0x00017DC6
		public eCraftingOperationStatus Status { get; set; }

		// Token: 0x06003050 RID: 12368 RVA: 0x00102234 File Offset: 0x00100434
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TrapGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TrapTier);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.WasTrapUpgraded);
			ArrayManager.WriteeCraftingOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x001022E0 File Offset: 0x001004E0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TrapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.TrapTier = ArrayManager.ReadUInt32(data, ref num);
			this.WasTrapUpgraded = ArrayManager.ReadBoolean(data, ref num);
			this.Status = ArrayManager.ReadeCraftingOperationStatus(data, ref num);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00019BCF File Offset: 0x00017DCF
		private void InitRefTypes()
		{
			this.TrapGUID = 0UL;
			this.TrapTier = 0u;
			this.WasTrapUpgraded = false;
			this.Status = eCraftingOperationStatus.Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B85 RID: 7045
		public const uint cPacketType = 82359087u;
	}
}
