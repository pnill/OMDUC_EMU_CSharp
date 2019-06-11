using System;

namespace NetworkProtocols
{
	// Token: 0x02000604 RID: 1540
	public class SteamLoginResponse : BotNetMessage
	{
		// Token: 0x06003598 RID: 13720 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
		public SteamLoginResponse()
		{
			this.InitRefTypes();
			base.PacketType = 2459401689u;
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0001D1E1 File Offset: 0x0001B3E1
		public SteamLoginResponse(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2459401689u;
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x0001D201 File Offset: 0x0001B401
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x0001D209 File Offset: 0x0001B409
		public string Username { get; set; }

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x0001D212 File Offset: 0x0001B412
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x0001D21A File Offset: 0x0001B41A
		public ulong AccountSUID { get; set; }

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x0001D223 File Offset: 0x0001B423
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x0001D22B File Offset: 0x0001B42B
		public string GuildTag { get; set; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x0001D234 File Offset: 0x0001B434
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x0001D23C File Offset: 0x0001B43C
		public string GuildName { get; set; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x0001D245 File Offset: 0x0001B445
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x0001D24D File Offset: 0x0001B44D
		public ulong GuildID { get; set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x0001D256 File Offset: 0x0001B456
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x0001D25E File Offset: 0x0001B45E
		public ulong ResponseSecurityToken { get; set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x0001D267 File Offset: 0x0001B467
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x0001D26F File Offset: 0x0001B46F
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x0001D278 File Offset: 0x0001B478
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x0001D280 File Offset: 0x0001B480
		public ePriceCurrencyType PlayerCurrency { get; set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x0001D289 File Offset: 0x0001B489
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x0001D291 File Offset: 0x0001B491
		public bool GameInProgress { get; set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x0001D29A File Offset: 0x0001B49A
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x0001D2A2 File Offset: 0x0001B4A2
		public eGameType GameType { get; set; }

		// Token: 0x060035AE RID: 13742 RVA: 0x00109788 File Offset: 0x00107988
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ResponseSecurityToken);
			ArrayManager.WriteeAuthLoginUserStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.PlayerCurrency);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GameInProgress);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0010988C File Offset: 0x00107A8C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.ResponseSecurityToken = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeAuthLoginUserStatus(data, ref num);
			this.PlayerCurrency = ArrayManager.ReadePriceCurrencyType(data, ref num);
			this.GameInProgress = ArrayManager.ReadBoolean(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00109974 File Offset: 0x00107B74
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.AccountSUID = 0UL;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.GuildID = 0UL;
			this.ResponseSecurityToken = 0UL;
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			this.PlayerCurrency = ePriceCurrencyType.None;
			this.GameInProgress = false;
			this.GameType = eGameType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D3A RID: 7482
		public const uint cPacketType = 2459401689u;
	}
}
