using System;

namespace NetworkProtocols
{
	// Token: 0x02000537 RID: 1335
	public class HeroProgressAward : BaseAwardItem
	{
		// Token: 0x06002DA4 RID: 11684 RVA: 0x000182EC File Offset: 0x000164EC
		public HeroProgressAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4010707170u;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
