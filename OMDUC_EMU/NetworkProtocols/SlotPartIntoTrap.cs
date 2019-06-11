using System;

namespace NetworkProtocols
{
	// Token: 0x02000532 RID: 1330
	public class SlotPartIntoTrap : BaseAwardItem
	{
		// Token: 0x06002D8E RID: 11662 RVA: 0x00018255 File Offset: 0x00016455
		public SlotPartIntoTrap()
		{
			this.InitRefTypes();
			this.UniqueClassID = 21261477u;
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D90 RID: 11664 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
