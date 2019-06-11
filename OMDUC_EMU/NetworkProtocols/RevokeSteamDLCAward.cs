using System;

namespace NetworkProtocols
{
	// Token: 0x02000557 RID: 1367
	public class RevokeSteamDLCAward : BaseAwardItem
	{
		// Token: 0x06002E8E RID: 11918 RVA: 0x00018ABE File Offset: 0x00016CBE
		public RevokeSteamDLCAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 416722753u;
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002E90 RID: 11920 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
