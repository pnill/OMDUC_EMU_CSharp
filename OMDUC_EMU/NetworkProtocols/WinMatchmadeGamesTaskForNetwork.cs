using System;

namespace NetworkProtocols
{
	// Token: 0x020005D2 RID: 1490
	public class WinMatchmadeGamesTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033EB RID: 13291 RVA: 0x0001C118 File Offset: 0x0001A318
		public WinMatchmadeGamesTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2902557865u;
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x0001C131 File Offset: 0x0001A331
		// (set) Token: 0x060033ED RID: 13293 RVA: 0x0001C139 File Offset: 0x0001A339
		public uint Denominator { get; set; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x0001C142 File Offset: 0x0001A342
		// (set) Token: 0x060033EF RID: 13295 RVA: 0x0001C14A File Offset: 0x0001A34A
		public uint Numerator { get; set; }

		// Token: 0x060033F0 RID: 13296 RVA: 0x001070DC File Offset: 0x001052DC
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

		// Token: 0x060033F1 RID: 13297 RVA: 0x0010714C File Offset: 0x0010534C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x0001C153 File Offset: 0x0001A353
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
