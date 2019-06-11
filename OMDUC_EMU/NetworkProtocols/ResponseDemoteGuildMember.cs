using System;

namespace NetworkProtocols
{
	// Token: 0x02000734 RID: 1844
	public class ResponseDemoteGuildMember : BotNetMessage
	{
		// Token: 0x06004151 RID: 16721 RVA: 0x0002557B File Offset: 0x0002377B
		public ResponseDemoteGuildMember()
		{
			this.InitRefTypes();
			base.PacketType = 305794315u;
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x00025594 File Offset: 0x00023794
		public ResponseDemoteGuildMember(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 305794315u;
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x000255B4 File Offset: 0x000237B4
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x000255BC File Offset: 0x000237BC
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004155 RID: 16725 RVA: 0x0011EB78 File Offset: 0x0011CD78
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

		// Token: 0x06004156 RID: 16726 RVA: 0x0011EBF8 File Offset: 0x0011CDF8
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

		// Token: 0x06004157 RID: 16727 RVA: 0x000255C5 File Offset: 0x000237C5
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400225B RID: 8795
		public const uint cPacketType = 305794315u;
	}
}
