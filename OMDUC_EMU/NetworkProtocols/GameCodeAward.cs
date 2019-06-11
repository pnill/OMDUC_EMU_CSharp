using System;

namespace NetworkProtocols
{
	// Token: 0x02000556 RID: 1366
	public class GameCodeAward : BaseAwardItem
	{
		// Token: 0x06002E8A RID: 11914 RVA: 0x00018AA5 File Offset: 0x00016CA5
		public GameCodeAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2489280553u;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E8C RID: 11916 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
