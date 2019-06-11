using System;

namespace NetworkProtocols
{
	// Token: 0x020004AC RID: 1196
	public class ResponseClientHandshake : BotNetMessage
	{
		// Token: 0x06002AE3 RID: 10979 RVA: 0x00016836 File Offset: 0x00014A36
		public ResponseClientHandshake()
		{
			this.InitRefTypes();
			base.PacketType = 2533259941u;
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0001684F File Offset: 0x00014A4F
		public ResponseClientHandshake(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2533259941u;
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0001686F File Offset: 0x00014A6F
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x00016877 File Offset: 0x00014A77
		public eClientHandshakeOutcome Outcome { get; set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x00016880 File Offset: 0x00014A80
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x00016888 File Offset: 0x00014A88
		public string Reason { get; set; }

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000FBDA0 File Offset: 0x000F9FA0
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
			ArrayManager.WriteeClientHandshakeOutcome(ref newArray, ref newSize, this.Outcome);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Reason);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000FBE2C File Offset: 0x000FA02C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Outcome = ArrayManager.ReadeClientHandshakeOutcome(data, ref num);
			this.Reason = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00016891 File Offset: 0x00014A91
		private void InitRefTypes()
		{
			this.Outcome = eClientHandshakeOutcome.ClientHandshake_Failure;
			this.Reason = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400179F RID: 6047
		public const uint cPacketType = 2533259941u;
	}
}
