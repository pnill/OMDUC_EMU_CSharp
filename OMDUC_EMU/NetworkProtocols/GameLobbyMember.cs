using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006AE RID: 1710
	public class GameLobbyMember
	{
		// Token: 0x06003C1B RID: 15387 RVA: 0x00021AA2 File Offset: 0x0001FCA2
		public GameLobbyMember()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x00021AB8 File Offset: 0x0001FCB8
		public ulong SessionToken { get; set; }

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x00021AC1 File Offset: 0x0001FCC1
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x00021AC9 File Offset: 0x0001FCC9
		public uint MemberID { get; set; }

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x00021AD2 File Offset: 0x0001FCD2
		// (set) Token: 0x06003C21 RID: 15393 RVA: 0x00021ADA File Offset: 0x0001FCDA
		public string Name { get; set; }

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x00021AE3 File Offset: 0x0001FCE3
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x00021AEB File Offset: 0x0001FCEB
		public ulong GuildID { get; set; }

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x00021AF4 File Offset: 0x0001FCF4
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x00021AFC File Offset: 0x0001FCFC
		public string GuildTag { get; set; }

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00021B05 File Offset: 0x0001FD05
		// (set) Token: 0x06003C27 RID: 15399 RVA: 0x00021B0D File Offset: 0x0001FD0D
		public string GuildName { get; set; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003C28 RID: 15400 RVA: 0x00021B16 File Offset: 0x0001FD16
		// (set) Token: 0x06003C29 RID: 15401 RVA: 0x00021B1E File Offset: 0x0001FD1E
		public bool Ready { get; set; }

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x00021B27 File Offset: 0x0001FD27
		// (set) Token: 0x06003C2B RID: 15403 RVA: 0x00021B2F File Offset: 0x0001FD2F
		public uint Team { get; set; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x00021B38 File Offset: 0x0001FD38
		// (set) Token: 0x06003C2D RID: 15405 RVA: 0x00021B40 File Offset: 0x0001FD40
		public ulong SelectedCharacter { get; set; }

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x00021B49 File Offset: 0x0001FD49
		// (set) Token: 0x06003C2F RID: 15407 RVA: 0x00021B51 File Offset: 0x0001FD51
		public int GameSessionPlayerGUID { get; set; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x00021B5A File Offset: 0x0001FD5A
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x00021B62 File Offset: 0x0001FD62
		public ulong AccountSUID { get; set; }

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x00021B6B File Offset: 0x0001FD6B
		// (set) Token: 0x06003C33 RID: 15411 RVA: 0x00021B73 File Offset: 0x0001FD73
		public ulong PartyID { get; set; }

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x00021B7C File Offset: 0x0001FD7C
		// (set) Token: 0x06003C35 RID: 15413 RVA: 0x00021B84 File Offset: 0x0001FD84
		public uint Level { get; set; }

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x00021B8D File Offset: 0x0001FD8D
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x00021B95 File Offset: 0x0001FD95
		public ulong Avatar { get; set; }

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x00021B9E File Offset: 0x0001FD9E
		// (set) Token: 0x06003C39 RID: 15417 RVA: 0x00021BA6 File Offset: 0x0001FDA6
		public ulong Badge { get; set; }

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06003C3A RID: 15418 RVA: 0x00021BAF File Offset: 0x0001FDAF
		// (set) Token: 0x06003C3B RID: 15419 RVA: 0x00021BB7 File Offset: 0x0001FDB7
		public ulong Background { get; set; }

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06003C3C RID: 15420 RVA: 0x00021BC0 File Offset: 0x0001FDC0
		// (set) Token: 0x06003C3D RID: 15421 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		public ulong Title { get; set; }

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06003C3E RID: 15422 RVA: 0x00021BD1 File Offset: 0x0001FDD1
		// (set) Token: 0x06003C3F RID: 15423 RVA: 0x00021BD9 File Offset: 0x0001FDD9
		public bool IsPendingInvite { get; set; }

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06003C40 RID: 15424 RVA: 0x00021BE2 File Offset: 0x0001FDE2
		// (set) Token: 0x06003C41 RID: 15425 RVA: 0x00021BEA File Offset: 0x0001FDEA
		public bool IsRobotEmployee { get; set; }

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06003C42 RID: 15426 RVA: 0x00021BF3 File Offset: 0x0001FDF3
		// (set) Token: 0x06003C43 RID: 15427 RVA: 0x00021BFB File Offset: 0x0001FDFB
		public ulong SelectedPlayerSkin { get; set; }

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x00021C04 File Offset: 0x0001FE04
		// (set) Token: 0x06003C45 RID: 15429 RVA: 0x00021C0C File Offset: 0x0001FE0C
		public ulong SelectedDeckGUID { get; set; }

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x00021C15 File Offset: 0x0001FE15
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x00021C1D File Offset: 0x0001FE1D
		public bool IsCharacterSelected { get; set; }

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x00021C26 File Offset: 0x0001FE26
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x00021C2E File Offset: 0x0001FE2E
		public List<PlayerBoostStatus> PlayerBoosts { get; set; }

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x00021C37 File Offset: 0x0001FE37
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x00021C3F File Offset: 0x0001FE3F
		public DeckEntry SelectedDeck { get; set; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x00021C48 File Offset: 0x0001FE48
		// (set) Token: 0x06003C4D RID: 15437 RVA: 0x00021C50 File Offset: 0x0001FE50
		public bool IsStreamModeEnabled { get; set; }

		// Token: 0x06003C4E RID: 15438 RVA: 0x00113968 File Offset: 0x00111B68
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SessionToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MemberID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Ready);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Team);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedCharacter);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.GameSessionPlayerGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Avatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Badge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Background);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsPendingInvite);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedPlayerSkin);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedDeckGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsCharacterSelected);
			ArrayManager.WriteListPlayerBoostStatus(ref newArray, ref newSize, this.PlayerBoosts);
			ArrayManager.WriteDeckEntry(ref newArray, ref newSize, this.SelectedDeck);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsStreamModeEnabled);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00113B00 File Offset: 0x00111D00
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			this.MemberID = ArrayManager.ReadUInt32(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Ready = ArrayManager.ReadBoolean(data, ref num);
			this.Team = ArrayManager.ReadUInt32(data, ref num);
			this.SelectedCharacter = ArrayManager.ReadUInt64(data, ref num);
			this.GameSessionPlayerGUID = ArrayManager.ReadInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.Avatar = ArrayManager.ReadUInt64(data, ref num);
			this.Badge = ArrayManager.ReadUInt64(data, ref num);
			this.Background = ArrayManager.ReadUInt64(data, ref num);
			this.Title = ArrayManager.ReadUInt64(data, ref num);
			this.IsPendingInvite = ArrayManager.ReadBoolean(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.SelectedPlayerSkin = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedDeckGUID = ArrayManager.ReadUInt64(data, ref num);
			this.IsCharacterSelected = ArrayManager.ReadBoolean(data, ref num);
			this.PlayerBoosts = ArrayManager.ReadListPlayerBoostStatus(data, ref num);
			this.SelectedDeck = ArrayManager.ReadDeckEntry(data, ref num);
			this.IsStreamModeEnabled = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x00113C70 File Offset: 0x00111E70
		private void InitRefTypes()
		{
			this.SessionToken = 0UL;
			this.MemberID = 0u;
			this.Name = string.Empty;
			this.GuildID = 0UL;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Ready = false;
			this.Team = 0u;
			this.SelectedCharacter = 0UL;
			this.GameSessionPlayerGUID = 0;
			this.AccountSUID = 0UL;
			this.PartyID = 0UL;
			this.Level = 0u;
			this.Avatar = 0UL;
			this.Badge = 0UL;
			this.Background = 0UL;
			this.Title = 0UL;
			this.IsPendingInvite = false;
			this.IsRobotEmployee = false;
			this.SelectedPlayerSkin = 0UL;
			this.SelectedDeckGUID = 0UL;
			this.IsCharacterSelected = false;
			this.PlayerBoosts = new List<PlayerBoostStatus>();
			this.SelectedDeck = new DeckEntry();
			this.IsStreamModeEnabled = false;
		}
	}
}
