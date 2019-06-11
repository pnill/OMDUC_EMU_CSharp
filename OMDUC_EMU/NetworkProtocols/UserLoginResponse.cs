using System;

namespace NetworkProtocols
{
	// Token: 0x0200058E RID: 1422
	public class UserLoginResponse : BotNetMessage
	{
		// Token: 0x06003113 RID: 12563 RVA: 0x0001A49E File Offset: 0x0001869E
		public UserLoginResponse()
		{
			this.InitRefTypes();
			base.PacketType = 3827495177u;
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0001A4B7 File Offset: 0x000186B7
		public UserLoginResponse(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3827495177u;
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x0001A4D7 File Offset: 0x000186D7
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x0001A4DF File Offset: 0x000186DF
		public string Username { get; set; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x0001A4E8 File Offset: 0x000186E8
		// (set) Token: 0x06003118 RID: 12568 RVA: 0x0001A4F0 File Offset: 0x000186F0
		public ulong AccountSUID { get; set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x0001A4F9 File Offset: 0x000186F9
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x0001A501 File Offset: 0x00018701
		public string GuildTag { get; set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x0001A50A File Offset: 0x0001870A
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x0001A512 File Offset: 0x00018712
		public string GuildName { get; set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x0001A51B File Offset: 0x0001871B
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x0001A523 File Offset: 0x00018723
		public ulong GuildID { get; set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x0001A52C File Offset: 0x0001872C
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x0001A534 File Offset: 0x00018734
		public ulong ResponseSecurityToken { get; set; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x0001A53D File Offset: 0x0001873D
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x0001A545 File Offset: 0x00018745
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x0001A54E File Offset: 0x0001874E
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x0001A556 File Offset: 0x00018756
		public ePriceCurrencyType CurrentStoreRegion { get; set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x0001A55F File Offset: 0x0001875F
		// (set) Token: 0x06003126 RID: 12582 RVA: 0x0001A567 File Offset: 0x00018767
		public bool GameInProgress { get; set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x0001A570 File Offset: 0x00018770
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x0001A578 File Offset: 0x00018778
		public eGameType GameType { get; set; }

		// Token: 0x06003129 RID: 12585 RVA: 0x0010360C File Offset: 0x0010180C
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
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.CurrentStoreRegion);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GameInProgress);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00103710 File Offset: 0x00101910
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
			this.CurrentStoreRegion = ArrayManager.ReadePriceCurrencyType(data, ref num);
			this.GameInProgress = ArrayManager.ReadBoolean(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x001037F8 File Offset: 0x001019F8
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.AccountSUID = 0UL;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.GuildID = 0UL;
			this.ResponseSecurityToken = 0UL;
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			this.CurrentStoreRegion = ePriceCurrencyType.None;
			this.GameInProgress = false;
			this.GameType = eGameType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BCF RID: 7119
		public const uint cPacketType = 3827495177u;
	}
}
