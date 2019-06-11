using System;

namespace NetworkProtocols
{
	// Token: 0x02000538 RID: 1336
	public class LevelProgressAward : BaseAwardItem
	{
		// Token: 0x06002DA8 RID: 11688 RVA: 0x00018305 File Offset: 0x00016505
		public LevelProgressAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3078492530u;
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DAA RID: 11690 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
