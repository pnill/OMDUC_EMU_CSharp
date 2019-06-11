using System;

namespace NetworkProtocols
{
	// Token: 0x0200075F RID: 1887
	public class PushGuildTransactionLogEntryAdded : BotNetMessage
	{
		// Token: 0x060042FC RID: 17148 RVA: 0x000267C1 File Offset: 0x000249C1
		public PushGuildTransactionLogEntryAdded()
		{
			this.InitRefTypes();
			base.PacketType = 931374413u;
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x000267DA File Offset: 0x000249DA
		public PushGuildTransactionLogEntryAdded(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 931374413u;
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x000267FA File Offset: 0x000249FA
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x00026802 File Offset: 0x00024A02
		public GuildLogEntryForNetwork NewLogEntry { get; set; }

		// Token: 0x06004300 RID: 17152 RVA: 0x001214A4 File Offset: 0x0011F6A4
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
			ArrayManager.WriteGuildLogEntryForNetwork(ref newArray, ref newSize, this.NewLogEntry);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00121524 File Offset: 0x0011F724
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.NewLogEntry = ArrayManager.ReadGuildLogEntryForNetwork(data, ref num);
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x0002680B File Offset: 0x00024A0B
		private void InitRefTypes()
		{
			this.NewLogEntry = new GuildLogEntryForNetwork();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022EC RID: 8940
		public const uint cPacketType = 931374413u;
	}
}
