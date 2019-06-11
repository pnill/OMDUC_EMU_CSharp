using System;

namespace NetworkProtocols
{
	// Token: 0x0200055B RID: 1371
	public class KeystoneWinAward : BaseAwardItem
	{
		// Token: 0x06002EA0 RID: 11936 RVA: 0x00018B3C File Offset: 0x00016D3C
		public KeystoneWinAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1771139669u;
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00018B55 File Offset: 0x00016D55
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x00018B5D File Offset: 0x00016D5D
		public ulong KeystoneID { get; set; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00018B66 File Offset: 0x00016D66
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x00018B6E File Offset: 0x00016D6E
		public ulong BucketID { get; set; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00018B77 File Offset: 0x00016D77
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x00018B7F File Offset: 0x00016D7F
		public int Level { get; set; }

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000FFF30 File Offset: 0x000FE130
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.Level);
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

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000FFFB0 File Offset: 0x000FE1B0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00018B88 File Offset: 0x00016D88
		private void InitRefTypes()
		{
			this.KeystoneID = 0UL;
			this.BucketID = 0UL;
			this.Level = 0;
		}
	}
}
