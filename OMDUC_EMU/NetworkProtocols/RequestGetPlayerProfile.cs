using System;

namespace NetworkProtocols
{
	// Token: 0x02000754 RID: 1876
	public class RequestGetPlayerProfile : BotNetMessage
	{
		// Token: 0x060042A7 RID: 17063 RVA: 0x000263B1 File Offset: 0x000245B1
		public RequestGetPlayerProfile()
		{
			this.InitRefTypes();
			base.PacketType = 1710476665u;
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000263CA File Offset: 0x000245CA
		public RequestGetPlayerProfile(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1710476665u;
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x000263EA File Offset: 0x000245EA
		// (set) Token: 0x060042AA RID: 17066 RVA: 0x000263F2 File Offset: 0x000245F2
		public ulong TargetAccountSUID { get; set; }

		// Token: 0x060042AB RID: 17067 RVA: 0x00120B50 File Offset: 0x0011ED50
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TargetAccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x00120BD0 File Offset: 0x0011EDD0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TargetAccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000263FB File Offset: 0x000245FB
		private void InitRefTypes()
		{
			this.TargetAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022D3 RID: 8915
		public const uint cPacketType = 1710476665u;
	}
}
