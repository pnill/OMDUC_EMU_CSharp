using System;

namespace NetworkProtocols
{
	// Token: 0x02000518 RID: 1304
	public class PlayerBoostAwardEntry : BaseAwardEntry
	{
		// Token: 0x06002D0A RID: 11530 RVA: 0x00017E69 File Offset: 0x00016069
		public PlayerBoostAwardEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3783838708u;
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x00017E82 File Offset: 0x00016082
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x00017E8A File Offset: 0x0001608A
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x00017E93 File Offset: 0x00016093
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x00017E9B File Offset: 0x0001609B
		public uint Days { get; set; }

		// Token: 0x06002D0F RID: 11535 RVA: 0x000FE6BC File Offset: 0x000FC8BC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteePlayerBoostType(ref newArray, ref num, this.BoostType);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Days);
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

		// Token: 0x06002D10 RID: 11536 RVA: 0x000FE72C File Offset: 0x000FC92C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			this.Days = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x00017EA4 File Offset: 0x000160A4
		private void InitRefTypes()
		{
			this.BoostType = ePlayerBoostType.None;
			this.Days = 0u;
		}
	}
}
