using System;

namespace NetworkProtocols
{
	// Token: 0x02000753 RID: 1875
	public class AccountPlayerProfile
	{
		// Token: 0x06004291 RID: 17041 RVA: 0x0002630A File Offset: 0x0002450A
		public AccountPlayerProfile()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x00026318 File Offset: 0x00024518
		// (set) Token: 0x06004293 RID: 17043 RVA: 0x00026320 File Offset: 0x00024520
		public ulong AccountSUID { get; set; }

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x00026329 File Offset: 0x00024529
		// (set) Token: 0x06004295 RID: 17045 RVA: 0x00026331 File Offset: 0x00024531
		public string Name { get; set; }

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x0002633A File Offset: 0x0002453A
		// (set) Token: 0x06004297 RID: 17047 RVA: 0x00026342 File Offset: 0x00024542
		public uint AccountLevel { get; set; }

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x0002634B File Offset: 0x0002454B
		// (set) Token: 0x06004299 RID: 17049 RVA: 0x00026353 File Offset: 0x00024553
		public ulong AvatarKey { get; set; }

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600429A RID: 17050 RVA: 0x0002635C File Offset: 0x0002455C
		// (set) Token: 0x0600429B RID: 17051 RVA: 0x00026364 File Offset: 0x00024564
		public ulong Badge { get; set; }

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x0002636D File Offset: 0x0002456D
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x00026375 File Offset: 0x00024575
		public ulong Background { get; set; }

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x0002637E File Offset: 0x0002457E
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x00026386 File Offset: 0x00024586
		public ulong Title { get; set; }

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0002638F File Offset: 0x0002458F
		// (set) Token: 0x060042A1 RID: 17057 RVA: 0x00026397 File Offset: 0x00024597
		public ulong SiegeWins { get; set; }

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x000263A0 File Offset: 0x000245A0
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x000263A8 File Offset: 0x000245A8
		public ulong SurvivalWins { get; set; }

		// Token: 0x060042A4 RID: 17060 RVA: 0x001209C0 File Offset: 0x0011EBC0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.AccountLevel);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AvatarKey);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Badge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Background);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SiegeWins);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SurvivalWins);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00120A68 File Offset: 0x0011EC68
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.AccountLevel = ArrayManager.ReadUInt32(data, ref num);
			this.AvatarKey = ArrayManager.ReadUInt64(data, ref num);
			this.Badge = ArrayManager.ReadUInt64(data, ref num);
			this.Background = ArrayManager.ReadUInt64(data, ref num);
			this.Title = ArrayManager.ReadUInt64(data, ref num);
			this.SiegeWins = ArrayManager.ReadUInt64(data, ref num);
			this.SurvivalWins = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x00120AF8 File Offset: 0x0011ECF8
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Name = string.Empty;
			this.AccountLevel = 0u;
			this.AvatarKey = 0UL;
			this.Badge = 0UL;
			this.Background = 0UL;
			this.Title = 0UL;
			this.SiegeWins = 0UL;
			this.SurvivalWins = 0UL;
		}
	}
}
