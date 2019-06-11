using System;

namespace NetworkProtocols
{
	// Token: 0x02000551 RID: 1361
	public class GuildAward : BaseAwardItem
	{
		// Token: 0x06002E74 RID: 11892 RVA: 0x00018A0E File Offset: 0x00016C0E
		public GuildAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3099055238u;
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E76 RID: 11894 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
