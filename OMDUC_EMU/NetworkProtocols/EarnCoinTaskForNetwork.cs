using System;

namespace NetworkProtocols
{
	// Token: 0x020005DD RID: 1501
	public class EarnCoinTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003443 RID: 13379 RVA: 0x0001C451 File Offset: 0x0001A651
		public EarnCoinTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2152133468u;
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x0001C46A File Offset: 0x0001A66A
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x0001C472 File Offset: 0x0001A672
		public uint Denominator { get; set; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x0001C47B File Offset: 0x0001A67B
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x0001C483 File Offset: 0x0001A683
		public uint Numerator { get; set; }

		// Token: 0x06003448 RID: 13384 RVA: 0x001078F0 File Offset: 0x00105AF0
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

		// Token: 0x06003449 RID: 13385 RVA: 0x00107960 File Offset: 0x00105B60
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x0001C48C File Offset: 0x0001A68C
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
