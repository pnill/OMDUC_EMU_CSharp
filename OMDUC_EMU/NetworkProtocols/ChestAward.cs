using System;

namespace NetworkProtocols
{
	// Token: 0x020004FF RID: 1279
	public class ChestAward : BaseAwardEntry
	{
		// Token: 0x06002C92 RID: 11410 RVA: 0x00017AF2 File Offset: 0x00015CF2
		public ChestAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 691808809u;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x00017B0B File Offset: 0x00015D0B
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00017B13 File Offset: 0x00015D13
		public ulong EventChestGUID { get; set; }

		// Token: 0x06002C95 RID: 11413 RVA: 0x000FE19C File Offset: 0x000FC39C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestGUID);
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

		// Token: 0x06002C96 RID: 11414 RVA: 0x000FE1FC File Offset: 0x000FC3FC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00017B1C File Offset: 0x00015D1C
		private void InitRefTypes()
		{
			this.EventChestGUID = 0UL;
		}
	}
}
