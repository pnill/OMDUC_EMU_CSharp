using System;

namespace NetworkProtocols
{
	// Token: 0x02000505 RID: 1285
	public class GoldDebit : BaseAwardEntry
	{
		// Token: 0x06002CB4 RID: 11444 RVA: 0x00017C0A File Offset: 0x00015E0A
		public GoldDebit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2211258519u;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
