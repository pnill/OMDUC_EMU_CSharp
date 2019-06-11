using System;

namespace NetworkProtocols
{
	// Token: 0x02000577 RID: 1399
	public class PlayerHeroMapStat
	{
		// Token: 0x06003001 RID: 12289 RVA: 0x000198BB File Offset: 0x00017ABB
		public PlayerHeroMapStat()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x000198C9 File Offset: 0x00017AC9
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x000198D1 File Offset: 0x00017AD1
		public ulong MapGUID { get; set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000198DA File Offset: 0x00017ADA
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x000198E2 File Offset: 0x00017AE2
		public uint HighestStarsEarned { get; set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x000198EB File Offset: 0x00017AEB
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x000198F3 File Offset: 0x00017AF3
		public bool IsWinner { get; set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x000198FC File Offset: 0x00017AFC
		// (set) Token: 0x06003009 RID: 12297 RVA: 0x00019904 File Offset: 0x00017B04
		public DateTime PlayedOn { get; set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x0001990D File Offset: 0x00017B0D
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x00019915 File Offset: 0x00017B15
		public uint GameTimeSeconds { get; set; }

		// Token: 0x0600300C RID: 12300 RVA: 0x00101C2C File Offset: 0x000FFE2C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.HighestStarsEarned);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsWinner);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.PlayedOn);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.GameTimeSeconds);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00101C98 File Offset: 0x000FFE98
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.HighestStarsEarned = ArrayManager.ReadUInt32(data, ref num);
			this.IsWinner = ArrayManager.ReadBoolean(data, ref num);
			this.PlayedOn = ArrayManager.ReadDateTime(data, ref num);
			this.GameTimeSeconds = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x00101CF0 File Offset: 0x000FFEF0
		private void InitRefTypes()
		{
			this.MapGUID = 0UL;
			this.HighestStarsEarned = 0u;
			this.IsWinner = false;
			this.PlayedOn = default(DateTime);
			this.GameTimeSeconds = 0u;
		}
	}
}
