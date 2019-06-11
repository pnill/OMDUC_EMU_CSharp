using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006FE RID: 1790
	public class PushPartyLeaderViewSync : BotNetMessage
	{
		// Token: 0x06003FF2 RID: 16370 RVA: 0x00024455 File Offset: 0x00022655
		public PushPartyLeaderViewSync()
		{
			this.InitRefTypes();
			base.PacketType = 1536792188u;
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x0002446E File Offset: 0x0002266E
		public PushPartyLeaderViewSync(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1536792188u;
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x0002448E File Offset: 0x0002268E
		// (set) Token: 0x06003FF5 RID: 16373 RVA: 0x00024496 File Offset: 0x00022696
		public ulong MapGUID { get; set; }

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x0002449F File Offset: 0x0002269F
		// (set) Token: 0x06003FF7 RID: 16375 RVA: 0x000244A7 File Offset: 0x000226A7
		public eGameType GameType { get; set; }

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x000244B0 File Offset: 0x000226B0
		// (set) Token: 0x06003FF9 RID: 16377 RVA: 0x000244B8 File Offset: 0x000226B8
		public ePartyLeaderSyncType SyncType { get; set; }

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06003FFA RID: 16378 RVA: 0x000244C1 File Offset: 0x000226C1
		// (set) Token: 0x06003FFB RID: 16379 RVA: 0x000244C9 File Offset: 0x000226C9
		public eSceneID LeaderSceneID { get; set; }

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06003FFC RID: 16380 RVA: 0x000244D2 File Offset: 0x000226D2
		// (set) Token: 0x06003FFD RID: 16381 RVA: 0x000244DA File Offset: 0x000226DA
		public List<PartyMemberMapStat> MemberMapStats { get; set; }

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x000244E3 File Offset: 0x000226E3
		// (set) Token: 0x06003FFF RID: 16383 RVA: 0x000244EB File Offset: 0x000226EB
		public KeystoneDetailPacket KeystoneDetail { get; set; }

		// Token: 0x06004000 RID: 16384 RVA: 0x0011C6C4 File Offset: 0x0011A8C4
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
			ArrayManager.WriteListPartyMemberMapStat(ref newArray, ref newSize, this.MemberMapStats);
			ArrayManager.WriteKeystoneDetailPacket(ref newArray, ref newSize, this.KeystoneDetail);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x0011C78C File Offset: 0x0011A98C
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
			this.MemberMapStats = ArrayManager.ReadListPartyMemberMapStat(data, ref num);
			this.KeystoneDetail = ArrayManager.ReadKeystoneDetailPacket(data, ref num);
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x000244F4 File Offset: 0x000226F4
		private void InitRefTypes()
		{
			this.MapGUID = 0UL;
			this.GameType = eGameType.None;
			this.SyncType = ePartyLeaderSyncType.None;
			this.LeaderSceneID = eSceneID.LandingPage;
			this.MemberMapStats = new List<PartyMemberMapStat>();
			this.KeystoneDetail = new KeystoneDetailPacket();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002183 RID: 8579
		public const uint cPacketType = 1536792188u;
	}
}
