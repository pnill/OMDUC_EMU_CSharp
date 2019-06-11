using System;

namespace NetworkProtocols
{
	// Token: 0x02000550 RID: 1360
	public class ReferralMessageItemAward : BaseAwardItem
	{
		// Token: 0x06002E60 RID: 11872 RVA: 0x0001896D File Offset: 0x00016B6D
		public ReferralMessageItemAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 107549860u;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00018986 File Offset: 0x00016B86
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x0001898E File Offset: 0x00016B8E
		public ulong ReferralID { get; set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x00018997 File Offset: 0x00016B97
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x0001899F File Offset: 0x00016B9F
		public Guid GameStateID { get; set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000189A8 File Offset: 0x00016BA8
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x000189B0 File Offset: 0x00016BB0
		public eReferralRewardEventType EventType { get; set; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000189B9 File Offset: 0x00016BB9
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x000189C1 File Offset: 0x00016BC1
		public uint EventCount { get; set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000189CA File Offset: 0x00016BCA
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x000189D2 File Offset: 0x00016BD2
		public ulong BucketID { get; set; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x000189DB File Offset: 0x00016BDB
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x000189E3 File Offset: 0x00016BE3
		public ulong AccountSUID { get; set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x000189EC File Offset: 0x00016BEC
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x000189F4 File Offset: 0x00016BF4
		public string ReferralName { get; set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x000189FD File Offset: 0x00016BFD
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x00018A05 File Offset: 0x00016C05
		public ulong PlayerMessageID { get; set; }

		// Token: 0x06002E71 RID: 11889 RVA: 0x000FFC38 File Offset: 0x000FDE38
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.ReferralID);
			ArrayManager.WriteGuid(ref newArray, ref num, this.GameStateID);
			ArrayManager.WriteeReferralRewardEventType(ref newArray, ref num, this.EventType);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.EventCount);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref num, this.ReferralName);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.PlayerMessageID);
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

		// Token: 0x06002E72 RID: 11890 RVA: 0x000FFD00 File Offset: 0x000FDF00
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ReferralID = ArrayManager.ReadUInt64(data, ref num);
			this.GameStateID = ArrayManager.ReadGuid(data, ref num);
			this.EventType = ArrayManager.ReadeReferralRewardEventType(data, ref num);
			this.EventCount = ArrayManager.ReadUInt32(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.ReferralName = ArrayManager.ReadString(data, ref num);
			this.PlayerMessageID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000FFDA0 File Offset: 0x000FDFA0
		private void InitRefTypes()
		{
			this.ReferralID = 0UL;
			this.GameStateID = default(Guid);
			this.EventType = eReferralRewardEventType.None;
			this.EventCount = 0u;
			this.BucketID = 0UL;
			this.AccountSUID = 0UL;
			this.ReferralName = string.Empty;
			this.PlayerMessageID = 0UL;
		}
	}
}
