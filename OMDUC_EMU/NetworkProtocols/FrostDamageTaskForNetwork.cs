using System;

namespace NetworkProtocols
{
	// Token: 0x020005E0 RID: 1504
	public class FrostDamageTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600345B RID: 13403 RVA: 0x0001C532 File Offset: 0x0001A732
		public FrostDamageTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1304569653u;
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x0001C54B File Offset: 0x0001A74B
		// (set) Token: 0x0600345D RID: 13405 RVA: 0x0001C553 File Offset: 0x0001A753
		public uint Denominator { get; set; }

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x0001C55C File Offset: 0x0001A75C
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x0001C564 File Offset: 0x0001A764
		public uint Numerator { get; set; }

		// Token: 0x06003460 RID: 13408 RVA: 0x00107B24 File Offset: 0x00105D24
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

		// Token: 0x06003461 RID: 13409 RVA: 0x00107B94 File Offset: 0x00105D94
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x0001C56D File Offset: 0x0001A76D
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
