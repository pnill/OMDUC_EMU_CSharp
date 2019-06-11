using System;

namespace NetworkProtocols
{
	// Token: 0x020005D7 RID: 1495
	public class PrimaryAbilityTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003413 RID: 13331 RVA: 0x0001C28F File Offset: 0x0001A48F
		public PrimaryAbilityTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3024162144u;
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
		public uint Denominator { get; set; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x0001C2B9 File Offset: 0x0001A4B9
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x0001C2C1 File Offset: 0x0001A4C1
		public uint Numerator { get; set; }

		// Token: 0x06003418 RID: 13336 RVA: 0x00107488 File Offset: 0x00105688
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

		// Token: 0x06003419 RID: 13337 RVA: 0x001074F8 File Offset: 0x001056F8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x0001C2CA File Offset: 0x0001A4CA
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
