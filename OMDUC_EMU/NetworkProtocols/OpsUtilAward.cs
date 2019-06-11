using System;

namespace NetworkProtocols
{
	// Token: 0x02000554 RID: 1364
	public class OpsUtilAward : BaseAwardItem
	{
		// Token: 0x06002E80 RID: 11904 RVA: 0x00018A59 File Offset: 0x00016C59
		public OpsUtilAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 637610300u;
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E82 RID: 11906 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
