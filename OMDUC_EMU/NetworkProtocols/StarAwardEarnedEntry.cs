using System;

namespace NetworkProtocols
{
	// Token: 0x0200061E RID: 1566
	public class StarAwardEarnedEntry
	{
		// Token: 0x0600369C RID: 13980 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
		public StarAwardEarnedEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x0001DDF2 File Offset: 0x0001BFF2
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x0001DDFA File Offset: 0x0001BFFA
		public ulong GameMapID { get; set; }

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x0001DE03 File Offset: 0x0001C003
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x0001DE0B File Offset: 0x0001C00B
		public int StarAwardsEarned { get; set; }

		// Token: 0x060036A1 RID: 13985 RVA: 0x0010B424 File Offset: 0x00109624
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.StarAwardsEarned);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0010B460 File Offset: 0x00109660
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.StarAwardsEarned = ArrayManager.ReadInt32(data, ref num);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0001DE14 File Offset: 0x0001C014
		private void InitRefTypes()
		{
			this.GameMapID = 0UL;
			this.StarAwardsEarned = 0;
		}
	}
}
