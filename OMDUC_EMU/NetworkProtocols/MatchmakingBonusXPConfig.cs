using System;

namespace NetworkProtocols
{
	// Token: 0x020005AF RID: 1455
	public class MatchmakingBonusXPConfig
	{
		// Token: 0x0600329B RID: 12955 RVA: 0x0001B3E7 File Offset: 0x000195E7
		public MatchmakingBonusXPConfig()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x0001B3F5 File Offset: 0x000195F5
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x0001B3FD File Offset: 0x000195FD
		public eGameType GameType { get; set; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x0001B406 File Offset: 0x00019606
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x0001B40E File Offset: 0x0001960E
		public int BonusPercent { get; set; }

		// Token: 0x060032A0 RID: 12960 RVA: 0x0010560C File Offset: 0x0010380C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.BonusPercent);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00105648 File Offset: 0x00103848
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.BonusPercent = ArrayManager.ReadInt32(data, ref num);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x0001B417 File Offset: 0x00019617
		private void InitRefTypes()
		{
			this.GameType = eGameType.None;
			this.BonusPercent = 0;
		}
	}
}
