using System;

namespace NetworkProtocols
{
	// Token: 0x02000569 RID: 1385
	public class CommunityEventGoalAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002F2C RID: 12076 RVA: 0x000190CF File Offset: 0x000172CF
		public CommunityEventGoalAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2187680964u;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000190E8 File Offset: 0x000172E8
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x000190F0 File Offset: 0x000172F0
		public ulong AccountSUID { get; set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000190F9 File Offset: 0x000172F9
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00019101 File Offset: 0x00017301
		public ulong EventID { get; set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x0001910A File Offset: 0x0001730A
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00019112 File Offset: 0x00017312
		public ulong GoalID { get; set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x0001911B File Offset: 0x0001731B
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x00019123 File Offset: 0x00017323
		public ulong EventChestID { get; set; }

		// Token: 0x06002F35 RID: 12085 RVA: 0x00100B00 File Offset: 0x000FED00
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

		// Token: 0x06002F36 RID: 12086 RVA: 0x00100B8C File Offset: 0x000FED8C
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

		// Token: 0x06002F37 RID: 12087 RVA: 0x0001912C File Offset: 0x0001732C
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
