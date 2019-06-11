using System;

namespace NetworkProtocols
{
	// Token: 0x02000507 RID: 1287
	public class BonusXP : BaseAwardEntry
	{
		// Token: 0x06002CBC RID: 11452 RVA: 0x00017C3C File Offset: 0x00015E3C
		public BonusXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2181549954u;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CBE RID: 11454 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
