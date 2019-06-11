using System;

namespace NetworkProtocols
{
	// Token: 0x02000501 RID: 1281
	public class SkullsDebit : BaseAwardEntry
	{
		// Token: 0x06002C9E RID: 11422 RVA: 0x00017B59 File Offset: 0x00015D59
		public SkullsDebit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1451433187u;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
