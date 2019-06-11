using System;

namespace NetworkProtocols
{
	// Token: 0x020004AE RID: 1198
	public class ResponseSecurityHandshake : BotNetMessage
	{
		// Token: 0x06002AF5 RID: 10997 RVA: 0x00016926 File Offset: 0x00014B26
		public ResponseSecurityHandshake()
		{
			this.InitRefTypes();
			base.PacketType = 1063273969u;
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0001693F File Offset: 0x00014B3F
		public ResponseSecurityHandshake(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1063273969u;
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000FBC5C File Offset: 0x000F9E5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040017A5 RID: 6053
		public const uint cPacketType = 1063273969u;
	}
}
