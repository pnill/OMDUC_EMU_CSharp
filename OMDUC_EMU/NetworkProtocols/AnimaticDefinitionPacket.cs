using System;

namespace NetworkProtocols
{
	// Token: 0x02000658 RID: 1624
	public class AnimaticDefinitionPacket
	{
		// Token: 0x060038A3 RID: 14499 RVA: 0x0001F372 File Offset: 0x0001D572
		public AnimaticDefinitionPacket()
		{
			this.InitRefTypes();
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x0001F380 File Offset: 0x0001D580
		// (set) Token: 0x060038A5 RID: 14501 RVA: 0x0001F388 File Offset: 0x0001D588
		public ulong ID { get; set; }

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x0001F391 File Offset: 0x0001D591
		// (set) Token: 0x060038A7 RID: 14503 RVA: 0x0001F399 File Offset: 0x0001D599
		public string Filename { get; set; }

		// Token: 0x060038A8 RID: 14504 RVA: 0x0010E488 File Offset: 0x0010C688
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Filename);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0010E4C4 File Offset: 0x0010C6C4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ID = ArrayManager.ReadUInt64(data, ref num);
			this.Filename = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0001F3A2 File Offset: 0x0001D5A2
		private void InitRefTypes()
		{
			this.ID = 0UL;
			this.Filename = string.Empty;
		}
	}
}
