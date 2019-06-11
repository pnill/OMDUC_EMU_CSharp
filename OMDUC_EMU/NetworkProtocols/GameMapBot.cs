using System;

namespace NetworkProtocols
{
	// Token: 0x020006B1 RID: 1713
	public class GameMapBot
	{
		// Token: 0x06003C98 RID: 15512 RVA: 0x00021EC3 File Offset: 0x000200C3
		public GameMapBot()
		{
			this.InitRefTypes();
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x00021ED1 File Offset: 0x000200D1
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x00021ED9 File Offset: 0x000200D9
		public ulong ItemGUID { get; set; }

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x00021EE2 File Offset: 0x000200E2
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x00021EEA File Offset: 0x000200EA
		public uint Team { get; set; }

		// Token: 0x06003C9D RID: 15517 RVA: 0x001142D4 File Offset: 0x001124D4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ItemGUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Team);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00114310 File Offset: 0x00112510
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Team = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00021EF3 File Offset: 0x000200F3
		private void InitRefTypes()
		{
			this.ItemGUID = 0UL;
			this.Team = 0u;
		}
	}
}
