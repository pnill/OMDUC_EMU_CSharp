using System;

namespace NetworkProtocols
{
	// Token: 0x0200054B RID: 1355
	public class AchievementAwardItem : BaseAwardItem
	{
		// Token: 0x06002E2C RID: 11820 RVA: 0x00018783 File Offset: 0x00016983
		public AchievementAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3896495951u;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x0001879C File Offset: 0x0001699C
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x000187A4 File Offset: 0x000169A4
		public ulong AchievementGUID { get; set; }

		// Token: 0x06002E2F RID: 11823 RVA: 0x000FF7AC File Offset: 0x000FD9AC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AchievementGUID);
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

		// Token: 0x06002E30 RID: 11824 RVA: 0x000FF80C File Offset: 0x000FDA0C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000187AD File Offset: 0x000169AD
		private void InitRefTypes()
		{
			this.AchievementGUID = 0UL;
		}
	}
}
