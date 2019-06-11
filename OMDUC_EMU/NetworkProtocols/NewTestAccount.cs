using System;

namespace NetworkProtocols
{
	// Token: 0x0200052C RID: 1324
	public class NewTestAccount : BaseAwardItem
	{
		// Token: 0x06002D76 RID: 11638 RVA: 0x000181BF File Offset: 0x000163BF
		public NewTestAccount()
		{
			this.InitRefTypes();
			this.UniqueClassID = 703425326u;
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D78 RID: 11640 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
