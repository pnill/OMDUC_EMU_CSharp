using System;

namespace NetworkProtocols
{
	// Token: 0x020005B7 RID: 1463
	public class TrapTier
	{
		// Token: 0x060032DD RID: 13021 RVA: 0x0001B662 File Offset: 0x00019862
		public TrapTier()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x0001B670 File Offset: 0x00019870
		// (set) Token: 0x060032DF RID: 13023 RVA: 0x0001B678 File Offset: 0x00019878
		public uint Strength { get; set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x0001B681 File Offset: 0x00019881
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x0001B689 File Offset: 0x00019889
		public bool SlotAvailable { get; set; }

		// Token: 0x060032E2 RID: 13026 RVA: 0x001059C0 File Offset: 0x00103BC0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Strength);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.SlotAvailable);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x001059FC File Offset: 0x00103BFC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Strength = ArrayManager.ReadUInt32(data, ref num);
			this.SlotAvailable = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x0001B692 File Offset: 0x00019892
		private void InitRefTypes()
		{
			this.Strength = 0u;
			this.SlotAvailable = false;
		}
	}
}
