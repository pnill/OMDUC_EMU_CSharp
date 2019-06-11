using System;

namespace NetworkProtocols
{
	// Token: 0x0200056C RID: 1388
	public class GibsConversionRemovalFromInventory : BaseAwardItem
	{
		// Token: 0x06002F52 RID: 12114 RVA: 0x00019265 File Offset: 0x00017465
		public GibsConversionRemovalFromInventory()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2468791128u;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002F54 RID: 12116 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
