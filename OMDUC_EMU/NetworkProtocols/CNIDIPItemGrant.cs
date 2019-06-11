using System;

namespace NetworkProtocols
{
	// Token: 0x02000528 RID: 1320
	public class CNIDIPItemGrant : BaseAwardItem
	{
		// Token: 0x06002D66 RID: 11622 RVA: 0x0001815B File Offset: 0x0001635B
		public CNIDIPItemGrant()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1647504857u;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D68 RID: 11624 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
