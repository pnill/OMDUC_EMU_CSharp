using System;

namespace NetworkProtocols
{
	// Token: 0x020004F7 RID: 1271
	public class KeystoneDepleteEntry : BaseAwardEntry
	{
		// Token: 0x06002C3E RID: 11326 RVA: 0x00017796 File Offset: 0x00015996
		public KeystoneDepleteEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3091768457u;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000177AF File Offset: 0x000159AF
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x000177B7 File Offset: 0x000159B7
		public ulong KeystoneDetailID { get; set; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000177C0 File Offset: 0x000159C0
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x000177C8 File Offset: 0x000159C8
		public int LivesRemaining { get; set; }

		// Token: 0x06002C43 RID: 11331 RVA: 0x000FDAA8 File Offset: 0x000FBCA8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneDetailID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesRemaining);
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

		// Token: 0x06002C44 RID: 11332 RVA: 0x000FDB18 File Offset: 0x000FBD18
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneDetailID = ArrayManager.ReadUInt64(data, ref num);
			this.LivesRemaining = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000177D1 File Offset: 0x000159D1
		private void InitRefTypes()
		{
			this.KeystoneDetailID = 0UL;
			this.LivesRemaining = 0;
		}
	}
}
