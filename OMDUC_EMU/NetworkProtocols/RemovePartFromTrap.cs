using System;

namespace NetworkProtocols
{
	// Token: 0x02000533 RID: 1331
	public class RemovePartFromTrap : BaseAwardItem
	{
		// Token: 0x06002D92 RID: 11666 RVA: 0x0001826E File Offset: 0x0001646E
		public RemovePartFromTrap()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2538091688u;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D94 RID: 11668 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
