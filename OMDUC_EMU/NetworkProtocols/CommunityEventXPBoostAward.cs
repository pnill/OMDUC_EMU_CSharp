using System;

namespace NetworkProtocols
{
	// Token: 0x02000508 RID: 1288
	public class CommunityEventXPBoostAward : BaseAwardEntry
	{
		// Token: 0x06002CC0 RID: 11456 RVA: 0x00017C55 File Offset: 0x00015E55
		public CommunityEventXPBoostAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2452211831u;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x00017C6E File Offset: 0x00015E6E
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x00017C76 File Offset: 0x00015E76
		public ulong EventBoostID { get; set; }

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000FE42C File Offset: 0x000FC62C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventBoostID);
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

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000FE48C File Offset: 0x000FC68C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventBoostID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00017C7F File Offset: 0x00015E7F
		private void InitRefTypes()
		{
			this.EventBoostID = 0UL;
		}
	}
}
