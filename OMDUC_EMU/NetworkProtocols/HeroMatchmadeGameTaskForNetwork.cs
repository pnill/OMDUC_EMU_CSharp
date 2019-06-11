using System;

namespace NetworkProtocols
{
	// Token: 0x020005EB RID: 1515
	public class HeroMatchmadeGameTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034B7 RID: 13495 RVA: 0x0001C89D File Offset: 0x0001AA9D
		public HeroMatchmadeGameTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3961090072u;
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x0001C8B6 File Offset: 0x0001AAB6
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0001C8BE File Offset: 0x0001AABE
		public ulong HeroGUID { get; set; }

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x0001C8C7 File Offset: 0x0001AAC7
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x0001C8CF File Offset: 0x0001AACF
		public uint Denominator { get; set; }

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
		public uint Numerator { get; set; }

		// Token: 0x060034BE RID: 13502 RVA: 0x00108370 File Offset: 0x00106570
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.HeroGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Denominator);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Numerator);
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

		// Token: 0x060034BF RID: 13503 RVA: 0x001083F0 File Offset: 0x001065F0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0001C8E9 File Offset: 0x0001AAE9
		private void InitRefTypes()
		{
			this.HeroGUID = 0UL;
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
