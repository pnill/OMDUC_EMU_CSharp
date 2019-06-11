using System;

namespace NetworkProtocols
{
	// Token: 0x0200053E RID: 1342
	public class HeroWinAward : BaseAwardItem
	{
		// Token: 0x06002DC4 RID: 11716 RVA: 0x000183D0 File Offset: 0x000165D0
		public HeroWinAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3822341622u;
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000183E9 File Offset: 0x000165E9
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x000183F1 File Offset: 0x000165F1
		public ulong HeroGUID { get; set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000183FA File Offset: 0x000165FA
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00018402 File Offset: 0x00016602
		public ulong MapGUID { get; set; }

		// Token: 0x06002DC9 RID: 11721 RVA: 0x000FEEE0 File Offset: 0x000FD0E0
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.HeroGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
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

		// Token: 0x06002DCA RID: 11722 RVA: 0x000FEF50 File Offset: 0x000FD150
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x0001840B File Offset: 0x0001660B
		private void InitRefTypes()
		{
			this.HeroGUID = 0UL;
			this.MapGUID = 0UL;
		}
	}
}
