using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200076C RID: 1900
	public class PushGuildApplicationAccepted : BotNetMessage
	{
		// Token: 0x06004359 RID: 17241 RVA: 0x00026C7F File Offset: 0x00024E7F
		public PushGuildApplicationAccepted()
		{
			this.InitRefTypes();
			base.PacketType = 846706495u;
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00026C98 File Offset: 0x00024E98
		public PushGuildApplicationAccepted(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 846706495u;
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x00026CB8 File Offset: 0x00024EB8
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x00026CC0 File Offset: 0x00024EC0
		public GuildDetail GuildDetail { get; set; }

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x00026CC9 File Offset: 0x00024EC9
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x00026CD1 File Offset: 0x00024ED1
		public List<GuildMemberEntry> Roster { get; set; }

		// Token: 0x0600435F RID: 17247 RVA: 0x00121FBC File Offset: 0x001201BC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00122048 File Offset: 0x00120248
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
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00026CDA File Offset: 0x00024EDA
		private void InitRefTypes()
		{
			this.GuildDetail = new GuildDetail();
			this.Roster = new List<GuildMemberEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002307 RID: 8967
		public const uint cPacketType = 846706495u;
	}
}
