using System;

namespace NetworkProtocols
{
	// Token: 0x02000534 RID: 1332
	public class GameResultsAward : BaseAwardItem
	{
		// Token: 0x06002D96 RID: 11670 RVA: 0x00018287 File Offset: 0x00016487
		public GameResultsAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 635880283u;
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D98 RID: 11672 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
