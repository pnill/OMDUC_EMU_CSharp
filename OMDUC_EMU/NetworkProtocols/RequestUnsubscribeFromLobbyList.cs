using System;

namespace NetworkProtocols
{
	// Token: 0x020006C9 RID: 1737
	public class RequestUnsubscribeFromLobbyList : BotNetMessage
	{
		// Token: 0x06003E4B RID: 15947 RVA: 0x0002301F File Offset: 0x0002121F
		public RequestUnsubscribeFromLobbyList()
		{
			this.InitRefTypes();
			base.PacketType = 3408313696u;
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00023038 File Offset: 0x00021238
		public RequestUnsubscribeFromLobbyList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3408313696u;
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06003E4E RID: 15950 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06003E4F RID: 15951 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020B2 RID: 8370
		public const uint cPacketType = 3408313696u;
	}
}
