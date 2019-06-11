using System;

namespace NetworkProtocols
{
	// Token: 0x020005D8 RID: 1496
	public class SecondaryAbilityTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600341B RID: 13339 RVA: 0x0001C2DA File Offset: 0x0001A4DA
		public SecondaryAbilityTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1640444437u;
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600341C RID: 13340 RVA: 0x0001C2F3 File Offset: 0x0001A4F3
		// (set) Token: 0x0600341D RID: 13341 RVA: 0x0001C2FB File Offset: 0x0001A4FB
		public uint Denominator { get; set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600341E RID: 13342 RVA: 0x0001C304 File Offset: 0x0001A504
		// (set) Token: 0x0600341F RID: 13343 RVA: 0x0001C30C File Offset: 0x0001A50C
		public uint Numerator { get; set; }

		// Token: 0x06003420 RID: 13344 RVA: 0x00107544 File Offset: 0x00105744
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

		// Token: 0x06003421 RID: 13345 RVA: 0x001075B4 File Offset: 0x001057B4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x0001C315 File Offset: 0x0001A515
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
