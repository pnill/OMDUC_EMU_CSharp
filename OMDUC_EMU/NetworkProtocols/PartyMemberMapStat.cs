using System;

namespace NetworkProtocols
{
	// Token: 0x020006FF RID: 1791
	public class PartyMemberMapStat
	{
		// Token: 0x06004003 RID: 16387 RVA: 0x00024530 File Offset: 0x00022730
		public PartyMemberMapStat()
		{
			this.InitRefTypes();
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x0002453E File Offset: 0x0002273E
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x00024546 File Offset: 0x00022746
		public ulong AccountSUID { get; set; }

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x0002454F File Offset: 0x0002274F
		// (set) Token: 0x06004007 RID: 16391 RVA: 0x00024557 File Offset: 0x00022757
		public uint HighestStarsEarned { get; set; }

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x00024560 File Offset: 0x00022760
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x00024568 File Offset: 0x00022768
		public MMREntry SabotageMMR { get; set; }

		// Token: 0x0600400A RID: 16394 RVA: 0x0011C83C File Offset: 0x0011AA3C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.HighestStarsEarned);
			ArrayManager.WriteMMREntry(ref newArray, ref newSize, this.SabotageMMR);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x0011C888 File Offset: 0x0011AA88
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.HighestStarsEarned = ArrayManager.ReadUInt32(data, ref num);
			this.SabotageMMR = ArrayManager.ReadMMREntry(data, ref num);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00024571 File Offset: 0x00022771
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.HighestStarsEarned = 0u;
			this.SabotageMMR = new MMREntry();
		}
	}
}
