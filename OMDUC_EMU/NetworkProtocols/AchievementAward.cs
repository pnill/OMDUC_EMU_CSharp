using System;

namespace NetworkProtocols
{
	// Token: 0x02000548 RID: 1352
	public class AchievementAward : BaseAwardItem
	{
		// Token: 0x06002E14 RID: 11796 RVA: 0x000186AE File Offset: 0x000168AE
		public AchievementAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1795246124u;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000186C7 File Offset: 0x000168C7
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x000186CF File Offset: 0x000168CF
		public ulong AchievementGUID { get; set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000186D8 File Offset: 0x000168D8
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x000186E0 File Offset: 0x000168E0
		public Guid GameStateID { get; set; }

		// Token: 0x06002E19 RID: 11801 RVA: 0x000FF558 File Offset: 0x000FD758
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AchievementGUID);
			ArrayManager.WriteGuid(ref newArray, ref num, this.GameStateID);
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

		// Token: 0x06002E1A RID: 11802 RVA: 0x000FF5C8 File Offset: 0x000FD7C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			this.GameStateID = ArrayManager.ReadGuid(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000FF614 File Offset: 0x000FD814
		private void InitRefTypes()
		{
			this.AchievementGUID = 0UL;
			this.GameStateID = default(Guid);
		}
	}
}
