using System;

namespace NetworkProtocols
{
	// Token: 0x02000540 RID: 1344
	public class KeystoneAward : BaseAwardItem
	{
		// Token: 0x06002DD0 RID: 11728 RVA: 0x00018436 File Offset: 0x00016636
		public KeystoneAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3613154846u;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x0001844F File Offset: 0x0001664F
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x00018457 File Offset: 0x00016657
		public ulong KeystoneDetailID { get; set; }

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000FEF9C File Offset: 0x000FD19C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneDetailID);
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

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000FEFFC File Offset: 0x000FD1FC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneDetailID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00018460 File Offset: 0x00016660
		private void InitRefTypes()
		{
			this.KeystoneDetailID = 0UL;
		}
	}
}
