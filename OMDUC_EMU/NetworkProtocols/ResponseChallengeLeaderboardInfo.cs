using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000683 RID: 1667
	public class ResponseChallengeLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A7B RID: 14971 RVA: 0x00020739 File Offset: 0x0001E939
		public ResponseChallengeLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 1315871696u;
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00020752 File Offset: 0x0001E952
		public ResponseChallengeLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1315871696u;
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x00020772 File Offset: 0x0001E972
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x0002077A File Offset: 0x0001E97A
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x00020783 File Offset: 0x0001E983
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x0002078B File Offset: 0x0001E98B
		public List<LeaderboardPlayerInfoForNetwork> PlayerList { get; set; }

		// Token: 0x06003A81 RID: 14977 RVA: 0x00110EFC File Offset: 0x0010F0FC
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
			ArrayManager.WriteListLeaderboardPlayerInfoForNetwork(ref newArray, ref newSize, this.PlayerList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00110F88 File Offset: 0x0010F188
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
			this.PlayerList = ArrayManager.ReadListLeaderboardPlayerInfoForNetwork(data, ref num);
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x00020794 File Offset: 0x0001E994
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.PlayerList = new List<LeaderboardPlayerInfoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F0A RID: 7946
		public const uint cPacketType = 1315871696u;
	}
}
