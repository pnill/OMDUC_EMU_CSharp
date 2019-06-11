using System;

namespace NetworkProtocols
{
	// Token: 0x0200052E RID: 1326
	public class AdminWebSetLevel : BaseAwardItem
	{
		// Token: 0x06002D7E RID: 11646 RVA: 0x000181F1 File Offset: 0x000163F1
		public AdminWebSetLevel()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3431923303u;
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D80 RID: 11648 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
