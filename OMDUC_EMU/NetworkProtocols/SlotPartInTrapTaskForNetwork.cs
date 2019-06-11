using System;

namespace NetworkProtocols
{
	// Token: 0x020005CD RID: 1485
	public class SlotPartInTrapTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033C3 RID: 13251 RVA: 0x0001BFA1 File Offset: 0x0001A1A1
		public SlotPartInTrapTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2425471205u;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060033C4 RID: 13252 RVA: 0x0001BFBA File Offset: 0x0001A1BA
		// (set) Token: 0x060033C5 RID: 13253 RVA: 0x0001BFC2 File Offset: 0x0001A1C2
		public uint Denominator { get; set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x0001BFCB File Offset: 0x0001A1CB
		// (set) Token: 0x060033C7 RID: 13255 RVA: 0x0001BFD3 File Offset: 0x0001A1D3
		public uint Numerator { get; set; }

		// Token: 0x060033C8 RID: 13256 RVA: 0x00106D30 File Offset: 0x00104F30
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

		// Token: 0x060033C9 RID: 13257 RVA: 0x00106DA0 File Offset: 0x00104FA0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
