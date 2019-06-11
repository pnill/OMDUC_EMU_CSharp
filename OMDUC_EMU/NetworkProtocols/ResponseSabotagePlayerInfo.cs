using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200067C RID: 1660
	public class ResponseSabotagePlayerInfo : BotNetMessage
	{
		// Token: 0x06003A2D RID: 14893 RVA: 0x00020366 File Offset: 0x0001E566
		public ResponseSabotagePlayerInfo()
		{
			this.InitRefTypes();
			base.PacketType = 3951830498u;
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x0002037F File Offset: 0x0001E57F
		public ResponseSabotagePlayerInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3951830498u;
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x0002039F File Offset: 0x0001E59F
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x000203A7 File Offset: 0x0001E5A7
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x000203B0 File Offset: 0x0001E5B0
		// (set) Token: 0x06003A32 RID: 14898 RVA: 0x000203B8 File Offset: 0x0001E5B8
		public List<SabotagePlayerInfoForNetwork> PlayerList { get; set; }

		// Token: 0x06003A33 RID: 14899 RVA: 0x00110790 File Offset: 0x0010E990
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
			ArrayManager.WriteListSabotagePlayerInfoForNetwork(ref newArray, ref newSize, this.PlayerList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A34 RID: 14900 RVA: 0x0011081C File Offset: 0x0010EA1C
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
			this.PlayerList = ArrayManager.ReadListSabotagePlayerInfoForNetwork(data, ref num);
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x000203C1 File Offset: 0x0001E5C1
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.PlayerList = new List<SabotagePlayerInfoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EEE RID: 7918
		public const uint cPacketType = 3951830498u;
	}
}
