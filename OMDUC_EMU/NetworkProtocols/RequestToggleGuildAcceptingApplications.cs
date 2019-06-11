using System;

namespace NetworkProtocols
{
	// Token: 0x02000788 RID: 1928
	public class RequestToggleGuildAcceptingApplications : BotNetMessage
	{
		// Token: 0x0600442E RID: 17454 RVA: 0x000274FF File Offset: 0x000256FF
		public RequestToggleGuildAcceptingApplications()
		{
			this.InitRefTypes();
			base.PacketType = 1971254749u;
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00027518 File Offset: 0x00025718
		public RequestToggleGuildAcceptingApplications(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1971254749u;
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x00027538 File Offset: 0x00025738
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x00027540 File Offset: 0x00025740
		public ulong GuildID { get; set; }

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x00027549 File Offset: 0x00025749
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x00027551 File Offset: 0x00025751
		public bool IsAcceptingApplications { get; set; }

		// Token: 0x06004434 RID: 17460 RVA: 0x0012303C File Offset: 0x0012123C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsAcceptingApplications);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x001230C8 File Offset: 0x001212C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.IsAcceptingApplications = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x0002755A File Offset: 0x0002575A
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
			this.IsAcceptingApplications = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002341 RID: 9025
		public const uint cPacketType = 1971254749u;
	}
}
