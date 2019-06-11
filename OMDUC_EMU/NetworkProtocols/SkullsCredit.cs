using System;

namespace NetworkProtocols
{
	// Token: 0x02000500 RID: 1280
	public class SkullsCredit : BaseAwardEntry
	{
		// Token: 0x06002C98 RID: 11416 RVA: 0x00017B26 File Offset: 0x00015D26
		public SkullsCredit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 429512362u;
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x00017B3F File Offset: 0x00015D3F
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00017B47 File Offset: 0x00015D47
		public bool IsRefund { get; set; }

		// Token: 0x06002C9B RID: 11419 RVA: 0x000FE238 File Offset: 0x000FC438
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteBoolean(ref newArray, ref num, this.IsRefund);
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

		// Token: 0x06002C9C RID: 11420 RVA: 0x000FE298 File Offset: 0x000FC498
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.IsRefund = ArrayManager.ReadBoolean(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00017B50 File Offset: 0x00015D50
		private void InitRefTypes()
		{
			this.IsRefund = false;
		}
	}
}
