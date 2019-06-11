using System;

namespace NetworkProtocols
{
	// Token: 0x020006F3 RID: 1779
	public class NetworkPartyMember
	{
		// Token: 0x06003F78 RID: 16248 RVA: 0x00023EBF File Offset: 0x000220BF
		public NetworkPartyMember()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x00023ECD File Offset: 0x000220CD
		// (set) Token: 0x06003F7A RID: 16250 RVA: 0x00023ED5 File Offset: 0x000220D5
		public ulong AccountSUID { get; set; }

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x00023EDE File Offset: 0x000220DE
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x00023EE6 File Offset: 0x000220E6
		public uint AccountLevel { get; set; }

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x00023EEF File Offset: 0x000220EF
		// (set) Token: 0x06003F7E RID: 16254 RVA: 0x00023EF7 File Offset: 0x000220F7
		public string PlayerName { get; set; }

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x00023F00 File Offset: 0x00022100
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x00023F08 File Offset: 0x00022108
		public string GuildTag { get; set; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x00023F11 File Offset: 0x00022111
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x00023F19 File Offset: 0x00022119
		public string GuildName { get; set; }

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x00023F22 File Offset: 0x00022122
		// (set) Token: 0x06003F84 RID: 16260 RVA: 0x00023F2A File Offset: 0x0002212A
		public bool IsRobotEmployee { get; set; }

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003F85 RID: 16261 RVA: 0x00023F33 File Offset: 0x00022133
		// (set) Token: 0x06003F86 RID: 16262 RVA: 0x00023F3B File Offset: 0x0002213B
		public ulong Avatar { get; set; }

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x00023F44 File Offset: 0x00022144
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x00023F4C File Offset: 0x0002214C
		public ulong Background { get; set; }

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x00023F55 File Offset: 0x00022155
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x00023F5D File Offset: 0x0002215D
		public ulong Badge { get; set; }

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x00023F66 File Offset: 0x00022166
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x00023F6E File Offset: 0x0002216E
		public ulong Title { get; set; }

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x00023F77 File Offset: 0x00022177
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x00023F7F File Offset: 0x0002217F
		public bool IsLeader { get; set; }

		// Token: 0x06003F8F RID: 16271 RVA: 0x0011BB30 File Offset: 0x00119D30
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.AccountLevel);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Avatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Background);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Badge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsLeader);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x0011BBF4 File Offset: 0x00119DF4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.AccountLevel = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.Avatar = ArrayManager.ReadUInt64(data, ref num);
			this.Background = ArrayManager.ReadUInt64(data, ref num);
			this.Badge = ArrayManager.ReadUInt64(data, ref num);
			this.Title = ArrayManager.ReadUInt64(data, ref num);
			this.IsLeader = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x0011BCA0 File Offset: 0x00119EA0
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.AccountLevel = 0u;
			this.PlayerName = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.IsRobotEmployee = false;
			this.Avatar = 0UL;
			this.Background = 0UL;
			this.Badge = 0UL;
			this.Title = 0UL;
			this.IsLeader = false;
		}
	}
}
