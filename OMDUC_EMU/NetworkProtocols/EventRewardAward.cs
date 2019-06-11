using System;

namespace NetworkProtocols
{
	// Token: 0x02000543 RID: 1347
	public class EventRewardAward : BaseAwardItem
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x00018551 File Offset: 0x00016751
		public EventRewardAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3181919390u;
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DEE RID: 11758 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
