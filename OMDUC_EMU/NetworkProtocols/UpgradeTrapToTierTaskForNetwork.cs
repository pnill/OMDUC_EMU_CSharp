using System;

namespace NetworkProtocols
{
	// Token: 0x020005CE RID: 1486
	public class UpgradeTrapToTierTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033CB RID: 13259 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		public UpgradeTrapToTierTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 359492791u;
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x0001C005 File Offset: 0x0001A205
		// (set) Token: 0x060033CD RID: 13261 RVA: 0x0001C00D File Offset: 0x0001A20D
		public uint Denominator { get; set; }

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x0001C016 File Offset: 0x0001A216
		// (set) Token: 0x060033CF RID: 13263 RVA: 0x0001C01E File Offset: 0x0001A21E
		public uint Numerator { get; set; }

		// Token: 0x060033D0 RID: 13264 RVA: 0x00106DEC File Offset: 0x00104FEC
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

		// Token: 0x060033D1 RID: 13265 RVA: 0x00106E5C File Offset: 0x0010505C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x0001C027 File Offset: 0x0001A227
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
