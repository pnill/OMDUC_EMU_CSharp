using System;

namespace NetworkProtocols
{
	// Token: 0x02000522 RID: 1314
	public class BucketUnlockAwardEntry : BaseAwardEntry
	{
		// Token: 0x06002D4C RID: 11596 RVA: 0x000180B2 File Offset: 0x000162B2
		public BucketUnlockAwardEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1073088260u;
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002D4E RID: 11598 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
