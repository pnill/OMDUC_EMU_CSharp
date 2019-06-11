using System;

namespace NetworkProtocols
{
	// Token: 0x02000740 RID: 1856
	public class ResponseSendGuildInvite : BotNetMessage
	{
		// Token: 0x060041C3 RID: 16835 RVA: 0x00025A62 File Offset: 0x00023C62
		public ResponseSendGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 1916628191u;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00025A7B File Offset: 0x00023C7B
		public ResponseSendGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1916628191u;
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x00025A9B File Offset: 0x00023C9B
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x00025AA3 File Offset: 0x00023CA3
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060041C7 RID: 16839 RVA: 0x0011F61C File Offset: 0x0011D81C
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

		// Token: 0x060041C8 RID: 16840 RVA: 0x0011F69C File Offset: 0x0011D89C
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

		// Token: 0x060041C9 RID: 16841 RVA: 0x00025AAC File Offset: 0x00023CAC
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002281 RID: 8833
		public const uint cPacketType = 1916628191u;
	}
}
