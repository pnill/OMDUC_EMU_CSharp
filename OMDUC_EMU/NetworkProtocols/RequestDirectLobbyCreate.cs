using System;

namespace NetworkProtocols
{
	// Token: 0x02000695 RID: 1685
	public class RequestDirectLobbyCreate : BotNetMessage
	{
		// Token: 0x06003B01 RID: 15105 RVA: 0x00020D64 File Offset: 0x0001EF64
		public RequestDirectLobbyCreate()
		{
			this.InitRefTypes();
			base.PacketType = 1601419097u;
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00020D7D File Offset: 0x0001EF7D
		public RequestDirectLobbyCreate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1601419097u;
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x00020D9D File Offset: 0x0001EF9D
		// (set) Token: 0x06003B04 RID: 15108 RVA: 0x00020DA5 File Offset: 0x0001EFA5
		public string PlayerName { get; set; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x00020DAE File Offset: 0x0001EFAE
		// (set) Token: 0x06003B06 RID: 15110 RVA: 0x00020DB6 File Offset: 0x0001EFB6
		public string LobbyName { get; set; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x00020DBF File Offset: 0x0001EFBF
		// (set) Token: 0x06003B08 RID: 15112 RVA: 0x00020DC7 File Offset: 0x0001EFC7
		public bool IsPrivate { get; set; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x00020DD0 File Offset: 0x0001EFD0
		// (set) Token: 0x06003B0A RID: 15114 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		public eGameType GameType { get; set; }

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x00020DE1 File Offset: 0x0001EFE1
		// (set) Token: 0x06003B0C RID: 15116 RVA: 0x00020DE9 File Offset: 0x0001EFE9
		public eBotDifficulty BotDifficulty { get; set; }

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x00020DF2 File Offset: 0x0001EFF2
		// (set) Token: 0x06003B0E RID: 15118 RVA: 0x00020DFA File Offset: 0x0001EFFA
		public ulong MapGUID { get; set; }

		// Token: 0x06003B0F RID: 15119 RVA: 0x00111C64 File Offset: 0x0010FE64
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.LobbyName);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsPrivate);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteeBotDifficulty(ref newArray, ref newSize, this.BotDifficulty);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapGUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00111D2C File Offset: 0x0010FF2C
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
			this.LobbyName = ArrayManager.ReadString(data, ref num);
			this.IsPrivate = ArrayManager.ReadBoolean(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.BotDifficulty = ArrayManager.ReadeBotDifficulty(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00020E03 File Offset: 0x0001F003
		private void InitRefTypes()
		{
			this.PlayerName = string.Empty;
			this.LobbyName = string.Empty;
			this.IsPrivate = false;
			this.GameType = eGameType.None;
			this.BotDifficulty = eBotDifficulty.BotDifficulty_None;
			this.MapGUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F5F RID: 8031
		public const uint cPacketType = 1601419097u;
	}
}
