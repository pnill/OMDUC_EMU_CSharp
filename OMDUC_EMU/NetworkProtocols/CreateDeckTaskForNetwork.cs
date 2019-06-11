using System;

namespace NetworkProtocols
{
	// Token: 0x020005CC RID: 1484
	public class CreateDeckTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033BB RID: 13243 RVA: 0x0001BF56 File Offset: 0x0001A156
		public CreateDeckTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2900025004u;
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x0001BF6F File Offset: 0x0001A16F
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x0001BF77 File Offset: 0x0001A177
		public uint Denominator { get; set; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x0001BF80 File Offset: 0x0001A180
		// (set) Token: 0x060033BF RID: 13247 RVA: 0x0001BF88 File Offset: 0x0001A188
		public uint Numerator { get; set; }

		// Token: 0x060033C0 RID: 13248 RVA: 0x00106C74 File Offset: 0x00104E74
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

		// Token: 0x060033C1 RID: 13249 RVA: 0x00106CE4 File Offset: 0x00104EE4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x0001BF91 File Offset: 0x0001A191
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
