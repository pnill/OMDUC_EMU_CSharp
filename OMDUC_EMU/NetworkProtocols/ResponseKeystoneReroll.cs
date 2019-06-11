using System;

namespace NetworkProtocols
{
	// Token: 0x0200066D RID: 1645
	public class ResponseKeystoneReroll : BotNetMessage
	{
		// Token: 0x060039BA RID: 14778 RVA: 0x0001FEA5 File Offset: 0x0001E0A5
		public ResponseKeystoneReroll()
		{
			this.InitRefTypes();
			base.PacketType = 193026692u;
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0001FEBE File Offset: 0x0001E0BE
		public ResponseKeystoneReroll(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 193026692u;
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x0001FEDE File Offset: 0x0001E0DE
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x0001FEE6 File Offset: 0x0001E0E6
		public eKeystoneRerollStatus Status { get; set; }

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x0001FEEF File Offset: 0x0001E0EF
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x0001FEF7 File Offset: 0x0001E0F7
		public ulong RerolledKeystoneID { get; set; }

		// Token: 0x060039C0 RID: 14784 RVA: 0x0010FCBC File Offset: 0x0010DEBC
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
			ArrayManager.WriteeKeystoneRerollStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RerolledKeystoneID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x0010FD48 File Offset: 0x0010DF48
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeKeystoneRerollStatus(data, ref num);
			this.RerolledKeystoneID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x0001FF00 File Offset: 0x0001E100
		private void InitRefTypes()
		{
			this.Status = eKeystoneRerollStatus.Success;
			this.RerolledKeystoneID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E9D RID: 7837
		public const uint cPacketType = 193026692u;
	}
}
