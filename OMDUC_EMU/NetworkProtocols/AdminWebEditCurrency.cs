using System;

namespace NetworkProtocols
{
	// Token: 0x0200052D RID: 1325
	public class AdminWebEditCurrency : BaseAwardItem
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x000181D8 File Offset: 0x000163D8
		public AdminWebEditCurrency()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2355490823u;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D7C RID: 11644 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
