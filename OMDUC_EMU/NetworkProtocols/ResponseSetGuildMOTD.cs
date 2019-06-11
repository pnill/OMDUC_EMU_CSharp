using System;

namespace NetworkProtocols
{
	// Token: 0x0200075A RID: 1882
	public class ResponseSetGuildMOTD : BotNetMessage
	{
		// Token: 0x060042D9 RID: 17113 RVA: 0x000265F6 File Offset: 0x000247F6
		public ResponseSetGuildMOTD()
		{
			this.InitRefTypes();
			base.PacketType = 3837663253u;
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x0002660F File Offset: 0x0002480F
		public ResponseSetGuildMOTD(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3837663253u;
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x0002662F File Offset: 0x0002482F
		// (set) Token: 0x060042DC RID: 17116 RVA: 0x00026637 File Offset: 0x00024837
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060042DD RID: 17117 RVA: 0x0012101C File Offset: 0x0011F21C
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

		// Token: 0x060042DE RID: 17118 RVA: 0x0012109C File Offset: 0x0011F29C
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

		// Token: 0x060042DF RID: 17119 RVA: 0x00026640 File Offset: 0x00024840
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022E2 RID: 8930
		public const uint cPacketType = 3837663253u;
	}
}
