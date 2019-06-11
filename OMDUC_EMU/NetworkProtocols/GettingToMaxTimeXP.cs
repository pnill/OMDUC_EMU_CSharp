using System;

namespace NetworkProtocols
{
	// Token: 0x0200050E RID: 1294
	public class GettingToMaxTimeXP : BaseAwardEntry
	{
		// Token: 0x06002CDA RID: 11482 RVA: 0x00017D06 File Offset: 0x00015F06
		public GettingToMaxTimeXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 790935960u;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CDC RID: 11484 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
