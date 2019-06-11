using System;

namespace NetworkProtocols
{
	// Token: 0x020005DC RID: 1500
	public class BattleLevelTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600343B RID: 13371 RVA: 0x0001C406 File Offset: 0x0001A606
		public BattleLevelTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1386190342u;
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x0001C41F File Offset: 0x0001A61F
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x0001C427 File Offset: 0x0001A627
		public uint Denominator { get; set; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x0001C430 File Offset: 0x0001A630
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x0001C438 File Offset: 0x0001A638
		public uint Numerator { get; set; }

		// Token: 0x06003440 RID: 13376 RVA: 0x00107834 File Offset: 0x00105A34
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

		// Token: 0x06003441 RID: 13377 RVA: 0x001078A4 File Offset: 0x00105AA4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x0001C441 File Offset: 0x0001A641
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
