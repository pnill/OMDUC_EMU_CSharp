using System;

namespace NetworkProtocols
{
	// Token: 0x0200050F RID: 1295
	public class ItemAward : BaseAwardEntry
	{
		// Token: 0x06002CDE RID: 11486 RVA: 0x00017D1F File Offset: 0x00015F1F
		public ItemAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1551808416u;
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x00017D38 File Offset: 0x00015F38
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x00017D40 File Offset: 0x00015F40
		public ulong AwardInventoryGUID { get; set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x00017D49 File Offset: 0x00015F49
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x00017D51 File Offset: 0x00015F51
		public uint TrapStrength { get; set; }

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000FE4C8 File Offset: 0x000FC6C8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AwardInventoryGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.TrapStrength);
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

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000FE538 File Offset: 0x000FC738
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AwardInventoryGUID = ArrayManager.ReadUInt64(data, ref num);
			this.TrapStrength = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00017D5A File Offset: 0x00015F5A
		private void InitRefTypes()
		{
			this.AwardInventoryGUID = 0UL;
			this.TrapStrength = 0u;
		}
	}
}
