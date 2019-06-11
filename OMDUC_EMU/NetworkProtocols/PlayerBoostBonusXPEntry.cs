using System;

namespace NetworkProtocols
{
	// Token: 0x02000519 RID: 1305
	public class PlayerBoostBonusXPEntry : BaseAwardEntry
	{
		// Token: 0x06002D12 RID: 11538 RVA: 0x00017EB4 File Offset: 0x000160B4
		public PlayerBoostBonusXPEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1073714819u;
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x00017ECD File Offset: 0x000160CD
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x00017ED5 File Offset: 0x000160D5
		public ulong AccountSUID { get; set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x00017EDE File Offset: 0x000160DE
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x00017EE6 File Offset: 0x000160E6
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x06002D17 RID: 11543 RVA: 0x000FE778 File Offset: 0x000FC978
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

		// Token: 0x06002D18 RID: 11544 RVA: 0x000FE7E8 File Offset: 0x000FC9E8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00017EEF File Offset: 0x000160EF
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.BoostType = ePlayerBoostType.None;
		}
	}
}
