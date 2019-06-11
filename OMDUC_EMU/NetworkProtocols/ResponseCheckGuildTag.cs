using System;

namespace NetworkProtocols
{
	// Token: 0x0200072F RID: 1839
	public class ResponseCheckGuildTag : BotNetMessage
	{
		// Token: 0x0600412A RID: 16682 RVA: 0x0002537F File Offset: 0x0002357F
		public ResponseCheckGuildTag()
		{
			this.InitRefTypes();
			base.PacketType = 3402400568u;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00025398 File Offset: 0x00023598
		public ResponseCheckGuildTag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3402400568u;
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x000253B8 File Offset: 0x000235B8
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x000253C0 File Offset: 0x000235C0
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x0600412E RID: 16686 RVA: 0x0011E6B8 File Offset: 0x0011C8B8
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

		// Token: 0x0600412F RID: 16687 RVA: 0x0011E738 File Offset: 0x0011C938
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

		// Token: 0x06004130 RID: 16688 RVA: 0x000253C9 File Offset: 0x000235C9
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400224F RID: 8783
		public const uint cPacketType = 3402400568u;
	}
}
