using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000742 RID: 1858
	public class ResponseAcceptGuildInvite : BotNetMessage
	{
		// Token: 0x060041D1 RID: 16849 RVA: 0x00025B17 File Offset: 0x00023D17
		public ResponseAcceptGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 1782803239u;
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00025B30 File Offset: 0x00023D30
		public ResponseAcceptGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1782803239u;
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00025B50 File Offset: 0x00023D50
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x00025B58 File Offset: 0x00023D58
		public GuildDetail GuildDetail { get; set; }

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x00025B61 File Offset: 0x00023D61
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x00025B69 File Offset: 0x00023D69
		public List<GuildMemberEntry> Roster { get; set; }

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x00025B72 File Offset: 0x00023D72
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x00025B7A File Offset: 0x00023D7A
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060041D9 RID: 16857 RVA: 0x0011F7EC File Offset: 0x0011D9EC
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

		// Token: 0x060041DA RID: 16858 RVA: 0x0011F888 File Offset: 0x0011DA88
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

		// Token: 0x060041DB RID: 16859 RVA: 0x00025B83 File Offset: 0x00023D83
		private void InitRefTypes()
		{
			this.GuildDetail = new GuildDetail();
			this.Roster = new List<GuildMemberEntry>();
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002285 RID: 8837
		public const uint cPacketType = 1782803239u;
	}
}
