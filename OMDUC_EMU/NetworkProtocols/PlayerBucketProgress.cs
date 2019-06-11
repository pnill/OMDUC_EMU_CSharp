using System;

namespace NetworkProtocols
{
	// Token: 0x0200064D RID: 1613
	public class PlayerBucketProgress
	{
		// Token: 0x0600383F RID: 14399 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
		public PlayerBucketProgress()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003840 RID: 14400 RVA: 0x0001EF06 File Offset: 0x0001D106
		// (set) Token: 0x06003841 RID: 14401 RVA: 0x0001EF0E File Offset: 0x0001D10E
		public ulong BucketID { get; set; }

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x0001EF17 File Offset: 0x0001D117
		// (set) Token: 0x06003843 RID: 14403 RVA: 0x0001EF1F File Offset: 0x0001D11F
		public uint StarsObtained { get; set; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003844 RID: 14404 RVA: 0x0001EF28 File Offset: 0x0001D128
		// (set) Token: 0x06003845 RID: 14405 RVA: 0x0001EF30 File Offset: 0x0001D130
		public bool IsUnlocked { get; set; }

		// Token: 0x06003846 RID: 14406 RVA: 0x0010DAA0 File Offset: 0x0010BCA0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BucketID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.StarsObtained);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsUnlocked);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0010DAEC File Offset: 0x0010BCEC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.StarsObtained = ArrayManager.ReadUInt32(data, ref num);
			this.IsUnlocked = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0001EF39 File Offset: 0x0001D139
		private void InitRefTypes()
		{
			this.BucketID = 0UL;
			this.StarsObtained = 0u;
			this.IsUnlocked = false;
		}
	}
}
