using System;

namespace NetworkProtocols
{
	// Token: 0x0200053B RID: 1339
	public class TutorialRewardsAward : BaseAwardItem
	{
		// Token: 0x06002DB4 RID: 11700 RVA: 0x00018350 File Offset: 0x00016550
		public TutorialRewardsAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1933065111u;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
