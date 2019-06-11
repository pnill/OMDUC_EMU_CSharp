using System;

namespace NetworkProtocols
{
	// Token: 0x020006B6 RID: 1718
	public class DataLobbyChat : BotNetMessage
	{
		// Token: 0x06003D88 RID: 15752 RVA: 0x000226CD File Offset: 0x000208CD
		public DataLobbyChat()
		{
			this.InitRefTypes();
			base.PacketType = 3375915592u;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x000226E6 File Offset: 0x000208E6
		public DataLobbyChat(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3375915592u;
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x00022706 File Offset: 0x00020906
		// (set) Token: 0x06003D8B RID: 15755 RVA: 0x0002270E File Offset: 0x0002090E
		public ulong LobbyID { get; set; }

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06003D8C RID: 15756 RVA: 0x00022717 File Offset: 0x00020917
		// (set) Token: 0x06003D8D RID: 15757 RVA: 0x0002271F File Offset: 0x0002091F
		public string PlayerName { get; set; }

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x00022728 File Offset: 0x00020928
		// (set) Token: 0x06003D8F RID: 15759 RVA: 0x00022730 File Offset: 0x00020930
		public string GuildTag { get; set; }

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06003D90 RID: 15760 RVA: 0x00022739 File Offset: 0x00020939
		// (set) Token: 0x06003D91 RID: 15761 RVA: 0x00022741 File Offset: 0x00020941
		public string GuildName { get; set; }

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06003D92 RID: 15762 RVA: 0x0002274A File Offset: 0x0002094A
		// (set) Token: 0x06003D93 RID: 15763 RVA: 0x00022752 File Offset: 0x00020952
		public uint Level { get; set; }

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06003D94 RID: 15764 RVA: 0x0002275B File Offset: 0x0002095B
		// (set) Token: 0x06003D95 RID: 15765 RVA: 0x00022763 File Offset: 0x00020963
		public bool IsRobotEmployee { get; set; }

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x0002276C File Offset: 0x0002096C
		// (set) Token: 0x06003D97 RID: 15767 RVA: 0x00022774 File Offset: 0x00020974
		public string ChatLine { get; set; }

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x0002277D File Offset: 0x0002097D
		// (set) Token: 0x06003D99 RID: 15769 RVA: 0x00022785 File Offset: 0x00020985
		public bool TeamOnly { get; set; }

		// Token: 0x06003D9A RID: 15770 RVA: 0x001154C0 File Offset: 0x001136C0
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ChatLine);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.TeamOnly);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x001155A8 File Offset: 0x001137A8
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
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.ChatLine = ArrayManager.ReadString(data, ref num);
			this.TeamOnly = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00115674 File Offset: 0x00113874
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.PlayerName = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Level = 0u;
			this.IsRobotEmployee = false;
			this.ChatLine = string.Empty;
			this.TeamOnly = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400206E RID: 8302
		public const uint cPacketType = 3375915592u;
	}
}
