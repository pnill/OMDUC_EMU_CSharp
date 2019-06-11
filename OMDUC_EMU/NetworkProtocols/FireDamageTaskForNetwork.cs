using System;

namespace NetworkProtocols
{
	// Token: 0x020005DF RID: 1503
	public class FireDamageTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003453 RID: 13395 RVA: 0x0001C4E7 File Offset: 0x0001A6E7
		public FireDamageTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 291343381u;
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x0001C500 File Offset: 0x0001A700
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x0001C508 File Offset: 0x0001A708
		public uint Denominator { get; set; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x0001C511 File Offset: 0x0001A711
		// (set) Token: 0x06003457 RID: 13399 RVA: 0x0001C519 File Offset: 0x0001A719
		public uint Numerator { get; set; }

		// Token: 0x06003458 RID: 13400 RVA: 0x00107A68 File Offset: 0x00105C68
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

		// Token: 0x06003459 RID: 13401 RVA: 0x00107AD8 File Offset: 0x00105CD8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x0001C522 File Offset: 0x0001A722
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
