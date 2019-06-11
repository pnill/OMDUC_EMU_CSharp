using System;

namespace NetworkProtocols
{
	// Token: 0x02000515 RID: 1301
	public class AttributeFoundersLevelApprentice : BaseAwardEntry
	{
		// Token: 0x06002CFE RID: 11518 RVA: 0x00017E1E File Offset: 0x0001601E
		public AttributeFoundersLevelApprentice()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1427942764u;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002D00 RID: 11520 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
