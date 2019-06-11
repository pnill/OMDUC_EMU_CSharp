using System;

namespace NetworkProtocols
{
	// Token: 0x02000561 RID: 1377
	public class PlayerMessageCommunityEventGoalAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002ED8 RID: 11992 RVA: 0x00018D6D File Offset: 0x00016F6D
		public PlayerMessageCommunityEventGoalAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 146092671u;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x00018D86 File Offset: 0x00016F86
		// (set) Token: 0x06002EDA RID: 11994 RVA: 0x00018D8E File Offset: 0x00016F8E
		public ulong AccountSUID { get; set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00018D97 File Offset: 0x00016F97
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x00018D9F File Offset: 0x00016F9F
		public ulong EventID { get; set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x00018DA8 File Offset: 0x00016FA8
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00018DB0 File Offset: 0x00016FB0
		public ulong GoalID { get; set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x00018DB9 File Offset: 0x00016FB9
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00018DC1 File Offset: 0x00016FC1
		public ulong EventChestID { get; set; }

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00100408 File Offset: 0x000FE608
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
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

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00100494 File Offset: 0x000FE694
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00018DCA File Offset: 0x00016FCA
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
