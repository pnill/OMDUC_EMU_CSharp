using System;

namespace NetworkProtocols
{
	// Token: 0x02000503 RID: 1283
	public class GibsDebit : BaseAwardEntry
	{
		// Token: 0x06002CAA RID: 11434 RVA: 0x00017BBE File Offset: 0x00015DBE
		public GibsDebit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 189685870u;
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CAC RID: 11436 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
