using System;

namespace NetworkProtocols
{
	// Token: 0x020005B3 RID: 1459
	public class RegexPattern
	{
		// Token: 0x060032B9 RID: 12985 RVA: 0x0001B51A File Offset: 0x0001971A
		public RegexPattern()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x0001B528 File Offset: 0x00019728
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x0001B530 File Offset: 0x00019730
		public string Pattern { get; set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x0001B539 File Offset: 0x00019739
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x0001B541 File Offset: 0x00019741
		public eRegistrationStatus FailureStatus { get; set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x0001B54A File Offset: 0x0001974A
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x0001B552 File Offset: 0x00019752
		public string LocalizationKey { get; set; }

		// Token: 0x060032C0 RID: 12992 RVA: 0x001057E0 File Offset: 0x001039E0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.Pattern);
			ArrayManager.WriteeRegistrationStatus(ref newArray, ref newSize, this.FailureStatus);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LocalizationKey);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x0010582C File Offset: 0x00103A2C
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Pattern = ArrayManager.ReadString(data, ref num);
			this.FailureStatus = ArrayManager.ReadeRegistrationStatus(data, ref num);
			this.LocalizationKey = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x0001B55B File Offset: 0x0001975B
		private void InitRefTypes()
		{
			this.Pattern = string.Empty;
			this.FailureStatus = eRegistrationStatus.eRegistrationStatus_Success;
			this.LocalizationKey = string.Empty;
		}
	}
}
