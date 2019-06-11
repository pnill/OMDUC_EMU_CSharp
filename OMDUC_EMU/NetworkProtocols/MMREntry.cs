using System;

namespace NetworkProtocols
{
	// Token: 0x02000571 RID: 1393
	public class MMREntry
	{
		// Token: 0x06002F9D RID: 12189 RVA: 0x000194FC File Offset: 0x000176FC
		public MMREntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x0001950A File Offset: 0x0001770A
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x00019512 File Offset: 0x00017712
		public eGameType GameType { get; set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x0001951B File Offset: 0x0001771B
		// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x00019523 File Offset: 0x00017723
		public double MMR { get; set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x0001952C File Offset: 0x0001772C
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x00019534 File Offset: 0x00017734
		public bool IsRanked { get; set; }

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00101378 File Offset: 0x000FF578
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteDouble(ref newArray, ref newSize, this.MMR);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRanked);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x001013C4 File Offset: 0x000FF5C4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.MMR = ArrayManager.ReadDouble(data, ref num);
			this.IsRanked = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x0001953D File Offset: 0x0001773D
		private void InitRefTypes()
		{
			this.GameType = eGameType.None;
			this.MMR = 0.0;
			this.IsRanked = false;
		}
	}
}
