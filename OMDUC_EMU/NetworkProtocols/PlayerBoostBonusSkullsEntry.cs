using System;

namespace NetworkProtocols
{
	// Token: 0x0200051B RID: 1307
	public class PlayerBoostBonusSkullsEntry : BaseAwardEntry
	{
		// Token: 0x06002D22 RID: 11554 RVA: 0x00017F4C File Offset: 0x0001614C
		public PlayerBoostBonusSkullsEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2587831611u;
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x00017F65 File Offset: 0x00016165
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x00017F6D File Offset: 0x0001616D
		public ulong AccountSUID { get; set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x00017F76 File Offset: 0x00016176
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x00017F7E File Offset: 0x0001617E
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x06002D27 RID: 11559 RVA: 0x000FE8F0 File Offset: 0x000FCAF0
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

		// Token: 0x06002D28 RID: 11560 RVA: 0x000FE960 File Offset: 0x000FCB60
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00017F87 File Offset: 0x00016187
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.BoostType = ePlayerBoostType.None;
		}
	}
}
