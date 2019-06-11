using System;

namespace NetworkProtocols
{
	// Token: 0x0200052F RID: 1327
	public class NewAccount : BaseAwardItem
	{
		// Token: 0x06002D82 RID: 11650 RVA: 0x0001820A File Offset: 0x0001640A
		public NewAccount()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4236227393u;
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D84 RID: 11652 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
