using System;

namespace NetworkProtocols
{
	// Token: 0x0200057B RID: 1403
	public class RequestUpgradeTrap : BotNetMessage
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x00019ADF File Offset: 0x00017CDF
		public RequestUpgradeTrap()
		{
			this.InitRefTypes();
			base.PacketType = 3828043089u;
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00019AF8 File Offset: 0x00017CF8
		public RequestUpgradeTrap(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3828043089u;
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x00019B18 File Offset: 0x00017D18
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x00019B20 File Offset: 0x00017D20
		public ulong TrapProtoGUID { get; set; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x00019B29 File Offset: 0x00017D29
		// (set) Token: 0x06003042 RID: 12354 RVA: 0x00019B31 File Offset: 0x00017D31
		public bool IsCampaign { get; set; }

		// Token: 0x06003043 RID: 12355 RVA: 0x00102130 File Offset: 0x00100330
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TrapProtoGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsCampaign);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x001021BC File Offset: 0x001003BC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TrapProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.IsCampaign = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x00019B3A File Offset: 0x00017D3A
		private void InitRefTypes()
		{
			this.TrapProtoGUID = 0UL;
			this.IsCampaign = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B82 RID: 7042
		public const uint cPacketType = 3828043089u;
	}
}
