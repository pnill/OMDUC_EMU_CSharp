using System;

namespace NetworkProtocols
{
	// Token: 0x02000530 RID: 1328
	public class UpgradeTrap : BaseAwardItem
	{
		// Token: 0x06002D86 RID: 11654 RVA: 0x00018223 File Offset: 0x00016423
		public UpgradeTrap()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2464137891u;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D88 RID: 11656 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
