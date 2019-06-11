using System;

namespace NetworkProtocols
{
	// Token: 0x020005DA RID: 1498
	public class TrapKillsTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600342B RID: 13355 RVA: 0x0001C370 File Offset: 0x0001A570
		public TrapKillsTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 372647321u;
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x0001C389 File Offset: 0x0001A589
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x0001C391 File Offset: 0x0001A591
		public uint Denominator { get; set; }

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x0001C39A File Offset: 0x0001A59A
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x0001C3A2 File Offset: 0x0001A5A2
		public uint Numerator { get; set; }

		// Token: 0x06003430 RID: 13360 RVA: 0x001076BC File Offset: 0x001058BC
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

		// Token: 0x06003431 RID: 13361 RVA: 0x0010772C File Offset: 0x0010592C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x0001C3AB File Offset: 0x0001A5AB
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
