using System;

namespace NetworkProtocols
{
	// Token: 0x02000759 RID: 1881
	public class RequestSetGuildMOTD : BotNetMessage
	{
		// Token: 0x060042D2 RID: 17106 RVA: 0x00026598 File Offset: 0x00024798
		public RequestSetGuildMOTD()
		{
			this.InitRefTypes();
			base.PacketType = 1407420368u;
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x000265B1 File Offset: 0x000247B1
		public RequestSetGuildMOTD(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1407420368u;
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x000265D1 File Offset: 0x000247D1
		// (set) Token: 0x060042D5 RID: 17109 RVA: 0x000265D9 File Offset: 0x000247D9
		public string MOTD { get; set; }

		// Token: 0x060042D6 RID: 17110 RVA: 0x00120F34 File Offset: 0x0011F134
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.MOTD);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00120FB4 File Offset: 0x0011F1B4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MOTD = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x000265E2 File Offset: 0x000247E2
		private void InitRefTypes()
		{
			this.MOTD = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022E0 RID: 8928
		public const uint cPacketType = 1407420368u;
	}
}
