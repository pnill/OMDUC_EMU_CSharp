using System;

namespace NetworkProtocols
{
	// Token: 0x020006CA RID: 1738
	public class ResponseUnsubscribeFromLobbyList : BotNetMessage
	{
		// Token: 0x06003E50 RID: 15952 RVA: 0x00023058 File Offset: 0x00021258
		public ResponseUnsubscribeFromLobbyList()
		{
			this.InitRefTypes();
			base.PacketType = 690075486u;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00023071 File Offset: 0x00021271
		public ResponseUnsubscribeFromLobbyList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 690075486u;
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06003E52 RID: 15954 RVA: 0x00023091 File Offset: 0x00021291
		// (set) Token: 0x06003E53 RID: 15955 RVA: 0x00023099 File Offset: 0x00021299
		public eLobbyRequestResult Status { get; set; }

		// Token: 0x06003E54 RID: 15956 RVA: 0x001167E8 File Offset: 0x001149E8
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
			ArrayManager.WriteeLobbyRequestResult(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00116868 File Offset: 0x00114A68
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeLobbyRequestResult(data, ref num);
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x000230A2 File Offset: 0x000212A2
		private void InitRefTypes()
		{
			this.Status = eLobbyRequestResult.LobbyRequest_Succeeded;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020B3 RID: 8371
		public const uint cPacketType = 690075486u;
	}
}
