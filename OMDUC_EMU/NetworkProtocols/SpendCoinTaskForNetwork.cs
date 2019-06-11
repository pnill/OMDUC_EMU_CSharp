using System;

namespace NetworkProtocols
{
	// Token: 0x020005E3 RID: 1507
	public class SpendCoinTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003473 RID: 13427 RVA: 0x0001C613 File Offset: 0x0001A813
		public SpendCoinTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 510617338u;
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x0001C62C File Offset: 0x0001A82C
		// (set) Token: 0x06003475 RID: 13429 RVA: 0x0001C634 File Offset: 0x0001A834
		public uint Denominator { get; set; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x0001C63D File Offset: 0x0001A83D
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x0001C645 File Offset: 0x0001A845
		public uint Numerator { get; set; }

		// Token: 0x06003478 RID: 13432 RVA: 0x00107D58 File Offset: 0x00105F58
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

		// Token: 0x06003479 RID: 13433 RVA: 0x00107DC8 File Offset: 0x00105FC8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x0001C64E File Offset: 0x0001A84E
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
