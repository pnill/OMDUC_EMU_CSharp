using System;

namespace NetworkProtocols
{
	// Token: 0x0200072B RID: 1835
	public class RequestCreateGuild : BotNetMessage
	{
		// Token: 0x0600410C RID: 16652 RVA: 0x000251EF File Offset: 0x000233EF
		public RequestCreateGuild()
		{
			this.InitRefTypes();
			base.PacketType = 2557329400u;
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00025208 File Offset: 0x00023408
		public RequestCreateGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2557329400u;
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x00025228 File Offset: 0x00023428
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x00025230 File Offset: 0x00023430
		public string GuildName { get; set; }

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x00025239 File Offset: 0x00023439
		// (set) Token: 0x06004111 RID: 16657 RVA: 0x00025241 File Offset: 0x00023441
		public string GuildTag { get; set; }

		// Token: 0x06004112 RID: 16658 RVA: 0x0011E2FC File Offset: 0x0011C4FC
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x0011E388 File Offset: 0x0011C588
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x0002524A File Offset: 0x0002344A
		private void InitRefTypes()
		{
			this.GuildName = string.Empty;
			this.GuildTag = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002246 RID: 8774
		public const uint cPacketType = 2557329400u;
	}
}
