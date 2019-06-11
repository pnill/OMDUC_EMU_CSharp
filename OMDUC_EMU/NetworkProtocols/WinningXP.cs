using System;

namespace NetworkProtocols
{
	// Token: 0x0200050D RID: 1293
	public class WinningXP : BaseAwardEntry
	{
		// Token: 0x06002CD6 RID: 11478 RVA: 0x00017CED File Offset: 0x00015EED
		public WinningXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3450016786u;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000FE11C File Offset: 0x000FC31C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
