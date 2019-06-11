using System;

namespace NetworkProtocols
{
	// Token: 0x020006D8 RID: 1752
	public class RequestMatchmakingGameFoundSetReady : BotNetMessage
	{
		// Token: 0x06003EA2 RID: 16034 RVA: 0x00023458 File Offset: 0x00021658
		public RequestMatchmakingGameFoundSetReady()
		{
			this.InitRefTypes();
			base.PacketType = 1564432359u;
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x00023471 File Offset: 0x00021671
		public RequestMatchmakingGameFoundSetReady(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1564432359u;
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x00023491 File Offset: 0x00021691
		// (set) Token: 0x06003EA5 RID: 16037 RVA: 0x00023499 File Offset: 0x00021699
		public ulong MatchmakingGameID { get; set; }

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00117010 File Offset: 0x00115210
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MatchmakingGameID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00117090 File Offset: 0x00115290
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MatchmakingGameID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x000234A2 File Offset: 0x000216A2
		private void InitRefTypes()
		{
			this.MatchmakingGameID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020F5 RID: 8437
		public const uint cPacketType = 1564432359u;
	}
}
