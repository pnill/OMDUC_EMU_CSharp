using System;

namespace NetworkProtocols
{
	// Token: 0x020005FA RID: 1530
	public class AchievementTaskProtoForNetwork
	{
		// Token: 0x0600353F RID: 13631 RVA: 0x0001CDBD File Offset: 0x0001AFBD
		public AchievementTaskProtoForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x0001CDCB File Offset: 0x0001AFCB
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x0001CDD3 File Offset: 0x0001AFD3
		public uint TaskGUID { get; set; }

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		public ulong Denominator { get; set; }

		// Token: 0x06003544 RID: 13636 RVA: 0x00108FDC File Offset: 0x001071DC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TaskGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Denominator);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00109018 File Offset: 0x00107218
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.TaskGUID = ArrayManager.ReadUInt32(data, ref num);
			this.Denominator = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0001CDED File Offset: 0x0001AFED
		private void InitRefTypes()
		{
			this.TaskGUID = 0u;
			this.Denominator = 0UL;
		}
	}
}
