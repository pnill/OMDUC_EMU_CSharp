using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200073C RID: 1852
	public class ResponseGetGuildInvitesForGuild : BotNetMessage
	{
		// Token: 0x060041A5 RID: 16805 RVA: 0x000258D9 File Offset: 0x00023AD9
		public ResponseGetGuildInvitesForGuild()
		{
			this.InitRefTypes();
			base.PacketType = 2679650332u;
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x000258F2 File Offset: 0x00023AF2
		public ResponseGetGuildInvitesForGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2679650332u;
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x00025912 File Offset: 0x00023B12
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x0002591A File Offset: 0x00023B1A
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x00025923 File Offset: 0x00023B23
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x0002592B File Offset: 0x00023B2B
		public List<GuildInvite> GuildInvites { get; set; }

		// Token: 0x060041AB RID: 16811 RVA: 0x0011F260 File Offset: 0x0011D460
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
			ArrayManager.WriteListGuildInvite(ref newArray, ref newSize, this.GuildInvites);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x0011F2EC File Offset: 0x0011D4EC
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
			this.GuildInvites = ArrayManager.ReadListGuildInvite(data, ref num);
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x00025934 File Offset: 0x00023B34
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.GuildInvites = new List<GuildInvite>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002278 RID: 8824
		public const uint cPacketType = 2679650332u;
	}
}
