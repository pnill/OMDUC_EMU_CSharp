using System;

namespace NetworkProtocols
{
	// Token: 0x02000539 RID: 1337
	public class HeroLevelUpAward : BaseAwardItem
	{
		// Token: 0x06002DAC RID: 11692 RVA: 0x0001831E File Offset: 0x0001651E
		public HeroLevelUpAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1805113583u;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DAE RID: 11694 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
