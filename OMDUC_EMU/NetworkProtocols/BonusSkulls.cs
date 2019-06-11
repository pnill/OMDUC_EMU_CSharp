using System;

namespace NetworkProtocols
{
	// Token: 0x020004FE RID: 1278
	public class BonusSkulls : BaseAwardEntry
	{
		// Token: 0x06002C8E RID: 11406 RVA: 0x00017AD9 File Offset: 0x00015CD9
		public BonusSkulls()
		{
			this.InitRefTypes();
			this.UniqueClassID = 290331529u;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002C90 RID: 11408 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
