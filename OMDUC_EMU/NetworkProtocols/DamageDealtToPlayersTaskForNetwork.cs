using System;

namespace NetworkProtocols
{
	// Token: 0x020005F0 RID: 1520
	public class DamageDealtToPlayersTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034E5 RID: 13541 RVA: 0x0001CA5E File Offset: 0x0001AC5E
		public DamageDealtToPlayersTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1643872712u;
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x0001CA77 File Offset: 0x0001AC77
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x0001CA7F File Offset: 0x0001AC7F
		public uint Denominator { get; set; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x0001CA88 File Offset: 0x0001AC88
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x0001CA90 File Offset: 0x0001AC90
		public uint Numerator { get; set; }

		// Token: 0x060034EA RID: 13546 RVA: 0x00108770 File Offset: 0x00106970
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x060034EB RID: 13547 RVA: 0x001087E0 File Offset: 0x001069E0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x0001CA99 File Offset: 0x0001AC99
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
