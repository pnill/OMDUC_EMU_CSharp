using System;

namespace NetworkProtocols
{
	// Token: 0x020004AD RID: 1197
	public class RequestSecurityHandshake : BotNetMessage
	{
		// Token: 0x06002AEC RID: 10988 RVA: 0x000168AC File Offset: 0x00014AAC
		public RequestSecurityHandshake()
		{
			this.InitRefTypes();
			base.PacketType = 878073396u;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000168C5 File Offset: 0x00014AC5
		public RequestSecurityHandshake(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 878073396u;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000168E5 File Offset: 0x00014AE5
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x000168ED File Offset: 0x00014AED
		public string SharedKey { get; set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000168F6 File Offset: 0x00014AF6
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x000168FE File Offset: 0x00014AFE
		public string SharedIV { get; set; }

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000FBEA4 File Offset: 0x000FA0A4
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.SharedKey);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SharedIV);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000FBF30 File Offset: 0x000FA130
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SharedKey = ArrayManager.ReadString(data, ref num);
			this.SharedIV = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00016907 File Offset: 0x00014B07
		private void InitRefTypes()
		{
			this.SharedKey = string.Empty;
			this.SharedIV = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040017A2 RID: 6050
		public const uint cPacketType = 878073396u;
	}
}
