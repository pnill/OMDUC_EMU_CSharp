using System;

namespace NetworkProtocols
{
	// Token: 0x020005F3 RID: 1523
	public class ComboTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034FD RID: 13565 RVA: 0x0001CB3F File Offset: 0x0001AD3F
		public ComboTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3981696596u;
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x0001CB58 File Offset: 0x0001AD58
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x0001CB60 File Offset: 0x0001AD60
		public uint Denominator { get; set; }

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x0001CB69 File Offset: 0x0001AD69
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x0001CB71 File Offset: 0x0001AD71
		public uint Numerator { get; set; }

		// Token: 0x06003502 RID: 13570 RVA: 0x001089A4 File Offset: 0x00106BA4
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

		// Token: 0x06003503 RID: 13571 RVA: 0x00108A14 File Offset: 0x00106C14
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x0001CB7A File Offset: 0x0001AD7A
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
