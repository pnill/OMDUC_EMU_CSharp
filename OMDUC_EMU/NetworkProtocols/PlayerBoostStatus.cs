using System;

namespace NetworkProtocols
{
	// Token: 0x0200064B RID: 1611
	public class PlayerBoostStatus
	{
		// Token: 0x0600382E RID: 14382 RVA: 0x0001EE59 File Offset: 0x0001D059
		public PlayerBoostStatus()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0001EE67 File Offset: 0x0001D067
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x0001EE6F File Offset: 0x0001D06F
		public ePlayerBoostType BoostType { get; set; }

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0001EE78 File Offset: 0x0001D078
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x0001EE80 File Offset: 0x0001D080
		public bool IsActive { get; set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x0001EE89 File Offset: 0x0001D089
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x0001EE91 File Offset: 0x0001D091
		public DateTime Expiration { get; set; }

		// Token: 0x06003835 RID: 14389 RVA: 0x0010D904 File Offset: 0x0010BB04
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteePlayerBoostType(ref newArray, ref newSize, this.BoostType);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsActive);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.Expiration);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x0010D950 File Offset: 0x0010BB50
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BoostType = ArrayManager.ReadePlayerBoostType(data, ref num);
			this.IsActive = ArrayManager.ReadBoolean(data, ref num);
			this.Expiration = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x0010D98C File Offset: 0x0010BB8C
		private void InitRefTypes()
		{
			this.BoostType = ePlayerBoostType.None;
			this.IsActive = false;
			this.Expiration = default(DateTime);
		}
	}
}
