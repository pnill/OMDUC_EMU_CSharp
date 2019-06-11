using System;

namespace NetworkProtocols
{
	// Token: 0x02000512 RID: 1298
	public class AttributeAvatarKey : BaseAwardEntry
	{
		// Token: 0x06002CF2 RID: 11506 RVA: 0x00017DD3 File Offset: 0x00015FD3
		public AttributeAvatarKey()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1062336106u;
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CF4 RID: 11508 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
