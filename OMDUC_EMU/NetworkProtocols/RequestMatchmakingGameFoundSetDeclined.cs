using System;

namespace NetworkProtocols
{
	// Token: 0x020006D9 RID: 1753
	public class RequestMatchmakingGameFoundSetDeclined : BotNetMessage
	{
		// Token: 0x06003EA9 RID: 16041 RVA: 0x000234B3 File Offset: 0x000216B3
		public RequestMatchmakingGameFoundSetDeclined()
		{
			this.InitRefTypes();
			base.PacketType = 2535039156u;
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x000234CC File Offset: 0x000216CC
		public RequestMatchmakingGameFoundSetDeclined(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2535039156u;
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06003EAB RID: 16043 RVA: 0x000234EC File Offset: 0x000216EC
		// (set) Token: 0x06003EAC RID: 16044 RVA: 0x000234F4 File Offset: 0x000216F4
		public ulong MatchmakingGameID { get; set; }

		// Token: 0x06003EAD RID: 16045 RVA: 0x001170F8 File Offset: 0x001152F8
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

		// Token: 0x06003EAE RID: 16046 RVA: 0x00117178 File Offset: 0x00115378
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

		// Token: 0x06003EAF RID: 16047 RVA: 0x000234FD File Offset: 0x000216FD
		private void InitRefTypes()
		{
			this.MatchmakingGameID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020F7 RID: 8439
		public const uint cPacketType = 2535039156u;
	}
}
