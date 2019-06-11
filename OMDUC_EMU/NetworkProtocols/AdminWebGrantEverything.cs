using System;

namespace NetworkProtocols
{
	// Token: 0x0200052A RID: 1322
	public class AdminWebGrantEverything : BaseAwardItem
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x0001818D File Offset: 0x0001638D
		public AdminWebGrantEverything()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4074878757u;
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D70 RID: 11632 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
