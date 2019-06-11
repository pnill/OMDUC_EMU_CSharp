using System;

namespace NetworkProtocols
{
	// Token: 0x0200051C RID: 1308
	public class TeamMemberBoostBonusSkullsEntry : BaseAwardEntry
	{
		// Token: 0x06002D2A RID: 11562 RVA: 0x00017F98 File Offset: 0x00016198
		public TeamMemberBoostBonusSkullsEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2530569989u;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x00017FB1 File Offset: 0x000161B1
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x00017FB9 File Offset: 0x000161B9
		public ulong AccountSUID { get; set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x00017FC2 File Offset: 0x000161C2
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x00017FCA File Offset: 0x000161CA
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x06002D2F RID: 11567 RVA: 0x000FE9AC File Offset: 0x000FCBAC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteePlayerBoostType(ref newArray, ref num, this.BoostType);
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

		// Token: 0x06002D30 RID: 11568 RVA: 0x000FEA1C File Offset: 0x000FCC1C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00017FD3 File Offset: 0x000161D3
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.BoostType = ePlayerBoostType.None;
		}
	}
}
