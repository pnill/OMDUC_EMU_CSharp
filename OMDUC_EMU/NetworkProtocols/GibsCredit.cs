using System;

namespace NetworkProtocols
{
	// Token: 0x02000502 RID: 1282
	public class GibsCredit : BaseAwardEntry
	{
		// Token: 0x06002CA2 RID: 11426 RVA: 0x00017B72 File Offset: 0x00015D72
		public GibsCredit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2328749131u;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x00017B8B File Offset: 0x00015D8B
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x00017B93 File Offset: 0x00015D93
		public ulong DebitItemGUID { get; set; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x00017B9C File Offset: 0x00015D9C
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x00017BA4 File Offset: 0x00015DA4
		public uint DebitItemQuantity { get; set; }

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000FE2D4 File Offset: 0x000FC4D4
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.DebitItemGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.DebitItemQuantity);
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

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000FE344 File Offset: 0x000FC544
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.DebitItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.DebitItemQuantity = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00017BAD File Offset: 0x00015DAD
		private void InitRefTypes()
		{
			this.DebitItemGUID = 0UL;
			this.DebitItemQuantity = 0u;
		}
	}
}
