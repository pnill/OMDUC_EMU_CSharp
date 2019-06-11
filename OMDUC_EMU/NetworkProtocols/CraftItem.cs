using System;

namespace NetworkProtocols
{
	// Token: 0x02000531 RID: 1329
	public class CraftItem : BaseAwardItem
	{
		// Token: 0x06002D8A RID: 11658 RVA: 0x0001823C File Offset: 0x0001643C
		public CraftItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2385511844u;
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D8C RID: 11660 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
