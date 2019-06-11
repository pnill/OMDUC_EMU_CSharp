using System;

namespace NetworkProtocols
{
	// Token: 0x02000623 RID: 1571
	public class ResponseClaimMessageItems : BotNetMessage
	{
		// Token: 0x060036BE RID: 14014 RVA: 0x0001DF75 File Offset: 0x0001C175
		public ResponseClaimMessageItems()
		{
			this.InitRefTypes();
			base.PacketType = 1206447194u;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0001DF8E File Offset: 0x0001C18E
		public ResponseClaimMessageItems(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1206447194u;
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x0001DFAE File Offset: 0x0001C1AE
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x0001DFB6 File Offset: 0x0001C1B6
		public ulong PlayerMessageID { get; set; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x0001DFBF File Offset: 0x0001C1BF
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x0001DFC7 File Offset: 0x0001C1C7
		public eClaimMessageItemsStatus Status { get; set; }

		// Token: 0x060036C4 RID: 14020 RVA: 0x0010B744 File Offset: 0x00109944
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
			ArrayManager.WriteeClaimMessageItemsStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0010B7D0 File Offset: 0x001099D0
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
			this.Status = ArrayManager.ReadeClaimMessageItemsStatus(data, ref num);
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		private void InitRefTypes()
		{
			this.PlayerMessageID = 0UL;
			this.Status = eClaimMessageItemsStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D9E RID: 7582
		public const uint cPacketType = 1206447194u;
	}
}
