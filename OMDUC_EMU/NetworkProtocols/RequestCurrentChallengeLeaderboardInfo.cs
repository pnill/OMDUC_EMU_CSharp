using System;

namespace NetworkProtocols
{
	// Token: 0x02000686 RID: 1670
	public class RequestCurrentChallengeLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003A96 RID: 14998 RVA: 0x0002089B File Offset: 0x0001EA9B
		public RequestCurrentChallengeLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 3082283309u;
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x000208B4 File Offset: 0x0001EAB4
		public RequestCurrentChallengeLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3082283309u;
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x000208D4 File Offset: 0x0001EAD4
		// (set) Token: 0x06003A99 RID: 15001 RVA: 0x000208DC File Offset: 0x0001EADC
		public ushort PlayerCount { get; set; }

		// Token: 0x06003A9A RID: 15002 RVA: 0x00111208 File Offset: 0x0010F408
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

		// Token: 0x06003A9B RID: 15003 RVA: 0x00111288 File Offset: 0x0010F488
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

		// Token: 0x06003A9C RID: 15004 RVA: 0x000208E5 File Offset: 0x0001EAE5
		private void InitRefTypes()
		{
			this.PlayerCount = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F13 RID: 7955
		public const uint cPacketType = 3082283309u;
	}
}
