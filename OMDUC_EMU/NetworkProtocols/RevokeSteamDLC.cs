using System;

namespace NetworkProtocols
{
	// Token: 0x020004FD RID: 1277
	public class RevokeSteamDLC : BaseAwardEntry
	{
		// Token: 0x06002C88 RID: 11400 RVA: 0x00017AA5 File Offset: 0x00015CA5
		public RevokeSteamDLC()
		{
			this.InitRefTypes();
			this.UniqueClassID = 25802964u;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x00017ABE File Offset: 0x00015CBE
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x00017AC6 File Offset: 0x00015CC6
		public ulong SteamDLCTransactionID { get; set; }

		// Token: 0x06002C8B RID: 11403 RVA: 0x000FE080 File Offset: 0x000FC280
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.SteamDLCTransactionID);
			byte[] array = base.SerializeMessage();
			if (array.Length + num > newArray.Length)
			{
				Array.Resize<byte>(ref newArray, array.Length + num);
			}
			Array.Copy(array, 0, newArray, num, array.Length);
			num += array.Length;
			Array.Resize<byte>(ref newArray, num);
			return newArray;
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000FE0E0 File Offset: 0x000FC2E0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.SteamDLCTransactionID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00017ACF File Offset: 0x00015CCF
		private void InitRefTypes()
		{
			this.SteamDLCTransactionID = 0UL;
		}
	}
}
