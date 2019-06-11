using System;

namespace NetworkProtocols
{
	// Token: 0x020005B4 RID: 1460
	public class GuildRegexPattern
	{
		// Token: 0x060032C3 RID: 12995 RVA: 0x0001B57A File Offset: 0x0001977A
		public GuildRegexPattern()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x0001B588 File Offset: 0x00019788
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x0001B590 File Offset: 0x00019790
		public string Pattern { get; set; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x0001B599 File Offset: 0x00019799
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x0001B5A1 File Offset: 0x000197A1
		public eGuildOperationStatus FailureStatus { get; set; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x0001B5AA File Offset: 0x000197AA
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x0001B5B2 File Offset: 0x000197B2
		public string LocalizationKey { get; set; }

		// Token: 0x060032CA RID: 13002 RVA: 0x00105868 File Offset: 0x00103A68
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.Pattern);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.FailureStatus);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LocalizationKey);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x001058B4 File Offset: 0x00103AB4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Pattern = ArrayManager.ReadString(data, ref num);
			this.FailureStatus = ArrayManager.ReadeGuildOperationStatus(data, ref num);
			this.LocalizationKey = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0001B5BB File Offset: 0x000197BB
		private void InitRefTypes()
		{
			this.Pattern = string.Empty;
			this.FailureStatus = eGuildOperationStatus.None;
			this.LocalizationKey = string.Empty;
		}
	}
}
