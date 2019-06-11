using System;

namespace NetworkProtocols
{
	// Token: 0x020004F4 RID: 1268
	public class BaseAwardEntry
	{
		// Token: 0x06002C10 RID: 11280 RVA: 0x000175EB File Offset: 0x000157EB
		public BaseAwardEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000175F9 File Offset: 0x000157F9
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x00017601 File Offset: 0x00015801
		public uint Quantity { get; set; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x0001760A File Offset: 0x0001580A
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x00017612 File Offset: 0x00015812
		public HardAwardTypes HardAwardType { get; set; }

		// Token: 0x06002C15 RID: 11285 RVA: 0x000FD740 File Offset: 0x000FB940
		public virtual byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Quantity);
			ArrayManager.WriteHardAwardTypes(ref newArray, ref newSize, this.HardAwardType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000FD77C File Offset: 0x000FB97C
		public virtual void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Quantity = ArrayManager.ReadUInt32(data, ref num);
			this.HardAwardType = ArrayManager.ReadHardAwardTypes(data, ref num);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0001761B File Offset: 0x0001581B
		private void InitRefTypes()
		{
			this.Quantity = 0u;
			this.HardAwardType = HardAwardTypes.None;
		}

		// Token: 0x04001A73 RID: 6771
		public uint UniqueClassID;
	}
}
