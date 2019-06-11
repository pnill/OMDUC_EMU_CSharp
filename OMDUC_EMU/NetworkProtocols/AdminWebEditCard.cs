using System;

namespace NetworkProtocols
{
	// Token: 0x02000529 RID: 1321
	public class AdminWebEditCard : BaseAwardItem
	{
		// Token: 0x06002D6A RID: 11626 RVA: 0x00018174 File Offset: 0x00016374
		public AdminWebEditCard()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1767663310u;
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D6C RID: 11628 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
