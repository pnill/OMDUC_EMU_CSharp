using System;

namespace NetworkProtocols
{
	// Token: 0x020005EA RID: 1514
	public class HeroTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034AD RID: 13485 RVA: 0x0001C839 File Offset: 0x0001AA39
		public HeroTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 37843363u;
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x0001C852 File Offset: 0x0001AA52
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x0001C85A File Offset: 0x0001AA5A
		public ulong HeroGUID { get; set; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x0001C863 File Offset: 0x0001AA63
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0001C86B File Offset: 0x0001AA6B
		public uint Denominator { get; set; }

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x0001C874 File Offset: 0x0001AA74
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x0001C87C File Offset: 0x0001AA7C
		public uint Numerator { get; set; }

		// Token: 0x060034B4 RID: 13492 RVA: 0x00108298 File Offset: 0x00106498
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

		// Token: 0x060034B5 RID: 13493 RVA: 0x00108318 File Offset: 0x00106518
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

		// Token: 0x060034B6 RID: 13494 RVA: 0x0001C885 File Offset: 0x0001AA85
		private void InitRefTypes()
		{
			this.HeroGUID = 0UL;
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
