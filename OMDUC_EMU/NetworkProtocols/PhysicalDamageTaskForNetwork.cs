using System;

namespace NetworkProtocols
{
	// Token: 0x020005DE RID: 1502
	public class PhysicalDamageTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600344B RID: 13387 RVA: 0x0001C49C File Offset: 0x0001A69C
		public PhysicalDamageTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2011154229u;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x0001C4B5 File Offset: 0x0001A6B5
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x0001C4BD File Offset: 0x0001A6BD
		public uint Denominator { get; set; }

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x0001C4C6 File Offset: 0x0001A6C6
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x0001C4CE File Offset: 0x0001A6CE
		public uint Numerator { get; set; }

		// Token: 0x06003450 RID: 13392 RVA: 0x001079AC File Offset: 0x00105BAC
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

		// Token: 0x06003451 RID: 13393 RVA: 0x00107A1C File Offset: 0x00105C1C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x0001C4D7 File Offset: 0x0001A6D7
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
