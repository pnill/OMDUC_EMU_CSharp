using System;

namespace NetworkProtocols
{
	// Token: 0x02000517 RID: 1303
	public class AttributeFoundersLevelMaster : BaseAwardEntry
	{
		// Token: 0x06002D06 RID: 11526 RVA: 0x00017E50 File Offset: 0x00016050
		public AttributeFoundersLevelMaster()
		{
			this.InitRefTypes();
			this.UniqueClassID = 475402054u;
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002D08 RID: 11528 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
