using System;

namespace NetworkProtocols
{
	// Token: 0x020006BA RID: 1722
	public class RequestCreateLobbyKeystone : BotNetMessage
	{
		// Token: 0x06003DBB RID: 15803 RVA: 0x000228F5 File Offset: 0x00020AF5
		public RequestCreateLobbyKeystone()
		{
			this.InitRefTypes();
			base.PacketType = 4116325538u;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x0002290E File Offset: 0x00020B0E
		public RequestCreateLobbyKeystone(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4116325538u;
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x0002292E File Offset: 0x00020B2E
		// (set) Token: 0x06003DBE RID: 15806 RVA: 0x00022936 File Offset: 0x00020B36
		public string PlayerName { get; set; }

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x0002293F File Offset: 0x00020B3F
		// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x00022947 File Offset: 0x00020B47
		public ulong KeystoneID { get; set; }

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x00022950 File Offset: 0x00020B50
		// (set) Token: 0x06003DC2 RID: 15810 RVA: 0x00022958 File Offset: 0x00020B58
		public string LobbyName { get; set; }

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00115980 File Offset: 0x00113B80
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LobbyName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00115A1C File Offset: 0x00113C1C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
			this.LobbyName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00022961 File Offset: 0x00020B61
		private void InitRefTypes()
		{
			this.PlayerName = string.Empty;
			this.KeystoneID = 0UL;
			this.LobbyName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002081 RID: 8321
		public const uint cPacketType = 4116325538u;
	}
}
