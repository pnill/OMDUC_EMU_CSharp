using System;

namespace NetworkProtocols
{
	// Token: 0x02000694 RID: 1684
	public class RequestLobbyLockTeams : BotNetMessage
	{
		// Token: 0x06003AFA RID: 15098 RVA: 0x00020D09 File Offset: 0x0001EF09
		public RequestLobbyLockTeams()
		{
			this.InitRefTypes();
			base.PacketType = 2639488929u;
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00020D22 File Offset: 0x0001EF22
		public RequestLobbyLockTeams(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2639488929u;
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00020D42 File Offset: 0x0001EF42
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x00020D4A File Offset: 0x0001EF4A
		public ulong LobbyID { get; set; }

		// Token: 0x06003AFE RID: 15102 RVA: 0x00111B7C File Offset: 0x0010FD7C
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

		// Token: 0x06003AFF RID: 15103 RVA: 0x00111BFC File Offset: 0x0010FDFC
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

		// Token: 0x06003B00 RID: 15104 RVA: 0x00020D53 File Offset: 0x0001EF53
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F5D RID: 8029
		public const uint cPacketType = 2639488929u;
	}
}
