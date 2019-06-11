using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000681 RID: 1665
	public class ResponseLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A63 RID: 14947 RVA: 0x00020604 File Offset: 0x0001E804
		public ResponseLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 910358206u;
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x0002061D File Offset: 0x0001E81D
		public ResponseLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 910358206u;
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x0002063D File Offset: 0x0001E83D
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x00020645 File Offset: 0x0001E845
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003A67 RID: 14951 RVA: 0x0002064E File Offset: 0x0001E84E
		// (set) Token: 0x06003A68 RID: 14952 RVA: 0x00020656 File Offset: 0x0001E856
		public List<LeaderboardPlayerInfoForNetwork> PlayerList { get; set; }

		// Token: 0x06003A69 RID: 14953 RVA: 0x00110C9C File Offset: 0x0010EE9C
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

		// Token: 0x06003A6A RID: 14954 RVA: 0x00110D28 File Offset: 0x0010EF28
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

		// Token: 0x06003A6B RID: 14955 RVA: 0x0002065F File Offset: 0x0001E85F
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.PlayerList = new List<LeaderboardPlayerInfoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F01 RID: 7937
		public const uint cPacketType = 910358206u;
	}
}
