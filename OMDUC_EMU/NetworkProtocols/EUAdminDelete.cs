using System;

namespace NetworkProtocols
{
	// Token: 0x02000527 RID: 1319
	public class EUAdminDelete : BaseAwardItem
	{
		// Token: 0x06002D62 RID: 11618 RVA: 0x00018142 File Offset: 0x00016342
		public EUAdminDelete()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4055439818u;
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x000FEC8C File Offset: 0x000FCE8C
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

		// Token: 0x06002D64 RID: 11620 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
