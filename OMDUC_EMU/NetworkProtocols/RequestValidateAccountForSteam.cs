using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000605 RID: 1541
	public class RequestValidateAccountForSteam : BotNetMessage
	{
		// Token: 0x060035B1 RID: 13745 RVA: 0x0001D2AB File Offset: 0x0001B4AB
		public RequestValidateAccountForSteam()
		{
			this.InitRefTypes();
			base.PacketType = 2357170998u;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
		public RequestValidateAccountForSteam(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2357170998u;
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		public string AuthToken { get; set; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x0001D2F5 File Offset: 0x0001B4F5
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x0001D2FD File Offset: 0x0001B4FD
		public ulong SteamID { get; set; }

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x0001D306 File Offset: 0x0001B506
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x0001D30E File Offset: 0x0001B50E
		public string Username { get; set; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x0001D317 File Offset: 0x0001B517
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x0001D31F File Offset: 0x0001B51F
		public List<byte> Password { get; set; }

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x0001D328 File Offset: 0x0001B528
		// (set) Token: 0x060035BC RID: 13756 RVA: 0x0001D330 File Offset: 0x0001B530
		public string Nickname { get; set; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x0001D339 File Offset: 0x0001B539
		// (set) Token: 0x060035BE RID: 13758 RVA: 0x0001D341 File Offset: 0x0001B541
		public string RemoteEndpoint { get; set; }

		// Token: 0x060035BF RID: 13759 RVA: 0x001099E0 File Offset: 0x00107BE0
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.AuthToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Nickname);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00109AA8 File Offset: 0x00107CA8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AuthToken = ArrayManager.ReadString(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.Nickname = ArrayManager.ReadString(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00109B58 File Offset: 0x00107D58
		private void InitRefTypes()
		{
			this.AuthToken = string.Empty;
			this.SteamID = 0UL;
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.Nickname = string.Empty;
			this.RemoteEndpoint = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D45 RID: 7493
		public const uint cPacketType = 2357170998u;
	}
}
