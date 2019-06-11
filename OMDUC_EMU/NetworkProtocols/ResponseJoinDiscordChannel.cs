using System;

namespace NetworkProtocols
{
	// Token: 0x02000492 RID: 1170
	public class ResponseJoinDiscordChannel : BotNetMessage
	{
		// Token: 0x06002A56 RID: 10838 RVA: 0x00016218 File Offset: 0x00014418
		public ResponseJoinDiscordChannel()
		{
			this.InitRefTypes();
			base.PacketType = 608189841u;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00016231 File Offset: 0x00014431
		public ResponseJoinDiscordChannel(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 608189841u;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x00016251 File Offset: 0x00014451
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x00016259 File Offset: 0x00014459
		public ulong ChatID { get; set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x00016262 File Offset: 0x00014462
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x0001626A File Offset: 0x0001446A
		public eJoinDiscordChannelStatus Status { get; set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x00016273 File Offset: 0x00014473
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0001627B File Offset: 0x0001447B
		public string ChannelID { get; set; }

		// Token: 0x06002A5E RID: 10846 RVA: 0x000FB2C0 File Offset: 0x000F94C0
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
			ArrayManager.WriteeJoinDiscordChannelStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ChannelID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000FB35C File Offset: 0x000F955C
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
			this.Status = ArrayManager.ReadeJoinDiscordChannelStatus(data, ref num);
			this.ChannelID = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00016284 File Offset: 0x00014484
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.Status = eJoinDiscordChannelStatus.None;
			this.ChannelID = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016E4 RID: 5860
		public const uint cPacketType = 608189841u;
	}
}
