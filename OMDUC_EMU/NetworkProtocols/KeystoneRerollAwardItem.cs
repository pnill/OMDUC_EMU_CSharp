using System;

namespace NetworkProtocols
{
	// Token: 0x0200056D RID: 1389
	public class KeystoneRerollAwardItem : BaseAwardItem
	{
		// Token: 0x06002F56 RID: 12118 RVA: 0x0001927E File Offset: 0x0001747E
		public KeystoneRerollAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3266926118u;
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002F58 RID: 12120 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
