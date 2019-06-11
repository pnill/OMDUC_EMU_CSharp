using System;

namespace NetworkProtocols
{
	// Token: 0x020005F5 RID: 1525
	public class CreatePartyTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600350D RID: 13581 RVA: 0x0001CBD5 File Offset: 0x0001ADD5
		public CreatePartyTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1921601521u;
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x0001CBEE File Offset: 0x0001ADEE
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x0001CBF6 File Offset: 0x0001ADF6
		public uint Denominator { get; set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x0001CBFF File Offset: 0x0001ADFF
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x0001CC07 File Offset: 0x0001AE07
		public uint Numerator { get; set; }

		// Token: 0x06003512 RID: 13586 RVA: 0x00108B1C File Offset: 0x00106D1C
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

		// Token: 0x06003513 RID: 13587 RVA: 0x00108B8C File Offset: 0x00106D8C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x0001CC10 File Offset: 0x0001AE10
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
