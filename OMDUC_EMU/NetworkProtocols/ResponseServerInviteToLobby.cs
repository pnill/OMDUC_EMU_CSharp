using System;

namespace NetworkProtocols
{
	// Token: 0x020006C1 RID: 1729
	public class ResponseServerInviteToLobby : BotNetMessage
	{
		// Token: 0x06003E02 RID: 15874 RVA: 0x00022C95 File Offset: 0x00020E95
		public ResponseServerInviteToLobby()
		{
			this.InitRefTypes();
			base.PacketType = 2067121577u;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x00022CAE File Offset: 0x00020EAE
		public ResponseServerInviteToLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2067121577u;
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x00022CCE File Offset: 0x00020ECE
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x00022CD6 File Offset: 0x00020ED6
		public ulong LobbyID { get; set; }

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x00022CDF File Offset: 0x00020EDF
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x00022CE7 File Offset: 0x00020EE7
		public bool DidJoin { get; set; }

		// Token: 0x06003E08 RID: 15880 RVA: 0x0011610C File Offset: 0x0011430C
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DidJoin);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00116198 File Offset: 0x00114398
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
			this.DidJoin = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x00022CF0 File Offset: 0x00020EF0
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.DidJoin = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400209A RID: 8346
		public const uint cPacketType = 2067121577u;
	}
}
