using System;

namespace NetworkProtocols
{
	// Token: 0x020006C7 RID: 1735
	public class RequestSubscribeToLobbyList : BotNetMessage
	{
		// Token: 0x06003E3F RID: 15935 RVA: 0x00022F8C File Offset: 0x0002118C
		public RequestSubscribeToLobbyList()
		{
			this.InitRefTypes();
			base.PacketType = 1785681866u;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00022FA5 File Offset: 0x000211A5
		public RequestSubscribeToLobbyList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1785681866u;
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06003E42 RID: 15938 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06003E43 RID: 15939 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020AF RID: 8367
		public const uint cPacketType = 1785681866u;
	}
}
