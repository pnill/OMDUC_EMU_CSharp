using System;

namespace NetworkProtocols
{
	// Token: 0x02000506 RID: 1286
	public class BaseXP : BaseAwardEntry
	{
		// Token: 0x06002CB8 RID: 11448 RVA: 0x00017C23 File Offset: 0x00015E23
		public BaseXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2040517672u;
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CBA RID: 11450 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
