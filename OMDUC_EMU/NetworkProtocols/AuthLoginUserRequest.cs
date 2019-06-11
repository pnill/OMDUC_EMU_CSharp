using System;

namespace NetworkProtocols
{
	// Token: 0x020004DB RID: 1243
	public class AuthLoginUserRequest : BotNetMessage
	{
		// Token: 0x06002B14 RID: 11028 RVA: 0x00016AA8 File Offset: 0x00014CA8
		public AuthLoginUserRequest()
		{
			this.InitRefTypes();
			base.PacketType = 4120177164u;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00016AC1 File Offset: 0x00014CC1
		public AuthLoginUserRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4120177164u;
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x00016AE1 File Offset: 0x00014CE1
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x00016AE9 File Offset: 0x00014CE9
		public ulong PartnerAccountID { get; set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x00016AF2 File Offset: 0x00014CF2
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x00016AFA File Offset: 0x00014CFA
		public string AuthToken { get; set; }

		// Token: 0x06002B1A RID: 11034 RVA: 0x000FC260 File Offset: 0x000FA460
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartnerAccountID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AuthToken);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000FC2EC File Offset: 0x000FA4EC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PartnerAccountID = ArrayManager.ReadUInt64(data, ref num);
			this.AuthToken = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00016B03 File Offset: 0x00014D03
		private void InitRefTypes()
		{
			this.PartnerAccountID = 0UL;
			this.AuthToken = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A1D RID: 6685
		public const uint cPacketType = 4120177164u;
	}
}
