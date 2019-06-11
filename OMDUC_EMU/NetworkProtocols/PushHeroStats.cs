using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000575 RID: 1397
	public class PushHeroStats : BotNetMessage
	{
		// Token: 0x06002FE2 RID: 12258 RVA: 0x000197A5 File Offset: 0x000179A5
		public PushHeroStats()
		{
			this.InitRefTypes();
			base.PacketType = 811023263u;
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x000197BE File Offset: 0x000179BE
		public PushHeroStats(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 811023263u;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000197DE File Offset: 0x000179DE
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x000197E6 File Offset: 0x000179E6
		public List<PlayerHeroStats> HeroStats { get; set; }

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00101998 File Offset: 0x000FFB98
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
			ArrayManager.WriteListPlayerHeroStats(ref newArray, ref newSize, this.HeroStats);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00101A18 File Offset: 0x000FFC18
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.HeroStats = ArrayManager.ReadListPlayerHeroStats(data, ref num);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000197EF File Offset: 0x000179EF
		private void InitRefTypes()
		{
			this.HeroStats = new List<PlayerHeroStats>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B5F RID: 7007
		public const uint cPacketType = 811023263u;
	}
}
