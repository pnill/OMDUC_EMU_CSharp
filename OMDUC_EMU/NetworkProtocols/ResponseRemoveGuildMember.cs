using System;

namespace NetworkProtocols
{
	// Token: 0x02000748 RID: 1864
	public class ResponseRemoveGuildMember : BotNetMessage
	{
		// Token: 0x06004203 RID: 16899 RVA: 0x00025DA0 File Offset: 0x00023FA0
		public ResponseRemoveGuildMember()
		{
			this.InitRefTypes();
			base.PacketType = 3255014965u;
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00025DB9 File Offset: 0x00023FB9
		public ResponseRemoveGuildMember(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3255014965u;
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x00025DD9 File Offset: 0x00023FD9
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x00025DE1 File Offset: 0x00023FE1
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004207 RID: 16903 RVA: 0x0011FDCC File Offset: 0x0011DFCC
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

		// Token: 0x06004208 RID: 16904 RVA: 0x0011FE4C File Offset: 0x0011E04C
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

		// Token: 0x06004209 RID: 16905 RVA: 0x00025DEA File Offset: 0x00023FEA
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002295 RID: 8853
		public const uint cPacketType = 3255014965u;
	}
}
