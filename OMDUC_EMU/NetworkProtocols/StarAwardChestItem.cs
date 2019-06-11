using System;

namespace NetworkProtocols
{
	// Token: 0x0200054D RID: 1357
	public class StarAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002E40 RID: 11840 RVA: 0x00018825 File Offset: 0x00016A25
		public StarAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3278776342u;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0001883E File Offset: 0x00016A3E
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00018846 File Offset: 0x00016A46
		public ulong GameMapID { get; set; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x0001884F File Offset: 0x00016A4F
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00018857 File Offset: 0x00016A57
		public eGameType GameType { get; set; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x00018860 File Offset: 0x00016A60
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x00018868 File Offset: 0x00016A68
		public ulong BucketID { get; set; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x00018871 File Offset: 0x00016A71
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x00018879 File Offset: 0x00016A79
		public uint EarnedStars { get; set; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x00018882 File Offset: 0x00016A82
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x0001888A File Offset: 0x00016A8A
		public ulong EventChestGUID { get; set; }

		// Token: 0x06002E4B RID: 11851 RVA: 0x000FF994 File Offset: 0x000FDB94
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GameMapID);
			ArrayManager.WriteeGameType(ref newArray, ref num, this.GameType);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.EarnedStars);
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

		// Token: 0x06002E4C RID: 11852 RVA: 0x000FFA30 File Offset: 0x000FDC30
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.EarnedStars = ArrayManager.ReadUInt32(data, ref num);
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00018893 File Offset: 0x00016A93
		private void InitRefTypes()
		{
			this.GameMapID = 0UL;
			this.GameType = eGameType.None;
			this.BucketID = 0UL;
			this.EarnedStars = 0u;
			this.EventChestGUID = 0UL;
		}
	}
}
