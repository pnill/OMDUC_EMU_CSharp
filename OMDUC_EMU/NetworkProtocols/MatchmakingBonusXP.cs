using System;

namespace NetworkProtocols
{
	// Token: 0x0200050B RID: 1291
	public class MatchmakingBonusXP : BaseAwardEntry
	{
		// Token: 0x06002CCE RID: 11470 RVA: 0x00017CBB File Offset: 0x00015EBB
		public MatchmakingBonusXP()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3357928057u;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000FE11C File Offset: 0x000FC31C
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

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000FE16C File Offset: 0x000FC36C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
