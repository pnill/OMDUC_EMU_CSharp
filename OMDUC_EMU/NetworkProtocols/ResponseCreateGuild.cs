using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000730 RID: 1840
	public class ResponseCreateGuild : BotNetMessage
	{
		// Token: 0x06004131 RID: 16689 RVA: 0x000253D9 File Offset: 0x000235D9
		public ResponseCreateGuild()
		{
			this.InitRefTypes();
			base.PacketType = 2024685958u;
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x000253F2 File Offset: 0x000235F2
		public ResponseCreateGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2024685958u;
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x00025412 File Offset: 0x00023612
		// (set) Token: 0x06004134 RID: 16692 RVA: 0x0002541A File Offset: 0x0002361A
		public GuildDetail GuildDetail { get; set; }

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x00025423 File Offset: 0x00023623
		// (set) Token: 0x06004136 RID: 16694 RVA: 0x0002542B File Offset: 0x0002362B
		public List<GuildMemberEntry> Roster { get; set; }

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x00025434 File Offset: 0x00023634
		// (set) Token: 0x06004138 RID: 16696 RVA: 0x0002543C File Offset: 0x0002363C
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004139 RID: 16697 RVA: 0x0011E7A0 File Offset: 0x0011C9A0
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
			ArrayManager.WriteGuildDetail(ref newArray, ref newSize, this.GuildDetail);
			ArrayManager.WriteListGuildMemberEntry(ref newArray, ref newSize, this.Roster);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x0011E83C File Offset: 0x0011CA3C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildDetail = ArrayManager.ReadGuildDetail(data, ref num);
			this.Roster = ArrayManager.ReadListGuildMemberEntry(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x00025445 File Offset: 0x00023645
		private void InitRefTypes()
		{
			this.GuildDetail = new GuildDetail();
			this.Roster = new List<GuildMemberEntry>();
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002251 RID: 8785
		public const uint cPacketType = 2024685958u;
	}
}
