using System;

namespace NetworkProtocols
{
	// Token: 0x02000593 RID: 1427
	public class PS4LoginUserResponse : BotNetMessage
	{
		// Token: 0x06003148 RID: 12616 RVA: 0x0001A6E0 File Offset: 0x000188E0
		public PS4LoginUserResponse()
		{
			this.InitRefTypes();
			base.PacketType = 2806149680u;
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x0001A6F9 File Offset: 0x000188F9
		public PS4LoginUserResponse(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2806149680u;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x0001A719 File Offset: 0x00018919
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x0001A721 File Offset: 0x00018921
		public ulong AccountSUID { get; set; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x0001A72A File Offset: 0x0001892A
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x0001A732 File Offset: 0x00018932
		public string GuildTag { get; set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x0001A73B File Offset: 0x0001893B
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x0001A743 File Offset: 0x00018943
		public string GuildName { get; set; }

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x0001A74C File Offset: 0x0001894C
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x0001A754 File Offset: 0x00018954
		public ulong GuildID { get; set; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x0001A75D File Offset: 0x0001895D
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x0001A765 File Offset: 0x00018965
		public ulong ResponseSecurityToken { get; set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x0001A76E File Offset: 0x0001896E
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x0001A776 File Offset: 0x00018976
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x0001A77F File Offset: 0x0001897F
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x0001A787 File Offset: 0x00018987
		public bool GameInProgress { get; set; }

		// Token: 0x06003158 RID: 12632 RVA: 0x00103A6C File Offset: 0x00101C6C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ResponseSecurityToken);
			ArrayManager.WriteeAuthLoginUserStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GameInProgress);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00103B44 File Offset: 0x00101D44
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.ResponseSecurityToken = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeAuthLoginUserStatus(data, ref num);
			this.GameInProgress = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00103C00 File Offset: 0x00101E00
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.GuildID = 0UL;
			this.ResponseSecurityToken = 0UL;
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			this.GameInProgress = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BE2 RID: 7138
		public const uint cPacketType = 2806149680u;
	}
}
