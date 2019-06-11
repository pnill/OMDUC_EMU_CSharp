using System;

namespace NetworkProtocols
{
	// Token: 0x020005D3 RID: 1491
	public class WinGamesSoloTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033F3 RID: 13299 RVA: 0x0001C163 File Offset: 0x0001A363
		public WinGamesSoloTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1373468347u;
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060033F4 RID: 13300 RVA: 0x0001C17C File Offset: 0x0001A37C
		// (set) Token: 0x060033F5 RID: 13301 RVA: 0x0001C184 File Offset: 0x0001A384
		public uint Denominator { get; set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x0001C18D File Offset: 0x0001A38D
		// (set) Token: 0x060033F7 RID: 13303 RVA: 0x0001C195 File Offset: 0x0001A395
		public uint Numerator { get; set; }

		// Token: 0x060033F8 RID: 13304 RVA: 0x00107198 File Offset: 0x00105398
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

		// Token: 0x060033F9 RID: 13305 RVA: 0x00107208 File Offset: 0x00105408
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0001C19E File Offset: 0x0001A39E
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
