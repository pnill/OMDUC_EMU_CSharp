using System;

namespace NetworkProtocols
{
	// Token: 0x02000622 RID: 1570
	public class RequestClaimMessageItems : BotNetMessage
	{
		// Token: 0x060036B7 RID: 14007 RVA: 0x0001DF1A File Offset: 0x0001C11A
		public RequestClaimMessageItems()
		{
			this.InitRefTypes();
			base.PacketType = 1289682847u;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0001DF33 File Offset: 0x0001C133
		public RequestClaimMessageItems(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1289682847u;
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x0001DF53 File Offset: 0x0001C153
		// (set) Token: 0x060036BA RID: 14010 RVA: 0x0001DF5B File Offset: 0x0001C15B
		public ulong PlayerMessageID { get; set; }

		// Token: 0x060036BB RID: 14011 RVA: 0x0010B65C File Offset: 0x0010985C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerMessageID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0010B6DC File Offset: 0x001098DC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerMessageID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x0001DF64 File Offset: 0x0001C164
		private void InitRefTypes()
		{
			this.PlayerMessageID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D9C RID: 7580
		public const uint cPacketType = 1289682847u;
	}
}
