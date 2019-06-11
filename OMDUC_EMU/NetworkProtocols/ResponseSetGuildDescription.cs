using System;

namespace NetworkProtocols
{
	// Token: 0x0200075C RID: 1884
	public class ResponseSetGuildDescription : BotNetMessage
	{
		// Token: 0x060042E7 RID: 17127 RVA: 0x000266AE File Offset: 0x000248AE
		public ResponseSetGuildDescription()
		{
			this.InitRefTypes();
			base.PacketType = 3239978574u;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000266C7 File Offset: 0x000248C7
		public ResponseSetGuildDescription(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3239978574u;
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x000266E7 File Offset: 0x000248E7
		// (set) Token: 0x060042EA RID: 17130 RVA: 0x000266EF File Offset: 0x000248EF
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060042EB RID: 17131 RVA: 0x001211EC File Offset: 0x0011F3EC
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

		// Token: 0x060042EC RID: 17132 RVA: 0x0012126C File Offset: 0x0011F46C
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

		// Token: 0x060042ED RID: 17133 RVA: 0x000266F8 File Offset: 0x000248F8
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022E6 RID: 8934
		public const uint cPacketType = 3239978574u;
	}
}
