using System;

namespace NetworkProtocols
{
	// Token: 0x020005CF RID: 1487
	public class UpgradeTrapTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033D3 RID: 13267 RVA: 0x0001C037 File Offset: 0x0001A237
		public UpgradeTrapTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 815326173u;
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x0001C050 File Offset: 0x0001A250
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x0001C058 File Offset: 0x0001A258
		public uint Denominator { get; set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x0001C061 File Offset: 0x0001A261
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x0001C069 File Offset: 0x0001A269
		public uint Numerator { get; set; }

		// Token: 0x060033D8 RID: 13272 RVA: 0x00106EA8 File Offset: 0x001050A8
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

		// Token: 0x060033D9 RID: 13273 RVA: 0x00106F18 File Offset: 0x00105118
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x0001C072 File Offset: 0x0001A272
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
