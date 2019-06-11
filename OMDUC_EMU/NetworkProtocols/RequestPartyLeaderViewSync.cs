using System;

namespace NetworkProtocols
{
	// Token: 0x020006FD RID: 1789
	public class RequestPartyLeaderViewSync : BotNetMessage
	{
		// Token: 0x06003FE3 RID: 16355 RVA: 0x00024399 File Offset: 0x00022599
		public RequestPartyLeaderViewSync()
		{
			this.InitRefTypes();
			base.PacketType = 2376855915u;
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x000243B2 File Offset: 0x000225B2
		public RequestPartyLeaderViewSync(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2376855915u;
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x000243D2 File Offset: 0x000225D2
		// (set) Token: 0x06003FE6 RID: 16358 RVA: 0x000243DA File Offset: 0x000225DA
		public ulong MapGUID { get; set; }

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x000243E3 File Offset: 0x000225E3
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x000243EB File Offset: 0x000225EB
		public eGameType GameType { get; set; }

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x000243F4 File Offset: 0x000225F4
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x000243FC File Offset: 0x000225FC
		public ePartyLeaderSyncType SyncType { get; set; }

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x00024405 File Offset: 0x00022605
		// (set) Token: 0x06003FEC RID: 16364 RVA: 0x0002440D File Offset: 0x0002260D
		public eSceneID LeaderSceneID { get; set; }

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x00024416 File Offset: 0x00022616
		// (set) Token: 0x06003FEE RID: 16366 RVA: 0x0002441E File Offset: 0x0002261E
		public ulong KeystoneID { get; set; }

		// Token: 0x06003FEF RID: 16367 RVA: 0x0011C568 File Offset: 0x0011A768
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapGUID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteePartyLeaderSyncType(ref newArray, ref newSize, this.SyncType);
			ArrayManager.WriteeSceneID(ref newArray, ref newSize, this.LeaderSceneID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x0011C624 File Offset: 0x0011A824
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.SyncType = ArrayManager.ReadePartyLeaderSyncType(data, ref num);
			this.LeaderSceneID = ArrayManager.ReadeSceneID(data, ref num);
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x00024427 File Offset: 0x00022627
		private void InitRefTypes()
		{
			this.MapGUID = 0UL;
			this.GameType = eGameType.None;
			this.SyncType = ePartyLeaderSyncType.None;
			this.LeaderSceneID = eSceneID.LandingPage;
			this.KeystoneID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400217D RID: 8573
		public const uint cPacketType = 2376855915u;
	}
}
