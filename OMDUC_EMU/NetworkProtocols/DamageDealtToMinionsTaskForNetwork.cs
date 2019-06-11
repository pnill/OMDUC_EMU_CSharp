using System;

namespace NetworkProtocols
{
	// Token: 0x020005F1 RID: 1521
	public class DamageDealtToMinionsTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034ED RID: 13549 RVA: 0x0001CAA9 File Offset: 0x0001ACA9
		public DamageDealtToMinionsTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3075552689u;
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x0001CAC2 File Offset: 0x0001ACC2
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x0001CACA File Offset: 0x0001ACCA
		public uint Denominator { get; set; }

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x0001CAD3 File Offset: 0x0001ACD3
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x0001CADB File Offset: 0x0001ACDB
		public uint Numerator { get; set; }

		// Token: 0x060034F2 RID: 13554 RVA: 0x0010882C File Offset: 0x00106A2C
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

		// Token: 0x060034F3 RID: 13555 RVA: 0x0010889C File Offset: 0x00106A9C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
