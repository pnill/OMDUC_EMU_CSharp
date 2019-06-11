using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200060D RID: 1549
	public class RequestResendSteamConfirmationCode : BotNetMessage
	{
		// Token: 0x0600360D RID: 13837 RVA: 0x0001D6E2 File Offset: 0x0001B8E2
		public RequestResendSteamConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 2310662297u;
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0001D6FB File Offset: 0x0001B8FB
		public RequestResendSteamConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2310662297u;
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x0001D71B File Offset: 0x0001B91B
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x0001D723 File Offset: 0x0001B923
		public string Username { get; set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x0001D72C File Offset: 0x0001B92C
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x0001D734 File Offset: 0x0001B934
		public List<byte> Password { get; set; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x0001D73D File Offset: 0x0001B93D
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x0001D745 File Offset: 0x0001B945
		public string RemoteEndpoint { get; set; }

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x0001D74E File Offset: 0x0001B94E
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x0001D756 File Offset: 0x0001B956
		public string Nickname { get; set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x0001D75F File Offset: 0x0001B95F
		// (set) Token: 0x06003618 RID: 13848 RVA: 0x0001D767 File Offset: 0x0001B967
		public string AuthToken { get; set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x0001D770 File Offset: 0x0001B970
		// (set) Token: 0x0600361A RID: 13850 RVA: 0x0001D778 File Offset: 0x0001B978
		public ulong SteamID { get; set; }

		// Token: 0x0600361B RID: 13851 RVA: 0x0010A3DC File Offset: 0x001085DC
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
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Nickname);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AuthToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0010A4A4 File Offset: 0x001086A4
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
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
			this.Nickname = ArrayManager.ReadString(data, ref num);
			this.AuthToken = ArrayManager.ReadString(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0010A554 File Offset: 0x00108754
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.RemoteEndpoint = string.Empty;
			this.Nickname = string.Empty;
			this.AuthToken = string.Empty;
			this.SteamID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D67 RID: 7527
		public const uint cPacketType = 2310662297u;
	}
}
