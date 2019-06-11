using System;

namespace NetworkProtocols
{
	// Token: 0x020006DA RID: 1754
	public class PushMatchmakingGameFoundPlayerReady : BotNetMessage
	{
		// Token: 0x06003EB0 RID: 16048 RVA: 0x0002350E File Offset: 0x0002170E
		public PushMatchmakingGameFoundPlayerReady()
		{
			this.InitRefTypes();
			base.PacketType = 3976803159u;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00023527 File Offset: 0x00021727
		public PushMatchmakingGameFoundPlayerReady(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3976803159u;
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x00023547 File Offset: 0x00021747
		// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x0002354F File Offset: 0x0002174F
		public ulong MatchmakingGameID { get; set; }

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x00023558 File Offset: 0x00021758
		// (set) Token: 0x06003EB5 RID: 16053 RVA: 0x00023560 File Offset: 0x00021760
		public ulong AccountSUID { get; set; }

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001171E0 File Offset: 0x001153E0
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

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0011726C File Offset: 0x0011546C
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

		// Token: 0x06003EB8 RID: 16056 RVA: 0x00023569 File Offset: 0x00021769
		private void InitRefTypes()
		{
			this.MatchmakingGameID = 0UL;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020F9 RID: 8441
		public const uint cPacketType = 3976803159u;
	}
}
