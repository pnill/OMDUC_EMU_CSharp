using System;

namespace NetworkProtocols
{
	// Token: 0x020005E6 RID: 1510
	public class KillMinionsTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600348B RID: 13451 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		public KillMinionsTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2975266983u;
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x0001C70D File Offset: 0x0001A90D
		// (set) Token: 0x0600348D RID: 13453 RVA: 0x0001C715 File Offset: 0x0001A915
		public uint Denominator { get; set; }

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x0001C71E File Offset: 0x0001A91E
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x0001C726 File Offset: 0x0001A926
		public uint Numerator { get; set; }

		// Token: 0x06003490 RID: 13456 RVA: 0x00107F8C File Offset: 0x0010618C
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

		// Token: 0x06003491 RID: 13457 RVA: 0x00107FFC File Offset: 0x001061FC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x0001C72F File Offset: 0x0001A92F
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
