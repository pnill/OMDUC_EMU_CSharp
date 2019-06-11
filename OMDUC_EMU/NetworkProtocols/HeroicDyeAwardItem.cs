using System;

namespace NetworkProtocols
{
	// Token: 0x02000559 RID: 1369
	public class HeroicDyeAwardItem : BaseAwardItem
	{
		// Token: 0x06002E98 RID: 11928 RVA: 0x00018B0A File Offset: 0x00016D0A
		public HeroicDyeAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3842159476u;
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E9A RID: 11930 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
