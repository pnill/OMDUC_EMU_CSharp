using System;

namespace NetworkProtocols
{
	// Token: 0x0200059F RID: 1439
	public class ContentBox
	{
		// Token: 0x06003200 RID: 12800 RVA: 0x0001AD56 File Offset: 0x00018F56
		public ContentBox()
		{
			this.InitRefTypes();
		}

		public ulong ContentBoxID { get; set; }
		public ulong BoxLayoutID { get; set; }
		public ulong ContentDefinitionID { get; set; }

		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ContentBoxID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BoxLayoutID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ContentDefinitionID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x001048DC File Offset: 0x00102ADC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ContentBoxID = ArrayManager.ReadUInt64(data, ref num);
			this.BoxLayoutID = ArrayManager.ReadUInt64(data, ref num);
			this.ContentDefinitionID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0001AD97 File Offset: 0x00018F97
		private void InitRefTypes()
		{
			this.ContentBoxID = 0UL;
			this.BoxLayoutID = 0UL;
			this.ContentDefinitionID = 0UL;
		}
	}
}
