using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000752 RID: 1874
	public class ResponseGetGuildDetail : BotNetMessage
	{
		// Token: 0x06004286 RID: 17030 RVA: 0x00026278 File Offset: 0x00024478
		public ResponseGetGuildDetail()
		{
			this.InitRefTypes();
			base.PacketType = 3639577521u;
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x00026291 File Offset: 0x00024491
		public ResponseGetGuildDetail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3639577521u;
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x000262B1 File Offset: 0x000244B1
		// (set) Token: 0x06004289 RID: 17033 RVA: 0x000262B9 File Offset: 0x000244B9
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x000262C2 File Offset: 0x000244C2
		// (set) Token: 0x0600428B RID: 17035 RVA: 0x000262CA File Offset: 0x000244CA
		public GuildDetail GuildDetail { get; set; }

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x000262D3 File Offset: 0x000244D3
		// (set) Token: 0x0600428D RID: 17037 RVA: 0x000262DB File Offset: 0x000244DB
		public List<GuildMemberEntry> Roster { get; set; }

		// Token: 0x0600428E RID: 17038 RVA: 0x001208A0 File Offset: 0x0011EAA0
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
			ArrayManager.WriteGuildDetail(ref newArray, ref newSize, this.GuildDetail);
			ArrayManager.WriteListGuildMemberEntry(ref newArray, ref newSize, this.Roster);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x0012093C File Offset: 0x0011EB3C
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
			this.GuildDetail = ArrayManager.ReadGuildDetail(data, ref num);
			this.Roster = ArrayManager.ReadListGuildMemberEntry(data, ref num);
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x000262E4 File Offset: 0x000244E4
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.GuildDetail = new GuildDetail();
			this.Roster = new List<GuildMemberEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022C6 RID: 8902
		public const uint cPacketType = 3639577521u;
	}
}
