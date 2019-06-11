using System;

namespace NetworkProtocols
{
	// Token: 0x02000546 RID: 1350
	public class QuestAward : BaseAwardItem
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x000185D2 File Offset: 0x000167D2
		public QuestAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1474879194u;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000185EB File Offset: 0x000167EB
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x000185F3 File Offset: 0x000167F3
		public ulong QuestGUID { get; set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000185FC File Offset: 0x000167FC
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x00018604 File Offset: 0x00016804
		public ulong QuestDefinitionGUID { get; set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x0001860D File Offset: 0x0001680D
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00018615 File Offset: 0x00016815
		public Guid GameStateID { get; set; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x0001861E File Offset: 0x0001681E
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00018626 File Offset: 0x00016826
		public ulong BucketID { get; set; }

		// Token: 0x06002E05 RID: 11781 RVA: 0x000FF33C File Offset: 0x000FD53C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.QuestGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.QuestDefinitionGUID);
			ArrayManager.WriteGuid(ref newArray, ref num, this.GameStateID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
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

		// Token: 0x06002E06 RID: 11782 RVA: 0x000FF3C8 File Offset: 0x000FD5C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.QuestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.QuestDefinitionGUID = ArrayManager.ReadUInt64(data, ref num);
			this.GameStateID = ArrayManager.ReadGuid(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000FF430 File Offset: 0x000FD630
		private void InitRefTypes()
		{
			this.QuestGUID = 0UL;
			this.QuestDefinitionGUID = 0UL;
			this.GameStateID = default(Guid);
			this.BucketID = 0UL;
		}
	}
}
