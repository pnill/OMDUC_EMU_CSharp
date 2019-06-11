using System;

namespace NetworkProtocols
{
	// Token: 0x020005E1 RID: 1505
	public class ArcaneDamageTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003463 RID: 13411 RVA: 0x0001C57D File Offset: 0x0001A77D
		public ArcaneDamageTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2812040384u;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x0001C596 File Offset: 0x0001A796
		// (set) Token: 0x06003465 RID: 13413 RVA: 0x0001C59E File Offset: 0x0001A79E
		public uint Denominator { get; set; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06003466 RID: 13414 RVA: 0x0001C5A7 File Offset: 0x0001A7A7
		// (set) Token: 0x06003467 RID: 13415 RVA: 0x0001C5AF File Offset: 0x0001A7AF
		public uint Numerator { get; set; }

		// Token: 0x06003468 RID: 13416 RVA: 0x00107BE0 File Offset: 0x00105DE0
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

		// Token: 0x06003469 RID: 13417 RVA: 0x00107C50 File Offset: 0x00105E50
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x0001C5B8 File Offset: 0x0001A7B8
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
