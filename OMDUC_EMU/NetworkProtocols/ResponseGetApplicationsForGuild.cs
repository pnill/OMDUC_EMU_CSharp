using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000739 RID: 1849
	public class ResponseGetApplicationsForGuild : BotNetMessage
	{
		// Token: 0x06004185 RID: 16773 RVA: 0x000257A5 File Offset: 0x000239A5
		public ResponseGetApplicationsForGuild()
		{
			this.InitRefTypes();
			base.PacketType = 1456395410u;
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x000257BE File Offset: 0x000239BE
		public ResponseGetApplicationsForGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1456395410u;
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x000257DE File Offset: 0x000239DE
		// (set) Token: 0x06004188 RID: 16776 RVA: 0x000257E6 File Offset: 0x000239E6
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x000257EF File Offset: 0x000239EF
		// (set) Token: 0x0600418A RID: 16778 RVA: 0x000257F7 File Offset: 0x000239F7
		public List<GuildApplication> IncomingApplications { get; set; }

		// Token: 0x0600418B RID: 16779 RVA: 0x0011F008 File Offset: 0x0011D208
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
			ArrayManager.WriteListGuildApplication(ref newArray, ref newSize, this.IncomingApplications);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x0011F094 File Offset: 0x0011D294
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
			this.IncomingApplications = ArrayManager.ReadListGuildApplication(data, ref num);
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00025800 File Offset: 0x00023A00
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.IncomingApplications = new List<GuildApplication>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400226D RID: 8813
		public const uint cPacketType = 1456395410u;
	}
}
