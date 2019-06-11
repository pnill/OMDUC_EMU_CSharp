using System;

namespace NetworkProtocols
{
	// Token: 0x0200055F RID: 1375
	public class PlayerMessageCommunityEventPartialAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002EC4 RID: 11972 RVA: 0x00018CA1 File Offset: 0x00016EA1
		public PlayerMessageCommunityEventPartialAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1458992936u;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x00018CBA File Offset: 0x00016EBA
		// (set) Token: 0x06002EC6 RID: 11974 RVA: 0x00018CC2 File Offset: 0x00016EC2
		public ulong AccountSUID { get; set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x00018CCB File Offset: 0x00016ECB
		// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x00018CD3 File Offset: 0x00016ED3
		public ulong EventID { get; set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00018CDC File Offset: 0x00016EDC
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00018CE4 File Offset: 0x00016EE4
		public ulong EventChestID { get; set; }

		// Token: 0x06002ECB RID: 11979 RVA: 0x00100258 File Offset: 0x000FE458
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
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

		// Token: 0x06002ECC RID: 11980 RVA: 0x001002D8 File Offset: 0x000FE4D8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00018CED File Offset: 0x00016EED
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
