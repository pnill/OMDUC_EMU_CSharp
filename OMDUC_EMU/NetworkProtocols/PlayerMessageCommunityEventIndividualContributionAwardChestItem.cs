using System;

namespace NetworkProtocols
{
	// Token: 0x02000563 RID: 1379
	public class PlayerMessageCommunityEventIndividualContributionAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002EF0 RID: 12016 RVA: 0x00018E6B File Offset: 0x0001706B
		public PlayerMessageCommunityEventIndividualContributionAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1613350415u;
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x00018E84 File Offset: 0x00017084
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x00018E8C File Offset: 0x0001708C
		public ulong AccountSUID { get; set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x00018E95 File Offset: 0x00017095
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x00018E9D File Offset: 0x0001709D
		public ulong EventID { get; set; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x00018EA6 File Offset: 0x000170A6
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x00018EAE File Offset: 0x000170AE
		public ulong GoalID { get; set; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00018EB7 File Offset: 0x000170B7
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00018EBF File Offset: 0x000170BF
		public ulong IndividualContributionID { get; set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00018EC8 File Offset: 0x000170C8
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00018ED0 File Offset: 0x000170D0
		public ulong EventChestID { get; set; }

		// Token: 0x06002EFB RID: 12027 RVA: 0x001005F0 File Offset: 0x000FE7F0
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.IndividualContributionID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestID);
			byte[] array = base.SerializeMessage();
			if (array.Length + num > newArray.Length)
			{
				Array.Resize<byte>(ref newArray, array.Length + num);
			}
			Array.Copy(array, 0, newArray, num, array.Length);
			num += array.Length;
			Array.Resize<byte>(ref newArray, num);
			return newArray;
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x0010068C File Offset: 0x000FE88C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.IndividualContributionID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00018ED9 File Offset: 0x000170D9
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.IndividualContributionID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
