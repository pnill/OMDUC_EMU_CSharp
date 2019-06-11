using System;

namespace NetworkProtocols
{
	// Token: 0x0200065D RID: 1629
	public class RequestMergeEUPlayer : BotNetMessage
	{
		// Token: 0x060038D5 RID: 14549 RVA: 0x0001F589 File Offset: 0x0001D789
		public RequestMergeEUPlayer()
		{
			this.InitRefTypes();
			base.PacketType = 2748261260u;
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0001F5A2 File Offset: 0x0001D7A2
		public RequestMergeEUPlayer(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2748261260u;
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x0001F5C2 File Offset: 0x0001D7C2
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x0001F5CA File Offset: 0x0001D7CA
		public string Email { get; set; }

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x0001F5D3 File Offset: 0x0001D7D3
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x0001F5DB File Offset: 0x0001D7DB
		public string Password { get; set; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x0001F5EC File Offset: 0x0001D7EC
		public string TransferCode { get; set; }

		// Token: 0x060038DD RID: 14557 RVA: 0x0010E8E8 File Offset: 0x0010CAE8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Email);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.TransferCode);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0010E984 File Offset: 0x0010CB84
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Email = ArrayManager.ReadString(data, ref num);
			this.Password = ArrayManager.ReadString(data, ref num);
			this.TransferCode = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0001F5F5 File Offset: 0x0001D7F5
		private void InitRefTypes()
		{
			this.Email = string.Empty;
			this.Password = string.Empty;
			this.TransferCode = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E45 RID: 7749
		public const uint cPacketType = 2748261260u;
	}
}
