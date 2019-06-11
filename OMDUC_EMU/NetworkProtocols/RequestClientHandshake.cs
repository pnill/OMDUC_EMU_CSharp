using System;

namespace NetworkProtocols
{
	// Token: 0x020004AB RID: 1195
	public class RequestClientHandshake : BotNetMessage
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x000167DC File Offset: 0x000149DC
		public RequestClientHandshake()
		{
			this.InitRefTypes();
			base.PacketType = 3801716005u;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000167F5 File Offset: 0x000149F5
		public RequestClientHandshake(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3801716005u;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x00016815 File Offset: 0x00014A15
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x0001681D File Offset: 0x00014A1D
		public uint ProtocolVersion { get; set; }

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000FBCB8 File Offset: 0x000F9EB8
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
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ProtocolVersion);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000FBD38 File Offset: 0x000F9F38
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ProtocolVersion = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00016826 File Offset: 0x00014A26
		private void InitRefTypes()
		{
			this.ProtocolVersion = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400179D RID: 6045
		public const uint cPacketType = 3801716005u;
	}
}
