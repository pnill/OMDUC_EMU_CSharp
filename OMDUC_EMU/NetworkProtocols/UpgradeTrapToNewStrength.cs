using System;

namespace NetworkProtocols
{
	// Token: 0x02000525 RID: 1317
	public class UpgradeTrapToNewStrength : BaseAwardItem
	{
		// Token: 0x06002D5A RID: 11610 RVA: 0x00018110 File Offset: 0x00016310
		public UpgradeTrapToNewStrength()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3135694640u;
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D5C RID: 11612 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
