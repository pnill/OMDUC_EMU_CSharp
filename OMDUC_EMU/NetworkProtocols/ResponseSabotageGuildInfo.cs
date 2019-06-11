using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200067F RID: 1663
	public class ResponseSabotageGuildInfo : BotNetMessage
	{
		// Token: 0x06003A49 RID: 14921 RVA: 0x000204B7 File Offset: 0x0001E6B7
		public ResponseSabotageGuildInfo()
		{
			this.InitRefTypes();
			base.PacketType = 3499442594u;
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x000204D0 File Offset: 0x0001E6D0
		public ResponseSabotageGuildInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3499442594u;
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x000204F0 File Offset: 0x0001E6F0
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x000204F8 File Offset: 0x0001E6F8
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x00020501 File Offset: 0x0001E701
		// (set) Token: 0x06003A4E RID: 14926 RVA: 0x00020509 File Offset: 0x0001E709
		public List<SabotageGuildInfoForNetwork> GuildList { get; set; }

		// Token: 0x06003A4F RID: 14927 RVA: 0x00110A20 File Offset: 0x0010EC20
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
			ArrayManager.WriteeLeaderboardOperationResult(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListSabotageGuildInfoForNetwork(ref newArray, ref newSize, this.GuildList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00110AAC File Offset: 0x0010ECAC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeLeaderboardOperationResult(data, ref num);
			this.GuildList = ArrayManager.ReadListSabotageGuildInfoForNetwork(data, ref num);
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00020512 File Offset: 0x0001E712
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.GuildList = new List<SabotageGuildInfoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EF7 RID: 7927
		public const uint cPacketType = 3499442594u;
	}
}
