using System;

namespace NetworkProtocols
{
	// Token: 0x0200053A RID: 1338
	public class DropsAndConsumablesAward : BaseAwardItem
	{
		// Token: 0x06002DB0 RID: 11696 RVA: 0x00018337 File Offset: 0x00016537
		public DropsAndConsumablesAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3514390489u;
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
