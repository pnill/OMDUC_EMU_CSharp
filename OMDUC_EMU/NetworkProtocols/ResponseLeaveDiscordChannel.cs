using System;

namespace NetworkProtocols
{
	// Token: 0x02000494 RID: 1172
	public class ResponseLeaveDiscordChannel : BotNetMessage
	{
		// Token: 0x06002A68 RID: 10856 RVA: 0x00016302 File Offset: 0x00014502
		public ResponseLeaveDiscordChannel()
		{
			this.InitRefTypes();
			base.PacketType = 1709635275u;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0001631B File Offset: 0x0001451B
		public ResponseLeaveDiscordChannel(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1709635275u;
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x0001633B File Offset: 0x0001453B
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x00016343 File Offset: 0x00014543
		public ulong ChatID { get; set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x0001634C File Offset: 0x0001454C
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x00016354 File Offset: 0x00014554
		public eLeaveDiscordChannelStatus Status { get; set; }

		// Token: 0x06002A6E RID: 10862 RVA: 0x000FB4C8 File Offset: 0x000F96C8
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
			ArrayManager.WriteeLeaveDiscordChannelStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x000FB554 File Offset: 0x000F9754
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
			this.Status = ArrayManager.ReadeLeaveDiscordChannelStatus(data, ref num);
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x0001635D File Offset: 0x0001455D
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.Status = eLeaveDiscordChannelStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016EA RID: 5866
		public const uint cPacketType = 1709635275u;
	}
}
