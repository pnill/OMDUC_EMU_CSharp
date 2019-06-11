using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000644 RID: 1604
	public class PushPlayerCampaignProgress : BotNetMessage
	{
		// Token: 0x060037F1 RID: 14321 RVA: 0x0001EB47 File Offset: 0x0001CD47
		public PushPlayerCampaignProgress()
		{
			this.InitRefTypes();
			base.PacketType = 2690842427u;
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public PushPlayerCampaignProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2690842427u;
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x0001EB80 File Offset: 0x0001CD80
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x0001EB88 File Offset: 0x0001CD88
		public ulong CampaignID { get; set; }

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x0001EB91 File Offset: 0x0001CD91
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x0001EB99 File Offset: 0x0001CD99
		public ulong CraftedItemGUID { get; set; }

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x0001EBA2 File Offset: 0x0001CDA2
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x0001EBAA File Offset: 0x0001CDAA
		public bool IsSurvivalUnlocked { get; set; }

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x0001EBB3 File Offset: 0x0001CDB3
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x0001EBBB File Offset: 0x0001CDBB
		public bool IsSiegeUnlocked { get; set; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x0001EBCC File Offset: 0x0001CDCC
		public bool IsWorkshopTaskComplete { get; set; }

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x0001EBD5 File Offset: 0x0001CDD5
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x0001EBDD File Offset: 0x0001CDDD
		public List<PlayerMissionProgressForNetwork> MissionProgress { get; set; }

		// Token: 0x060037FF RID: 14335 RVA: 0x0010D200 File Offset: 0x0010B400
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CampaignID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CraftedItemGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsSurvivalUnlocked);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsSiegeUnlocked);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsWorkshopTaskComplete);
			ArrayManager.WriteListPlayerMissionProgressForNetwork(ref newArray, ref newSize, this.MissionProgress);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x0010D2C8 File Offset: 0x0010B4C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CampaignID = ArrayManager.ReadUInt64(data, ref num);
			this.CraftedItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.IsSurvivalUnlocked = ArrayManager.ReadBoolean(data, ref num);
			this.IsSiegeUnlocked = ArrayManager.ReadBoolean(data, ref num);
			this.IsWorkshopTaskComplete = ArrayManager.ReadBoolean(data, ref num);
			this.MissionProgress = ArrayManager.ReadListPlayerMissionProgressForNetwork(data, ref num);
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x0001EBE6 File Offset: 0x0001CDE6
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			this.CraftedItemGUID = 0UL;
			this.IsSurvivalUnlocked = false;
			this.IsSiegeUnlocked = false;
			this.IsWorkshopTaskComplete = false;
			this.MissionProgress = new List<PlayerMissionProgressForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DFB RID: 7675
		public const uint cPacketType = 2690842427u;
	}
}
