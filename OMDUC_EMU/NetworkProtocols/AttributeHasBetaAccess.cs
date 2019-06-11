using System;

namespace NetworkProtocols
{
	// Token: 0x02000514 RID: 1300
	public class AttributeHasBetaAccess : BaseAwardEntry
	{
		// Token: 0x06002CFA RID: 11514 RVA: 0x00017E05 File Offset: 0x00016005
		public AttributeHasBetaAccess()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1367386640u;
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CFC RID: 11516 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
