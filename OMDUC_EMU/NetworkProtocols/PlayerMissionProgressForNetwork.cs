using System;

namespace NetworkProtocols
{
	// Token: 0x02000643 RID: 1603
	public class PlayerMissionProgressForNetwork
	{
		// Token: 0x060037E3 RID: 14307 RVA: 0x0001EABC File Offset: 0x0001CCBC
		public PlayerMissionProgressForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x0001EACA File Offset: 0x0001CCCA
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x0001EAD2 File Offset: 0x0001CCD2
		public ulong CampaignID { get; set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x0001EADB File Offset: 0x0001CCDB
		// (set) Token: 0x060037E7 RID: 14311 RVA: 0x0001EAE3 File Offset: 0x0001CCE3
		public ulong MissionID { get; set; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x0001EAEC File Offset: 0x0001CCEC
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x0001EAF4 File Offset: 0x0001CCF4
		public ulong DeckID { get; set; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x0001EAFD File Offset: 0x0001CCFD
		// (set) Token: 0x060037EB RID: 14315 RVA: 0x0001EB05 File Offset: 0x0001CD05
		public int StarsEarned { get; set; }

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x0001EB0E File Offset: 0x0001CD0E
		// (set) Token: 0x060037ED RID: 14317 RVA: 0x0001EB16 File Offset: 0x0001CD16
		public eMissionStatus Status { get; set; }

		// Token: 0x060037EE RID: 14318 RVA: 0x0010D13C File Offset: 0x0010B33C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CampaignID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MissionID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.StarsEarned);
			ArrayManager.WriteeMissionStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x0010D1A8 File Offset: 0x0010B3A8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.CampaignID = ArrayManager.ReadUInt64(data, ref num);
			this.MissionID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckID = ArrayManager.ReadUInt64(data, ref num);
			this.StarsEarned = ArrayManager.ReadInt32(data, ref num);
			this.Status = ArrayManager.ReadeMissionStatus(data, ref num);
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x0001EB1F File Offset: 0x0001CD1F
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			this.MissionID = 0UL;
			this.DeckID = 0UL;
			this.StarsEarned = 0;
			this.Status = eMissionStatus.None;
		}
	}
}
