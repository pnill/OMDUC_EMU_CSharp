using System;

namespace NetworkProtocols
{
	// Token: 0x02000524 RID: 1316
	public class InsertPartIntoSlot : BaseAwardItem
	{
		// Token: 0x06002D56 RID: 11606 RVA: 0x000180F7 File Offset: 0x000162F7
		public InsertPartIntoSlot()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1479495897u;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D58 RID: 11608 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
