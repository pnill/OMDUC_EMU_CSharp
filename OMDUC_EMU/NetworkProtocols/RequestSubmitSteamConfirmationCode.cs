using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000609 RID: 1545
	public class RequestSubmitSteamConfirmationCode : BotNetMessage
	{
		// Token: 0x060035DF RID: 13791 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		public RequestSubmitSteamConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 3183014289u;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0001D4E5 File Offset: 0x0001B6E5
		public RequestSubmitSteamConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3183014289u;
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x0001D505 File Offset: 0x0001B705
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x0001D50D File Offset: 0x0001B70D
		public string ConfirmationCode { get; set; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x0001D516 File Offset: 0x0001B716
		// (set) Token: 0x060035E4 RID: 13796 RVA: 0x0001D51E File Offset: 0x0001B71E
		public string AuthToken { get; set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x0001D527 File Offset: 0x0001B727
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x0001D52F File Offset: 0x0001B72F
		public ulong SteamID { get; set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x0001D538 File Offset: 0x0001B738
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x0001D540 File Offset: 0x0001B740
		public string Username { get; set; }

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x0001D549 File Offset: 0x0001B749
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x0001D551 File Offset: 0x0001B751
		public List<byte> Password { get; set; }

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x0001D55A File Offset: 0x0001B75A
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x0001D562 File Offset: 0x0001B762
		public string Nickname { get; set; }

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x0001D56B File Offset: 0x0001B76B
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x0001D573 File Offset: 0x0001B773
		public string RemoteEndpoint { get; set; }

		// Token: 0x060035EF RID: 13807 RVA: 0x00109ED8 File Offset: 0x001080D8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.ConfirmationCode);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AuthToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Nickname);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00109FB0 File Offset: 0x001081B0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ConfirmationCode = ArrayManager.ReadString(data, ref num);
			this.AuthToken = ArrayManager.ReadString(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.Nickname = ArrayManager.ReadString(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0010A06C File Offset: 0x0010826C
		private void InitRefTypes()
		{
			this.ConfirmationCode = string.Empty;
			this.AuthToken = string.Empty;
			this.SteamID = 0UL;
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.Nickname = string.Empty;
			this.RemoteEndpoint = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D56 RID: 7510
		public const uint cPacketType = 3183014289u;
	}
}
