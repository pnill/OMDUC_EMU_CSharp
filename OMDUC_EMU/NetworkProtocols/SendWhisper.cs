using System;

namespace NetworkProtocols
{
	// Token: 0x0200048B RID: 1163
	public class SendWhisper : BotNetMessage
	{
		// Token: 0x06002A1D RID: 10781 RVA: 0x00015F30 File Offset: 0x00014130
		public SendWhisper()
		{
			this.InitRefTypes();
			base.PacketType = 1612224104u;
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00015F49 File Offset: 0x00014149
		public SendWhisper(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1612224104u;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x00015F69 File Offset: 0x00014169
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x00015F71 File Offset: 0x00014171
		public ulong AccountSUID { get; set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x00015F7A File Offset: 0x0001417A
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x00015F82 File Offset: 0x00014182
		public string Message { get; set; }

		// Token: 0x06002A23 RID: 10787 RVA: 0x000FABF8 File Offset: 0x000F8DF8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Message);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000FAC84 File Offset: 0x000F8E84
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Message = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00015F8B File Offset: 0x0001418B
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Message = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016D2 RID: 5842
		public const uint cPacketType = 1612224104u;
	}
}
