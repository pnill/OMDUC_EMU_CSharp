using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200058B RID: 1419
	public class UserRegisterRequest : BotNetMessage
	{
		// Token: 0x060030E4 RID: 12516 RVA: 0x0001A28B File Offset: 0x0001848B
		public UserRegisterRequest()
		{
			this.InitRefTypes();
			base.PacketType = 2803163958u;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0001A2A4 File Offset: 0x000184A4
		public UserRegisterRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2803163958u;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x0001A2C4 File Offset: 0x000184C4
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x0001A2CC File Offset: 0x000184CC
		public string EmailAddress { get; set; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x0001A2D5 File Offset: 0x000184D5
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x0001A2DD File Offset: 0x000184DD
		public string Username { get; set; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x0001A2E6 File Offset: 0x000184E6
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x0001A2EE File Offset: 0x000184EE
		public List<byte> Password { get; set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x0001A2F7 File Offset: 0x000184F7
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x0001A2FF File Offset: 0x000184FF
		public bool IsNewsletterSubscriber { get; set; }

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x0001A308 File Offset: 0x00018508
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x0001A310 File Offset: 0x00018510
		public string Locale { get; set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x0001A319 File Offset: 0x00018519
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x0001A321 File Offset: 0x00018521
		public string AuthToken { get; set; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x0001A32A File Offset: 0x0001852A
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x0001A332 File Offset: 0x00018532
		public ulong SteamID { get; set; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x0001A33B File Offset: 0x0001853B
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x0001A343 File Offset: 0x00018543
		public string ReferralCode { get; set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x0001A34C File Offset: 0x0001854C
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x0001A354 File Offset: 0x00018554
		public string RemoteEndpoint { get; set; }

		// Token: 0x060030F8 RID: 12536 RVA: 0x0010316C File Offset: 0x0010136C
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.EmailAddress);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsNewsletterSubscriber);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Locale);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AuthToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ReferralCode);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00103264 File Offset: 0x00101464
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EmailAddress = ArrayManager.ReadString(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.IsNewsletterSubscriber = ArrayManager.ReadBoolean(data, ref num);
			this.Locale = ArrayManager.ReadString(data, ref num);
			this.AuthToken = ArrayManager.ReadString(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
			this.ReferralCode = ArrayManager.ReadString(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0010333C File Offset: 0x0010153C
		private void InitRefTypes()
		{
			this.EmailAddress = string.Empty;
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.IsNewsletterSubscriber = false;
			this.Locale = string.Empty;
			this.AuthToken = string.Empty;
			this.SteamID = 0UL;
			this.ReferralCode = string.Empty;
			this.RemoteEndpoint = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BBC RID: 7100
		public const uint cPacketType = 2803163958u;
	}
}
