using System;

namespace NetworkProtocols
{
	// Token: 0x02000746 RID: 1862
	public class ResponseCancelGuildInvite : BotNetMessage
	{
		// Token: 0x060041F3 RID: 16883 RVA: 0x00025CD2 File Offset: 0x00023ED2
		public ResponseCancelGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 2653907442u;
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00025CEB File Offset: 0x00023EEB
		public ResponseCancelGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2653907442u;
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x00025D0B File Offset: 0x00023F0B
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x00025D13 File Offset: 0x00023F13
		public ulong InviteID { get; set; }

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x00025D1C File Offset: 0x00023F1C
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x00025D24 File Offset: 0x00023F24
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060041F9 RID: 16889 RVA: 0x0011FBE0 File Offset: 0x0011DDE0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InviteID);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x0011FC6C File Offset: 0x0011DE6C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.InviteID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00025D2D File Offset: 0x00023F2D
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002290 RID: 8848
		public const uint cPacketType = 2653907442u;
	}
}
