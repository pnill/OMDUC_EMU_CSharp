using System;

namespace NetworkProtocols
{
	// Token: 0x02000711 RID: 1809
	public class FriendItem
	{
		// Token: 0x06004021 RID: 16417 RVA: 0x00024690 File Offset: 0x00022890
		public FriendItem()
		{
			this.InitRefTypes();
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x0002469E File Offset: 0x0002289E
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x000246A6 File Offset: 0x000228A6
		public ulong AccountSUID { get; set; }

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x000246AF File Offset: 0x000228AF
		// (set) Token: 0x06004025 RID: 16421 RVA: 0x000246B7 File Offset: 0x000228B7
		public string PlayerName { get; set; }

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x000246C0 File Offset: 0x000228C0
		// (set) Token: 0x06004027 RID: 16423 RVA: 0x000246C8 File Offset: 0x000228C8
		public string GuildTag { get; set; }

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x000246D1 File Offset: 0x000228D1
		// (set) Token: 0x06004029 RID: 16425 RVA: 0x000246D9 File Offset: 0x000228D9
		public string GuildName { get; set; }

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x000246E2 File Offset: 0x000228E2
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x000246EA File Offset: 0x000228EA
		public uint Level { get; set; }

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x000246F3 File Offset: 0x000228F3
		// (set) Token: 0x0600402D RID: 16429 RVA: 0x000246FB File Offset: 0x000228FB
		public ulong Avatar { get; set; }

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x00024704 File Offset: 0x00022904
		// (set) Token: 0x0600402F RID: 16431 RVA: 0x0002470C File Offset: 0x0002290C
		public ulong Badge { get; set; }

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x00024715 File Offset: 0x00022915
		// (set) Token: 0x06004031 RID: 16433 RVA: 0x0002471D File Offset: 0x0002291D
		public ulong Background { get; set; }

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x00024726 File Offset: 0x00022926
		// (set) Token: 0x06004033 RID: 16435 RVA: 0x0002472E File Offset: 0x0002292E
		public ulong Title { get; set; }

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x00024737 File Offset: 0x00022937
		// (set) Token: 0x06004035 RID: 16437 RVA: 0x0002473F File Offset: 0x0002293F
		public bool IsRobotEmployee { get; set; }

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x00024748 File Offset: 0x00022948
		// (set) Token: 0x06004037 RID: 16439 RVA: 0x00024750 File Offset: 0x00022950
		public ePlayerPresence Presence { get; set; }

		// Token: 0x06004038 RID: 16440 RVA: 0x0011CA34 File Offset: 0x0011AC34
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Avatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Badge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Background);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteePlayerPresence(ref newArray, ref newSize, this.Presence);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0011CAF8 File Offset: 0x0011ACF8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.Avatar = ArrayManager.ReadUInt64(data, ref num);
			this.Badge = ArrayManager.ReadUInt64(data, ref num);
			this.Background = ArrayManager.ReadUInt64(data, ref num);
			this.Title = ArrayManager.ReadUInt64(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.Presence = ArrayManager.ReadePlayerPresence(data, ref num);
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x0011CBA4 File Offset: 0x0011ADA4
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Level = 0u;
			this.Avatar = 0UL;
			this.Badge = 0UL;
			this.Background = 0UL;
			this.Title = 0UL;
			this.IsRobotEmployee = false;
			this.Presence = ePlayerPresence.PlayerPresence_None;
		}
	}
}
