using System;

namespace NetworkProtocols
{
	// Token: 0x0200053F RID: 1343
	public class SabotageAward : BaseAwardItem
	{
		// Token: 0x06002DCC RID: 11724 RVA: 0x0001841D File Offset: 0x0001661D
		public SabotageAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 168388062u;
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DCE RID: 11726 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
