using System;

namespace NetworkProtocols
{
	// Token: 0x020004DC RID: 1244
	public class AuthLoginUserResponse : BotNetMessage
	{
		// Token: 0x06002B1D RID: 11037 RVA: 0x00016B1F File Offset: 0x00014D1F
		public AuthLoginUserResponse()
		{
			this.InitRefTypes();
			base.PacketType = 1471400544u;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00016B38 File Offset: 0x00014D38
		public AuthLoginUserResponse(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1471400544u;
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x00016B58 File Offset: 0x00014D58
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x00016B60 File Offset: 0x00014D60
		public string Username { get; set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x00016B69 File Offset: 0x00014D69
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x00016B71 File Offset: 0x00014D71
		public ulong AccountSUID { get; set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x00016B7A File Offset: 0x00014D7A
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x00016B82 File Offset: 0x00014D82
		public ulong ResponseSecurityToken { get; set; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x00016B8B File Offset: 0x00014D8B
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x00016B93 File Offset: 0x00014D93
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x00016B9C File Offset: 0x00014D9C
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x00016BA4 File Offset: 0x00014DA4
		public bool GameInProgress { get; set; }

		// Token: 0x06002B29 RID: 11049 RVA: 0x000FC364 File Offset: 0x000FA564
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ResponseSecurityToken);
			ArrayManager.WriteeAuthLoginUserStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.GameInProgress);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000FC420 File Offset: 0x000FA620
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
			this.ResponseSecurityToken = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeAuthLoginUserStatus(data, ref num);
			this.GameInProgress = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00016BAD File Offset: 0x00014DAD
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.AccountSUID = 0UL;
			this.ResponseSecurityToken = 0UL;
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			this.GameInProgress = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A20 RID: 6688
		public const uint cPacketType = 1471400544u;
	}
}
