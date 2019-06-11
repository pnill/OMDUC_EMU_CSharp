using System;

namespace NetworkProtocols
{
	// Token: 0x0200065B RID: 1627
	public class RequestRegisterEUPlayer : BotNetMessage
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x0001F44A File Offset: 0x0001D64A
		public RequestRegisterEUPlayer()
		{
			this.InitRefTypes();
			base.PacketType = 884509234u;
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0001F463 File Offset: 0x0001D663
		public RequestRegisterEUPlayer(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 884509234u;
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x0001F483 File Offset: 0x0001D683
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x0001F48B File Offset: 0x0001D68B
		public string Email { get; set; }

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x0001F494 File Offset: 0x0001D694
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x0001F49C File Offset: 0x0001D69C
		public string Password { get; set; }

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x0001F4A5 File Offset: 0x0001D6A5
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x0001F4AD File Offset: 0x0001D6AD
		public string Name { get; set; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x0001F4B6 File Offset: 0x0001D6B6
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x0001F4BE File Offset: 0x0001D6BE
		public string Locale { get; set; }

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x0001F4C7 File Offset: 0x0001D6C7
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x0001F4CF File Offset: 0x0001D6CF
		public bool IsNewsletterSubscriber { get; set; }

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x0001F4D8 File Offset: 0x0001D6D8
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		public string TransferCode { get; set; }

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x0001F4E9 File Offset: 0x0001D6E9
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x0001F4F1 File Offset: 0x0001D6F1
		public ulong RemoteIpAddress { get; set; }

		// Token: 0x060038C7 RID: 14535 RVA: 0x0010E5D8 File Offset: 0x0010C7D8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Locale);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsNewsletterSubscriber);
			ArrayManager.WriteString(ref newArray, ref newSize, this.TransferCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RemoteIpAddress);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0010E6B0 File Offset: 0x0010C8B0
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
			this.Name = ArrayManager.ReadString(data, ref num);
			this.Locale = ArrayManager.ReadString(data, ref num);
			this.IsNewsletterSubscriber = ArrayManager.ReadBoolean(data, ref num);
			this.TransferCode = ArrayManager.ReadString(data, ref num);
			this.RemoteIpAddress = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x0010E76C File Offset: 0x0010C96C
		private void InitRefTypes()
		{
			this.Email = string.Empty;
			this.Password = string.Empty;
			this.Name = string.Empty;
			this.Locale = string.Empty;
			this.IsNewsletterSubscriber = false;
			this.TransferCode = string.Empty;
			this.RemoteIpAddress = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E39 RID: 7737
		public const uint cPacketType = 884509234u;
	}
}
