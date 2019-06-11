using System;

namespace NetworkProtocols
{
	// Token: 0x020004E3 RID: 1251
	public class LevelProgress
	{
		// Token: 0x06002B54 RID: 11092 RVA: 0x00016DD9 File Offset: 0x00014FD9
		public LevelProgress()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x00016DE7 File Offset: 0x00014FE7
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x00016DEF File Offset: 0x00014FEF
		public uint CurrentLevel { get; set; }

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x00016DF8 File Offset: 0x00014FF8
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x00016E00 File Offset: 0x00015000
		public LevelProgressAward AwardItem { get; set; }

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x00016E09 File Offset: 0x00015009
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x00016E11 File Offset: 0x00015011
		public bool MaxLevel { get; set; }

		// Token: 0x06002B5B RID: 11099 RVA: 0x000FC7B0 File Offset: 0x000FA9B0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.CurrentLevel);
			ArrayManager.WriteLevelProgressAward(ref newArray, ref newSize, this.AwardItem);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.MaxLevel);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000FC7FC File Offset: 0x000FA9FC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.CurrentLevel = ArrayManager.ReadUInt32(data, ref num);
			this.AwardItem = ArrayManager.ReadLevelProgressAward(data, ref num);
			this.MaxLevel = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00016E1A File Offset: 0x0001501A
		private void InitRefTypes()
		{
			this.CurrentLevel = 0u;
			this.AwardItem = new LevelProgressAward();
			this.MaxLevel = false;
		}
	}
}
