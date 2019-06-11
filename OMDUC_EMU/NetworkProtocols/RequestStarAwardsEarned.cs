using System;

namespace NetworkProtocols
{
	// Token: 0x0200061D RID: 1565
	public class RequestStarAwardsEarned : BotNetMessage
	{
		// Token: 0x06003697 RID: 13975 RVA: 0x0001DDAB File Offset: 0x0001BFAB
		public RequestStarAwardsEarned()
		{
			this.InitRefTypes();
			base.PacketType = 964010505u;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		public RequestStarAwardsEarned(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 964010505u;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x000FBC5C File Offset: 0x000F9E5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D94 RID: 7572
		public const uint cPacketType = 964010505u;
	}
}
