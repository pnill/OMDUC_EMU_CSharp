using System;

namespace NetworkProtocols
{
	// Token: 0x02000728 RID: 1832
	public class ResponseRejectGuildApplication : BotNetMessage
	{
		// Token: 0x060040F3 RID: 16627 RVA: 0x000250AE File Offset: 0x000232AE
		public ResponseRejectGuildApplication()
		{
			this.InitRefTypes();
			base.PacketType = 3379155387u;
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x000250C7 File Offset: 0x000232C7
		public ResponseRejectGuildApplication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3379155387u;
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x000250E7 File Offset: 0x000232E7
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x000250EF File Offset: 0x000232EF
		public ulong ApplicationID { get; set; }

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x000250F8 File Offset: 0x000232F8
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x00025100 File Offset: 0x00023300
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060040F9 RID: 16633 RVA: 0x0011E00C File Offset: 0x0011C20C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ApplicationID);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0011E098 File Offset: 0x0011C298
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ApplicationID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x00025109 File Offset: 0x00023309
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400223E RID: 8766
		public const uint cPacketType = 3379155387u;
	}
}
