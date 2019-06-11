using System;

namespace NetworkProtocols
{
	// Token: 0x020006AA RID: 1706
	public class ResponseLobbyRequest : BotNetMessage
	{
		// Token: 0x06003BD4 RID: 15316 RVA: 0x00021803 File Offset: 0x0001FA03
		public ResponseLobbyRequest()
		{
			this.InitRefTypes();
			base.PacketType = 349583411u;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x0002181C File Offset: 0x0001FA1C
		public ResponseLobbyRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 349583411u;
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x0002183C File Offset: 0x0001FA3C
		// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x00021844 File Offset: 0x0001FA44
		public ulong LobbyID { get; set; }

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x0002184D File Offset: 0x0001FA4D
		// (set) Token: 0x06003BD9 RID: 15321 RVA: 0x00021855 File Offset: 0x0001FA55
		public eLobbyRequestResult Result { get; set; }

		// Token: 0x06003BDA RID: 15322 RVA: 0x001132F8 File Offset: 0x001114F8
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
			ArrayManager.WriteeLobbyRequestResult(ref newArray, ref newSize, this.Result);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00113384 File Offset: 0x00111584
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
			this.Result = ArrayManager.ReadeLobbyRequestResult(data, ref num);
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x0002185E File Offset: 0x0001FA5E
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.Result = eLobbyRequestResult.LobbyRequest_Succeeded;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FA9 RID: 8105
		public const uint cPacketType = 349583411u;
	}
}
