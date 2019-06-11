using System;

namespace NetworkProtocols
{
	// Token: 0x020005D9 RID: 1497
	public class PlaceGuardiansTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003423 RID: 13347 RVA: 0x0001C325 File Offset: 0x0001A525
		public PlaceGuardiansTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2770328582u;
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x0001C33E File Offset: 0x0001A53E
		// (set) Token: 0x06003425 RID: 13349 RVA: 0x0001C346 File Offset: 0x0001A546
		public uint Denominator { get; set; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x0001C34F File Offset: 0x0001A54F
		// (set) Token: 0x06003427 RID: 13351 RVA: 0x0001C357 File Offset: 0x0001A557
		public uint Numerator { get; set; }

		// Token: 0x06003428 RID: 13352 RVA: 0x00107600 File Offset: 0x00105800
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

		// Token: 0x06003429 RID: 13353 RVA: 0x00107670 File Offset: 0x00105870
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x0001C360 File Offset: 0x0001A560
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
