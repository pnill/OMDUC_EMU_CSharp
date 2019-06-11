using System;

namespace NetworkProtocols
{
	// Token: 0x0200050C RID: 1292
	public class FinishingGameEarlyXP : BaseAwardEntry
	{
		// Token: 0x06002CD2 RID: 11474 RVA: 0x00017CD4 File Offset: 0x00015ED4
		public FinishingGameEarlyXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2266498662u;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
