using System;

namespace NetworkProtocols
{
	// Token: 0x0200052B RID: 1323
	public class TestPopulateLeaderboardsAward : BaseAwardItem
	{
		// Token: 0x06002D72 RID: 11634 RVA: 0x000181A6 File Offset: 0x000163A6
		public TestPopulateLeaderboardsAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4128389343u;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D74 RID: 11636 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
