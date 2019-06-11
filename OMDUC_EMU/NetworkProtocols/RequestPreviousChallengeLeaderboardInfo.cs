using System;

namespace NetworkProtocols
{
	// Token: 0x02000684 RID: 1668
	public class RequestPreviousChallengeLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A84 RID: 14980 RVA: 0x000207AF File Offset: 0x0001E9AF
		public RequestPreviousChallengeLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 2599956064u;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x000207C8 File Offset: 0x0001E9C8
		public RequestPreviousChallengeLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2599956064u;
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x000207E8 File Offset: 0x0001E9E8
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x000207F0 File Offset: 0x0001E9F0
		public ushort PlayerCount { get; set; }

		// Token: 0x06003A88 RID: 14984 RVA: 0x00111000 File Offset: 0x0010F200
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
			ArrayManager.WriteUInt16(ref newArray, ref newSize, this.PlayerCount);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x00111080 File Offset: 0x0010F280
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerCount = ArrayManager.ReadUInt16(data, ref num);
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x000207F9 File Offset: 0x0001E9F9
		private void InitRefTypes()
		{
			this.PlayerCount = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F0D RID: 7949
		public const uint cPacketType = 2599956064u;
	}
}
