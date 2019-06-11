using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000651 RID: 1617
	public class PacketChallenge
	{
		// Token: 0x06003862 RID: 14434 RVA: 0x0001F099 File Offset: 0x0001D299
		public PacketChallenge()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x0001F0A7 File Offset: 0x0001D2A7
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x0001F0AF File Offset: 0x0001D2AF
		public ulong ChallengeID { get; set; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
		public ulong GameMapID { get; set; }

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0001F0C9 File Offset: 0x0001D2C9
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0001F0D1 File Offset: 0x0001D2D1
		public List<ulong> AllowedHeroes { get; set; }

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0001F0DA File Offset: 0x0001D2DA
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x0001F0E2 File Offset: 0x0001D2E2
		public PacketDeckContents Deck { get; set; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0001F0EB File Offset: 0x0001D2EB
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0001F0F3 File Offset: 0x0001D2F3
		public DateTime ChallengeStartDate { get; set; }

		// Token: 0x0600386D RID: 14445 RVA: 0x0010DE18 File Offset: 0x0010C018
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChallengeID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.AllowedHeroes);
			ArrayManager.WritePacketDeckContents(ref newArray, ref newSize, this.Deck);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.ChallengeStartDate);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x0010DE84 File Offset: 0x0010C084
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ChallengeID = ArrayManager.ReadUInt64(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.AllowedHeroes = ArrayManager.ReadListUInt64(data, ref num);
			this.Deck = ArrayManager.ReadPacketDeckContents(data, ref num);
			this.ChallengeStartDate = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x0010DEDC File Offset: 0x0010C0DC
		private void InitRefTypes()
		{
			this.ChallengeID = 0UL;
			this.GameMapID = 0UL;
			this.AllowedHeroes = new List<ulong>();
			this.Deck = new PacketDeckContents();
			this.ChallengeStartDate = default(DateTime);
		}
	}
}
