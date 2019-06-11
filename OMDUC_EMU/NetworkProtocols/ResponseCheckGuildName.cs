using System;

namespace NetworkProtocols
{
	// Token: 0x0200072D RID: 1837
	public class ResponseCheckGuildName : BotNetMessage
	{
		// Token: 0x0600411C RID: 16668 RVA: 0x000252C7 File Offset: 0x000234C7
		public ResponseCheckGuildName()
		{
			this.InitRefTypes();
			base.PacketType = 39407926u;
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x000252E0 File Offset: 0x000234E0
		public ResponseCheckGuildName(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 39407926u;
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x00025300 File Offset: 0x00023500
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x00025308 File Offset: 0x00023508
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004120 RID: 16672 RVA: 0x0011E4E8 File Offset: 0x0011C6E8
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x0011E568 File Offset: 0x0011C768
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00025311 File Offset: 0x00023511
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400224B RID: 8779
		public const uint cPacketType = 39407926u;
	}
}
