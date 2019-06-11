using System;

namespace NetworkProtocols
{
	// Token: 0x020005E9 RID: 1513
	public class MapTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034A3 RID: 13475 RVA: 0x0001C7D5 File Offset: 0x0001A9D5
		public MapTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 383728357u;
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x0001C7EE File Offset: 0x0001A9EE
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x0001C7F6 File Offset: 0x0001A9F6
		public ulong MapGUID { get; set; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x0001C7FF File Offset: 0x0001A9FF
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x0001C807 File Offset: 0x0001AA07
		public uint Denominator { get; set; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x0001C810 File Offset: 0x0001AA10
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x0001C818 File Offset: 0x0001AA18
		public uint Numerator { get; set; }

		// Token: 0x060034AA RID: 13482 RVA: 0x001081C0 File Offset: 0x001063C0
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
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

		// Token: 0x060034AB RID: 13483 RVA: 0x00108240 File Offset: 0x00106440
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x0001C821 File Offset: 0x0001AA21
		private void InitRefTypes()
		{
			this.MapGUID = 0UL;
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
