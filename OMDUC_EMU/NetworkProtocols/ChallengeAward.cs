using System;

namespace NetworkProtocols
{
	// Token: 0x02000553 RID: 1363
	public class ChallengeAward : BaseAwardItem
	{
		// Token: 0x06002E7C RID: 11900 RVA: 0x00018A40 File Offset: 0x00016C40
		public ChallengeAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3530821286u;
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E7E RID: 11902 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
