using System;

namespace NetworkProtocols
{
	// Token: 0x02000667 RID: 1639
	public class PlayerCommunityEventBoostForNetwork
	{
		// Token: 0x06003956 RID: 14678 RVA: 0x0001FABB File Offset: 0x0001DCBB
		public PlayerCommunityEventBoostForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x0001FAC9 File Offset: 0x0001DCC9
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x0001FAD1 File Offset: 0x0001DCD1
		public DateTime StartOn { get; set; }

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x0001FADA File Offset: 0x0001DCDA
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x0001FAE2 File Offset: 0x0001DCE2
		public DateTime EndOn { get; set; }

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x0001FAEB File Offset: 0x0001DCEB
		// (set) Token: 0x0600395C RID: 14684 RVA: 0x0001FAF3 File Offset: 0x0001DCF3
		public ulong BoostID { get; set; }

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0001FAFC File Offset: 0x0001DCFC
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x0001FB04 File Offset: 0x0001DD04
		public string Title { get; set; }

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x0001FB0D File Offset: 0x0001DD0D
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x0001FB15 File Offset: 0x0001DD15
		public string Description { get; set; }

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0001FB1E File Offset: 0x0001DD1E
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x0001FB26 File Offset: 0x0001DD26
		public eCommunityEventBoost BoostType { get; set; }

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x0001FB2F File Offset: 0x0001DD2F
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x0001FB37 File Offset: 0x0001DD37
		public decimal Multiplier { get; set; }

		// Token: 0x06003965 RID: 14693 RVA: 0x0010F3F0 File Offset: 0x0010D5F0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.StartOn);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.EndOn);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BoostID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteeCommunityEventBoost(ref newArray, ref newSize, this.BoostType);
			ArrayManager.WriteDecimal(ref newArray, ref newSize, this.Multiplier);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0010F478 File Offset: 0x0010D678
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.StartOn = ArrayManager.ReadDateTime(data, ref num);
			this.EndOn = ArrayManager.ReadDateTime(data, ref num);
			this.BoostID = ArrayManager.ReadUInt64(data, ref num);
			this.Title = ArrayManager.ReadString(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
			this.BoostType = ArrayManager.ReadeCommunityEventBoost(data, ref num);
			this.Multiplier = ArrayManager.ReadDecimal(data, ref num);
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x0010F4EC File Offset: 0x0010D6EC
		private void InitRefTypes()
		{
			this.StartOn = default(DateTime);
			this.EndOn = default(DateTime);
			this.BoostID = 0UL;
			this.Title = string.Empty;
			this.Description = string.Empty;
			this.BoostType = eCommunityEventBoost.None;
			this.Multiplier = 0m;
		}
	}
}
