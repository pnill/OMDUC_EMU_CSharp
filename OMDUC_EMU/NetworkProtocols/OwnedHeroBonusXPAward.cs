using System;

namespace NetworkProtocols
{
	// Token: 0x02000509 RID: 1289
	public class OwnedHeroBonusXPAward : BaseAwardEntry
	{
		// Token: 0x06002CC6 RID: 11462 RVA: 0x00017C89 File Offset: 0x00015E89
		public OwnedHeroBonusXPAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4239422239u;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
