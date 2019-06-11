using System;

namespace NetworkProtocols
{
	// Token: 0x0200054C RID: 1356
	public class StarAwards : BaseAwardItem
	{
		// Token: 0x06002E32 RID: 11826 RVA: 0x000187B7 File Offset: 0x000169B7
		public StarAwards()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3906265512u;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x000187D0 File Offset: 0x000169D0
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x000187D8 File Offset: 0x000169D8
		public Guid GameStateID { get; set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x000187E1 File Offset: 0x000169E1
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x000187E9 File Offset: 0x000169E9
		public ulong GameMapID { get; set; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x000187F2 File Offset: 0x000169F2
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x000187FA File Offset: 0x000169FA
		public eGameType GameType { get; set; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00018803 File Offset: 0x00016A03
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x0001880B File Offset: 0x00016A0B
		public ulong BucketID { get; set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00018814 File Offset: 0x00016A14
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x0001881C File Offset: 0x00016A1C
		public uint EarnedStars { get; set; }

		// Token: 0x06002E3D RID: 11837 RVA: 0x000FF848 File Offset: 0x000FDA48
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteGuid(ref newArray, ref num, this.GameStateID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GameMapID);
			ArrayManager.WriteeGameType(ref newArray, ref num, this.GameType);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.EarnedStars);
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

		// Token: 0x06002E3E RID: 11838 RVA: 0x000FF8E4 File Offset: 0x000FDAE4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameStateID = ArrayManager.ReadGuid(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.EarnedStars = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000FF958 File Offset: 0x000FDB58
		private void InitRefTypes()
		{
			this.GameStateID = default(Guid);
			this.GameMapID = 0UL;
			this.GameType = eGameType.None;
			this.BucketID = 0UL;
			this.EarnedStars = 0u;
		}
	}
}
