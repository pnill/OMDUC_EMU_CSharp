using System;

namespace NetworkProtocols
{
	// Token: 0x02000727 RID: 1831
	public class RequestRejectGuildApplication : BotNetMessage
	{
		// Token: 0x060040EC RID: 16620 RVA: 0x00025053 File Offset: 0x00023253
		public RequestRejectGuildApplication()
		{
			this.InitRefTypes();
			base.PacketType = 1763839624u;
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x0002506C File Offset: 0x0002326C
		public RequestRejectGuildApplication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1763839624u;
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060040EE RID: 16622 RVA: 0x0002508C File Offset: 0x0002328C
		// (set) Token: 0x060040EF RID: 16623 RVA: 0x00025094 File Offset: 0x00023294
		public ulong ApplicationID { get; set; }

		// Token: 0x060040F0 RID: 16624 RVA: 0x0011DF24 File Offset: 0x0011C124
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x0011DFA4 File Offset: 0x0011C1A4
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
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x0002509D File Offset: 0x0002329D
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400223C RID: 8764
		public const uint cPacketType = 1763839624u;
	}
}
