using System;

namespace NetworkProtocols
{
	// Token: 0x02000513 RID: 1299
	public class AttributeIsRobotEmployee : BaseAwardEntry
	{
		// Token: 0x06002CF6 RID: 11510 RVA: 0x00017DEC File Offset: 0x00015FEC
		public AttributeIsRobotEmployee()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2504398866u;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
