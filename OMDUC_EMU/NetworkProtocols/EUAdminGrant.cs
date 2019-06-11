using System;

namespace NetworkProtocols
{
	// Token: 0x02000526 RID: 1318
	public class EUAdminGrant : BaseAwardItem
	{
		// Token: 0x06002D5E RID: 11614 RVA: 0x00018129 File Offset: 0x00016329
		public EUAdminGrant()
		{
			this.InitRefTypes();
			this.UniqueClassID = 64202748u;
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D60 RID: 11616 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
