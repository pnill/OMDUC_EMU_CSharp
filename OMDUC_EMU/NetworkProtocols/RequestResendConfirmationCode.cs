using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200060B RID: 1547
	public class RequestResendConfirmationCode : BotNetMessage
	{
		// Token: 0x060035F9 RID: 13817 RVA: 0x0001D5D6 File Offset: 0x0001B7D6
		public RequestResendConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 1010552243u;
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x0001D5EF File Offset: 0x0001B7EF
		public RequestResendConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1010552243u;
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x0001D60F File Offset: 0x0001B80F
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x0001D617 File Offset: 0x0001B817
		public string Username { get; set; }

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x0001D620 File Offset: 0x0001B820
		// (set) Token: 0x060035FE RID: 13822 RVA: 0x0001D628 File Offset: 0x0001B828
		public List<byte> Password { get; set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x0001D631 File Offset: 0x0001B831
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x0001D639 File Offset: 0x0001B839
		public string RemoteEndpoint { get; set; }

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x0001D642 File Offset: 0x0001B842
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x0001D64A File Offset: 0x0001B84A
		public string Nickname { get; set; }

		// Token: 0x06003603 RID: 13827 RVA: 0x0010A1B4 File Offset: 0x001083B4
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0010A260 File Offset: 0x00108460
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
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x0001D653 File Offset: 0x0001B853
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.RemoteEndpoint = string.Empty;
			this.Nickname = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D60 RID: 7520
		public const uint cPacketType = 1010552243u;
	}
}
