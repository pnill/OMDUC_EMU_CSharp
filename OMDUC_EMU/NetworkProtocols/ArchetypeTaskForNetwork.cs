using System;

namespace NetworkProtocols
{
	// Token: 0x020005C8 RID: 1480
	public class ArchetypeTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600339B RID: 13211 RVA: 0x0001BE2A File Offset: 0x0001A02A
		public ArchetypeTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3189879827u;
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x0001BE43 File Offset: 0x0001A043
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x0001BE4B File Offset: 0x0001A04B
		public uint Denominator { get; set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x0001BE54 File Offset: 0x0001A054
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x0001BE5C File Offset: 0x0001A05C
		public uint Numerator { get; set; }

		// Token: 0x060033A0 RID: 13216 RVA: 0x00106984 File Offset: 0x00104B84
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

		// Token: 0x060033A1 RID: 13217 RVA: 0x001069F4 File Offset: 0x00104BF4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x0001BE65 File Offset: 0x0001A065
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
