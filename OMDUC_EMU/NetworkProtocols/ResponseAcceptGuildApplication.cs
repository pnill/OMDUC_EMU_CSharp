using System;

namespace NetworkProtocols
{
	// Token: 0x0200073E RID: 1854
	public class ResponseAcceptGuildApplication : BotNetMessage
	{
		// Token: 0x060041B5 RID: 16821 RVA: 0x000259AA File Offset: 0x00023BAA
		public ResponseAcceptGuildApplication()
		{
			this.InitRefTypes();
			base.PacketType = 2470600690u;
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000259C3 File Offset: 0x00023BC3
		public ResponseAcceptGuildApplication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2470600690u;
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x000259E3 File Offset: 0x00023BE3
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x000259EB File Offset: 0x00023BEB
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060041B9 RID: 16825 RVA: 0x0011F44C File Offset: 0x0011D64C
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x0011F4CC File Offset: 0x0011D6CC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x000259F4 File Offset: 0x00023BF4
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400227D RID: 8829
		public const uint cPacketType = 2470600690u;
	}
}
