using System;

namespace NetworkProtocols
{
	// Token: 0x02000560 RID: 1376
	public class PlayerMessageCommunityEventGoalAwardItem : BaseAwardItem
	{
		// Token: 0x06002ECE RID: 11982 RVA: 0x00018D07 File Offset: 0x00016F07
		public PlayerMessageCommunityEventGoalAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3443600518u;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x00018D20 File Offset: 0x00016F20
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x00018D28 File Offset: 0x00016F28
		public ulong AccountSUID { get; set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x00018D31 File Offset: 0x00016F31
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00018D39 File Offset: 0x00016F39
		public ulong EventID { get; set; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00018D42 File Offset: 0x00016F42
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00018D4A File Offset: 0x00016F4A
		public ulong GoalID { get; set; }

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00100330 File Offset: 0x000FE530
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
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

		// Token: 0x06002ED6 RID: 11990 RVA: 0x001003B0 File Offset: 0x000FE5B0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00018D53 File Offset: 0x00016F53
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.GoalID = 0UL;
		}
	}
}
