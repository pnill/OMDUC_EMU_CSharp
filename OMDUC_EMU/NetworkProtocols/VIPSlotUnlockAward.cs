using System;

namespace NetworkProtocols
{
	// Token: 0x0200055A RID: 1370
	public class VIPSlotUnlockAward : BaseAwardItem
	{
		// Token: 0x06002E9C RID: 11932 RVA: 0x00018B23 File Offset: 0x00016D23
		public VIPSlotUnlockAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 510495055u;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E9E RID: 11934 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
