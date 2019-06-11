using System;

namespace NetworkProtocols
{
	// Token: 0x0200069F RID: 1695
	public class RequestLobbySwitchOwner : BotNetMessage
	{
		// Token: 0x06003B71 RID: 15217 RVA: 0x00021309 File Offset: 0x0001F509
		public RequestLobbySwitchOwner()
		{
			this.InitRefTypes();
			base.PacketType = 1050787770u;
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00021322 File Offset: 0x0001F522
		public RequestLobbySwitchOwner(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1050787770u;
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00021342 File Offset: 0x0001F542
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x0002134A File Offset: 0x0001F54A
		public ulong LobbyID { get; set; }

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x00021353 File Offset: 0x0001F553
		// (set) Token: 0x06003B76 RID: 15222 RVA: 0x0002135B File Offset: 0x0001F55B
		public ulong NewOwnerAccountSUID { get; set; }

		// Token: 0x06003B77 RID: 15223 RVA: 0x001127CC File Offset: 0x001109CC
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.NewOwnerAccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00112858 File Offset: 0x00110A58
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
			this.NewOwnerAccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00021364 File Offset: 0x0001F564
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.NewOwnerAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F88 RID: 8072
		public const uint cPacketType = 1050787770u;
	}
}
