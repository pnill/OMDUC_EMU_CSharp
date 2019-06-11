using System;

namespace NetworkProtocols
{
	// Token: 0x0200050A RID: 1290
	public class GuildPlayBonusXP : BaseAwardEntry
	{
		// Token: 0x06002CCA RID: 11466 RVA: 0x00017CA2 File Offset: 0x00015EA2
		public GuildPlayBonusXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3279442748u;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CCC RID: 11468 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
