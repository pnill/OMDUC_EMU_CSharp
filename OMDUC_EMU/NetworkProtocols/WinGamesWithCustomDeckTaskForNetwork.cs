using System;

namespace NetworkProtocols
{
	// Token: 0x020005CB RID: 1483
	public class WinGamesWithCustomDeckTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033B3 RID: 13235 RVA: 0x0001BF0B File Offset: 0x0001A10B
		public WinGamesWithCustomDeckTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3803304233u;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x0001BF24 File Offset: 0x0001A124
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x0001BF2C File Offset: 0x0001A12C
		public uint Denominator { get; set; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x0001BF35 File Offset: 0x0001A135
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x0001BF3D File Offset: 0x0001A13D
		public uint Numerator { get; set; }

		// Token: 0x060033B8 RID: 13240 RVA: 0x00106BB8 File Offset: 0x00104DB8
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

		// Token: 0x060033B9 RID: 13241 RVA: 0x00106C28 File Offset: 0x00104E28
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x0001BF46 File Offset: 0x0001A146
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
