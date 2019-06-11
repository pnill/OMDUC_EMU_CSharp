using System;

namespace NetworkProtocols
{
	// Token: 0x02000516 RID: 1302
	public class AttributeFoundersLevelWarMage : BaseAwardEntry
	{
		// Token: 0x06002D02 RID: 11522 RVA: 0x00017E37 File Offset: 0x00016037
		public AttributeFoundersLevelWarMage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 858315555u;
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002D04 RID: 11524 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
