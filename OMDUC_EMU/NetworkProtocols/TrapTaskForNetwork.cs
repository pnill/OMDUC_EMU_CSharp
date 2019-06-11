using System;

namespace NetworkProtocols
{
	// Token: 0x020005F2 RID: 1522
	public class TrapTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034F5 RID: 13557 RVA: 0x0001CAF4 File Offset: 0x0001ACF4
		public TrapTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3638388537u;
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0001CB0D File Offset: 0x0001AD0D
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x0001CB15 File Offset: 0x0001AD15
		public uint Denominator { get; set; }

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x0001CB1E File Offset: 0x0001AD1E
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x0001CB26 File Offset: 0x0001AD26
		public uint Numerator { get; set; }

		// Token: 0x060034FA RID: 13562 RVA: 0x001088E8 File Offset: 0x00106AE8
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

		// Token: 0x060034FB RID: 13563 RVA: 0x00108958 File Offset: 0x00106B58
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x0001CB2F File Offset: 0x0001AD2F
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
