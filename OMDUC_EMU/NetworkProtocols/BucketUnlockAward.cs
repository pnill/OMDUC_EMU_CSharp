using System;

namespace NetworkProtocols
{
	// Token: 0x02000558 RID: 1368
	public class BucketUnlockAward : BaseAwardItem
	{
		// Token: 0x06002E92 RID: 11922 RVA: 0x00018AD7 File Offset: 0x00016CD7
		public BucketUnlockAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1628633092u;
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x00018AF0 File Offset: 0x00016CF0
		// (set) Token: 0x06002E94 RID: 11924 RVA: 0x00018AF8 File Offset: 0x00016CF8
		public uint BucketID { get; set; }

		// Token: 0x06002E95 RID: 11925 RVA: 0x000FFE94 File Offset: 0x000FE094
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.BucketID);
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

		// Token: 0x06002E96 RID: 11926 RVA: 0x000FFEF4 File Offset: 0x000FE0F4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BucketID = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00018B01 File Offset: 0x00016D01
		private void InitRefTypes()
		{
			this.BucketID = 0u;
		}
	}
}
