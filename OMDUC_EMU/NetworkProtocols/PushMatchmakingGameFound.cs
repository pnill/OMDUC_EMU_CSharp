using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006D7 RID: 1751
	public class PushMatchmakingGameFound : BotNetMessage
	{
		// Token: 0x06003E99 RID: 16025 RVA: 0x000233E1 File Offset: 0x000215E1
		public PushMatchmakingGameFound()
		{
			this.InitRefTypes();
			base.PacketType = 3851876137u;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x000233FA File Offset: 0x000215FA
		public PushMatchmakingGameFound(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3851876137u;
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x0002341A File Offset: 0x0002161A
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x00023422 File Offset: 0x00021622
		public ulong MatchmakingGameID { get; set; }

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x0002342B File Offset: 0x0002162B
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x00023433 File Offset: 0x00021633
		public List<MatchmakingGamePlayer> Players { get; set; }

		// Token: 0x06003E9F RID: 16031 RVA: 0x00116F0C File Offset: 0x0011510C
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
			ArrayManager.WriteListMatchmakingGamePlayer(ref newArray, ref newSize, this.Players);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00116F98 File Offset: 0x00115198
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
			this.Players = ArrayManager.ReadListMatchmakingGamePlayer(data, ref num);
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0002343C File Offset: 0x0002163C
		private void InitRefTypes()
		{
			this.MatchmakingGameID = 0UL;
			this.Players = new List<MatchmakingGamePlayer>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020F2 RID: 8434
		public const uint cPacketType = 3851876137u;
	}
}
