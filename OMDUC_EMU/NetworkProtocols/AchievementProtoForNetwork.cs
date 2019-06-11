using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005F9 RID: 1529
	public class AchievementProtoForNetwork
	{
		// Token: 0x0600352B RID: 13611 RVA: 0x0001CD27 File Offset: 0x0001AF27
		public AchievementProtoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x0001CD35 File Offset: 0x0001AF35
		// (set) Token: 0x0600352D RID: 13613 RVA: 0x0001CD3D File Offset: 0x0001AF3D
		public ulong AchievementGUID { get; set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x0001CD46 File Offset: 0x0001AF46
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x0001CD4E File Offset: 0x0001AF4E
		public eAchievementCategory Category { get; set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x0001CD57 File Offset: 0x0001AF57
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x0001CD5F File Offset: 0x0001AF5F
		public List<eAchievementCategory> Categories { get; set; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x0001CD68 File Offset: 0x0001AF68
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x0001CD70 File Offset: 0x0001AF70
		public string Icon { get; set; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x0001CD79 File Offset: 0x0001AF79
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x0001CD81 File Offset: 0x0001AF81
		public string SteamAchievementID { get; set; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x0001CD8A File Offset: 0x0001AF8A
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x0001CD92 File Offset: 0x0001AF92
		public string PSNAchievementID { get; set; }

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x0001CD9B File Offset: 0x0001AF9B
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x0001CDA3 File Offset: 0x0001AFA3
		public List<AchievementTaskProtoForNetwork> TaskProtos { get; set; }

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x0001CDB4 File Offset: 0x0001AFB4
		public AchievementAward AwardItem { get; set; }

		// Token: 0x0600353C RID: 13628 RVA: 0x00108E64 File Offset: 0x00107064
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AchievementGUID);
			ArrayManager.WriteeAchievementCategory(ref newArray, ref newSize, this.Category);
			ArrayManager.WriteListeAchievementCategory(ref newArray, ref newSize, this.Categories);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Icon);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SteamAchievementID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PSNAchievementID);
			ArrayManager.WriteListAchievementTaskProtoForNetwork(ref newArray, ref newSize, this.TaskProtos);
			ArrayManager.WriteAchievementAward(ref newArray, ref newSize, this.AwardItem);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00108EFC File Offset: 0x001070FC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Category = ArrayManager.ReadeAchievementCategory(data, ref num);
			this.Categories = ArrayManager.ReadListeAchievementCategory(data, ref num);
			this.Icon = ArrayManager.ReadString(data, ref num);
			this.SteamAchievementID = ArrayManager.ReadString(data, ref num);
			this.PSNAchievementID = ArrayManager.ReadString(data, ref num);
			this.TaskProtos = ArrayManager.ReadListAchievementTaskProtoForNetwork(data, ref num);
			this.AwardItem = ArrayManager.ReadAchievementAward(data, ref num);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00108F7C File Offset: 0x0010717C
		private void InitRefTypes()
		{
			this.AchievementGUID = 0UL;
			this.Category = eAchievementCategory.General;
			this.Categories = new List<eAchievementCategory>();
			this.Icon = string.Empty;
			this.SteamAchievementID = string.Empty;
			this.PSNAchievementID = string.Empty;
			this.TaskProtos = new List<AchievementTaskProtoForNetwork>();
			this.AwardItem = new AchievementAward();
		}
	}
}
