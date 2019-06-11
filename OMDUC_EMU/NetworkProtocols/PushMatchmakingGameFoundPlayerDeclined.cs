using System;

namespace NetworkProtocols
{
	// Token: 0x020006DB RID: 1755
	public class PushMatchmakingGameFoundPlayerDeclined : BotNetMessage
	{
		// Token: 0x06003EB9 RID: 16057 RVA: 0x00023582 File Offset: 0x00021782
		public PushMatchmakingGameFoundPlayerDeclined()
		{
			this.InitRefTypes();
			base.PacketType = 2624349486u;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0002359B File Offset: 0x0002179B
		public PushMatchmakingGameFoundPlayerDeclined(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2624349486u;
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003EBB RID: 16059 RVA: 0x000235BB File Offset: 0x000217BB
		// (set) Token: 0x06003EBC RID: 16060 RVA: 0x000235C3 File Offset: 0x000217C3
		public ulong MatchmakingGameID { get; set; }

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06003EBD RID: 16061 RVA: 0x000235CC File Offset: 0x000217CC
		// (set) Token: 0x06003EBE RID: 16062 RVA: 0x000235D4 File Offset: 0x000217D4
		public ulong AccountSUID { get; set; }

		// Token: 0x06003EBF RID: 16063 RVA: 0x001172E4 File Offset: 0x001154E4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x00117370 File Offset: 0x00115570
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
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x000235DD File Offset: 0x000217DD
		private void InitRefTypes()
		{
			this.MatchmakingGameID = 0UL;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020FC RID: 8444
		public const uint cPacketType = 2624349486u;
	}
}
