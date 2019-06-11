using System;

namespace NetworkProtocols
{
	// Token: 0x02000485 RID: 1157
	public class RequestSendChat : BotNetMessage
	{
		// Token: 0x060029D9 RID: 10713 RVA: 0x00015C03 File Offset: 0x00013E03
		public RequestSendChat()
		{
			this.InitRefTypes();
			base.PacketType = 185325717u;
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00015C1C File Offset: 0x00013E1C
		public RequestSendChat(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 185325717u;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x00015C3C File Offset: 0x00013E3C
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x00015C44 File Offset: 0x00013E44
		public ulong ChatID { get; set; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x00015C4D File Offset: 0x00013E4D
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x00015C55 File Offset: 0x00013E55
		public string ChatString { get; set; }

		// Token: 0x060029DF RID: 10719 RVA: 0x000FA4B8 File Offset: 0x000F86B8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ChatString);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000FA544 File Offset: 0x000F8744
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
			this.ChatString = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00015C5E File Offset: 0x00013E5E
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.ChatString = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016B9 RID: 5817
		public const uint cPacketType = 185325717u;
	}
}
