using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004FA RID: 1274
	public class KeystoneRerollEntry : BaseAwardEntry
	{
		// Token: 0x06002C62 RID: 11362 RVA: 0x00017910 File Offset: 0x00015B10
		public KeystoneRerollEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 8867123u;
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x00017929 File Offset: 0x00015B29
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x00017931 File Offset: 0x00015B31
		public ulong KeystoneDetailID { get; set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0001793A File Offset: 0x00015B3A
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x00017942 File Offset: 0x00015B42
		public ulong MapGUID { get; set; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0001794B File Offset: 0x00015B4B
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00017953 File Offset: 0x00015B53
		public uint RerollsRemaining { get; set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x0001795C File Offset: 0x00015B5C
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x00017964 File Offset: 0x00015B64
		public List<ulong> ModifierGUIDs { get; set; }

		// Token: 0x06002C6B RID: 11371 RVA: 0x000FDD88 File Offset: 0x000FBF88
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneDetailID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.RerollsRemaining);
			ArrayManager.WriteListUInt64(ref newArray, ref num, this.ModifierGUIDs);
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

		// Token: 0x06002C6C RID: 11372 RVA: 0x000FDE14 File Offset: 0x000FC014
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneDetailID = ArrayManager.ReadUInt64(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.RerollsRemaining = ArrayManager.ReadUInt32(data, ref num);
			this.ModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0001796D File Offset: 0x00015B6D
		private void InitRefTypes()
		{
			this.KeystoneDetailID = 0UL;
			this.MapGUID = 0UL;
			this.RerollsRemaining = 0u;
			this.ModifierGUIDs = new List<ulong>();
		}
	}
}
