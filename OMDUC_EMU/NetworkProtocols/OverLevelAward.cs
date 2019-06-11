using System;

namespace NetworkProtocols
{
	// Token: 0x02000535 RID: 1333
	public class OverLevelAward : BaseAwardItem
	{
		// Token: 0x06002D9A RID: 11674 RVA: 0x000182A0 File Offset: 0x000164A0
		public OverLevelAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 427133180u;
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D9C RID: 11676 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
