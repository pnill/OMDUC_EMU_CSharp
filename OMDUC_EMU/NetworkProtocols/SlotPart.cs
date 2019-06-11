using System;

namespace NetworkProtocols
{
	// Token: 0x020004FB RID: 1275
	public class SlotPart : BaseAwardEntry
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x00017991 File Offset: 0x00015B91
		public SlotPart()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3474257593u;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x000179AA File Offset: 0x00015BAA
		// (set) Token: 0x06002C70 RID: 11376 RVA: 0x000179B2 File Offset: 0x00015BB2
		public ulong TrapItemGUID { get; set; }

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000179BB File Offset: 0x00015BBB
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x000179C3 File Offset: 0x00015BC3
		public ulong NewPartToSlotItemGUID { get; set; }

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000179CC File Offset: 0x00015BCC
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x000179D4 File Offset: 0x00015BD4
		public ulong AlreadySlottedPartItemGUID { get; set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x000179DD File Offset: 0x00015BDD
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x000179E5 File Offset: 0x00015BE5
		public uint SlotNumber { get; set; }

		// Token: 0x06002C77 RID: 11383 RVA: 0x000FDE7C File Offset: 0x000FC07C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.TrapItemGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.NewPartToSlotItemGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AlreadySlottedPartItemGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.SlotNumber);
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

		// Token: 0x06002C78 RID: 11384 RVA: 0x000FDF08 File Offset: 0x000FC108
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.TrapItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.NewPartToSlotItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.AlreadySlottedPartItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.SlotNumber = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x000179EE File Offset: 0x00015BEE
		private void InitRefTypes()
		{
			this.TrapItemGUID = 0UL;
			this.NewPartToSlotItemGUID = 0UL;
			this.AlreadySlottedPartItemGUID = 0UL;
			this.SlotNumber = 0u;
		}
	}
}
