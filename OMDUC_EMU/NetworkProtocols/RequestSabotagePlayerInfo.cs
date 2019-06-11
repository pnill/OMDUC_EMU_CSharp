using System;

namespace NetworkProtocols
{
	// Token: 0x0200067A RID: 1658
	public class RequestSabotagePlayerInfo : BotNetMessage
	{
		// Token: 0x06003A16 RID: 14870 RVA: 0x00020257 File Offset: 0x0001E457
		public RequestSabotagePlayerInfo()
		{
			this.InitRefTypes();
			base.PacketType = 8988110u;
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00020270 File Offset: 0x0001E470
		public RequestSabotagePlayerInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 8988110u;
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x00020290 File Offset: 0x0001E490
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x00020298 File Offset: 0x0001E498
		public eLeaderboardSearchType SearchType { get; set; }

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x000202A1 File Offset: 0x0001E4A1
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x000202A9 File Offset: 0x0001E4A9
		public eLeaderboardFilter Filter { get; set; }

		// Token: 0x06003A1C RID: 14876 RVA: 0x001105C8 File Offset: 0x0010E7C8
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
			ArrayManager.WriteeLeaderboardSearchType(ref newArray, ref newSize, this.SearchType);
			ArrayManager.WriteeLeaderboardFilter(ref newArray, ref newSize, this.Filter);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00110654 File Offset: 0x0010E854
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SearchType = ArrayManager.ReadeLeaderboardSearchType(data, ref num);
			this.Filter = ArrayManager.ReadeLeaderboardFilter(data, ref num);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x000202B2 File Offset: 0x0001E4B2
		private void InitRefTypes()
		{
			this.SearchType = eLeaderboardSearchType.None;
			this.Filter = eLeaderboardFilter.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EE6 RID: 7910
		public const uint cPacketType = 8988110u;
	}
}
