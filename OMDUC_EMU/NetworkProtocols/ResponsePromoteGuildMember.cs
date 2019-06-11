using System;

namespace NetworkProtocols
{
	// Token: 0x02000732 RID: 1842
	public class ResponsePromoteGuildMember : BotNetMessage
	{
		// Token: 0x06004143 RID: 16707 RVA: 0x000254C6 File Offset: 0x000236C6
		public ResponsePromoteGuildMember()
		{
			this.InitRefTypes();
			base.PacketType = 2144674986u;
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x000254DF File Offset: 0x000236DF
		public ResponsePromoteGuildMember(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2144674986u;
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x000254FF File Offset: 0x000236FF
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x00025507 File Offset: 0x00023707
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004147 RID: 16711 RVA: 0x0011E9A8 File Offset: 0x0011CBA8
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

		// Token: 0x06004148 RID: 16712 RVA: 0x0011EA28 File Offset: 0x0011CC28
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

		// Token: 0x06004149 RID: 16713 RVA: 0x00025510 File Offset: 0x00023710
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002257 RID: 8791
		public const uint cPacketType = 2144674986u;
	}
}
