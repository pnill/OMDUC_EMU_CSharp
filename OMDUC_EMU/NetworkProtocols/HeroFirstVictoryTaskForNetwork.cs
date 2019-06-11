using System;

namespace NetworkProtocols
{
	// Token: 0x020005C9 RID: 1481
	public class HeroFirstVictoryTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033A3 RID: 13219 RVA: 0x0001BE75 File Offset: 0x0001A075
		public HeroFirstVictoryTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 824711373u;
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x0001BE8E File Offset: 0x0001A08E
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x0001BE96 File Offset: 0x0001A096
		public uint Denominator { get; set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x0001BE9F File Offset: 0x0001A09F
		// (set) Token: 0x060033A7 RID: 13223 RVA: 0x0001BEA7 File Offset: 0x0001A0A7
		public uint Numerator { get; set; }

		// Token: 0x060033A8 RID: 13224 RVA: 0x00106A40 File Offset: 0x00104C40
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

		// Token: 0x060033A9 RID: 13225 RVA: 0x00106AB0 File Offset: 0x00104CB0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
