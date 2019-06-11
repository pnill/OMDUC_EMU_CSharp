using System;

namespace NetworkProtocols
{
	// Token: 0x02000693 RID: 1683
	public class RequestLobbyDetail : BotNetMessage
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x00020CAE File Offset: 0x0001EEAE
		public RequestLobbyDetail()
		{
			this.InitRefTypes();
			base.PacketType = 3759057617u;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00020CC7 File Offset: 0x0001EEC7
		public RequestLobbyDetail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3759057617u;
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x00020CE7 File Offset: 0x0001EEE7
		// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x00020CEF File Offset: 0x0001EEEF
		public ulong LobbyID { get; set; }

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00111A94 File Offset: 0x0010FC94
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LobbyID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00111B14 File Offset: 0x0010FD14
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LobbyID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F5B RID: 8027
		public const uint cPacketType = 3759057617u;
	}
}
