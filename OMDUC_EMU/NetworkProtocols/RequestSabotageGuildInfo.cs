using System;

namespace NetworkProtocols
{
	// Token: 0x0200067D RID: 1661
	public class RequestSabotageGuildInfo : BotNetMessage
	{
		// Token: 0x06003A36 RID: 14902 RVA: 0x000203DC File Offset: 0x0001E5DC
		public RequestSabotageGuildInfo()
		{
			this.InitRefTypes();
			base.PacketType = 3684913767u;
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x000203F5 File Offset: 0x0001E5F5
		public RequestSabotageGuildInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3684913767u;
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x00020415 File Offset: 0x0001E615
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x0002041D File Offset: 0x0001E61D
		public eLeaderboardSearchType SearchType { get; set; }

		// Token: 0x06003A3A RID: 14906 RVA: 0x00110894 File Offset: 0x0010EA94
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00110914 File Offset: 0x0010EB14
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
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00020426 File Offset: 0x0001E626
		private void InitRefTypes()
		{
			this.SearchType = eLeaderboardSearchType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EF1 RID: 7921
		public const uint cPacketType = 3684913767u;
	}
}
