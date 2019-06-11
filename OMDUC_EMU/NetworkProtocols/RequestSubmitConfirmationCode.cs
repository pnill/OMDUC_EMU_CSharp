using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000607 RID: 1543
	public class RequestSubmitConfirmationCode : BotNetMessage
	{
		// Token: 0x060035C9 RID: 13769 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		public RequestSubmitConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 445162848u;
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x0001D3BD File Offset: 0x0001B5BD
		public RequestSubmitConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 445162848u;
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x0001D3DD File Offset: 0x0001B5DD
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x0001D3E5 File Offset: 0x0001B5E5
		public string ConfirmationCode { get; set; }

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x0001D3EE File Offset: 0x0001B5EE
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x0001D3F6 File Offset: 0x0001B5F6
		public string Username { get; set; }

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x0001D3FF File Offset: 0x0001B5FF
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x0001D407 File Offset: 0x0001B607
		public List<byte> Password { get; set; }

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x0001D410 File Offset: 0x0001B610
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x0001D418 File Offset: 0x0001B618
		public string Nickname { get; set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x0001D421 File Offset: 0x0001B621
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x0001D429 File Offset: 0x0001B629
		public string RemoteEndpoint { get; set; }

		// Token: 0x060035D5 RID: 13781 RVA: 0x00109C94 File Offset: 0x00107E94
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Nickname);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00109D50 File Offset: 0x00107F50
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
			this.Username = ArrayManager.ReadString(data, ref num);
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.Nickname = ArrayManager.ReadString(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0001D432 File Offset: 0x0001B632
		private void InitRefTypes()
		{
			this.ConfirmationCode = string.Empty;
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.Nickname = string.Empty;
			this.RemoteEndpoint = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D4E RID: 7502
		public const uint cPacketType = 445162848u;
	}
}
