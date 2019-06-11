using System;

namespace NetworkProtocols
{
	// Token: 0x0200051A RID: 1306
	public class TeamMemberBoostBonusXPEntry : BaseAwardEntry
	{
		// Token: 0x06002D1A RID: 11546 RVA: 0x00017F00 File Offset: 0x00016100
		public TeamMemberBoostBonusXPEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3517520885u;
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x00017F19 File Offset: 0x00016119
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x00017F21 File Offset: 0x00016121
		public ulong AccountSUID { get; set; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x00017F2A File Offset: 0x0001612A
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00017F32 File Offset: 0x00016132
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x06002D1F RID: 11551 RVA: 0x000FE834 File Offset: 0x000FCA34
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

		// Token: 0x06002D20 RID: 11552 RVA: 0x000FE8A4 File Offset: 0x000FCAA4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00017F3B File Offset: 0x0001613B
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.BoostType = ePlayerBoostType.None;
		}
	}
}
