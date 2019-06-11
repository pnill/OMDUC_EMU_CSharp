using System;

namespace NetworkProtocols
{
	// Token: 0x020005EF RID: 1519
	public class TotalDamageDealtTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034DD RID: 13533 RVA: 0x0001CA13 File Offset: 0x0001AC13
		public TotalDamageDealtTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4180579639u;
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x0001CA34 File Offset: 0x0001AC34
		public uint Denominator { get; set; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x0001CA3D File Offset: 0x0001AC3D
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x0001CA45 File Offset: 0x0001AC45
		public uint Numerator { get; set; }

		// Token: 0x060034E2 RID: 13538 RVA: 0x001086B4 File Offset: 0x001068B4
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

		// Token: 0x060034E3 RID: 13539 RVA: 0x00108724 File Offset: 0x00106924
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0001CA4E File Offset: 0x0001AC4E
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
