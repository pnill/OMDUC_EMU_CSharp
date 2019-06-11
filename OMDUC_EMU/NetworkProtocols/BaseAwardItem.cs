using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000523 RID: 1315
	public class BaseAwardItem
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x000180CB File Offset: 0x000162CB
		public BaseAwardItem()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000180D9 File Offset: 0x000162D9
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x000180E1 File Offset: 0x000162E1
		public List<BaseAwardEntry> Awards { get; set; }

		// Token: 0x06002D53 RID: 11603 RVA: 0x000FEC3C File Offset: 0x000FCE3C
		public virtual byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteListBaseAwardEntry(ref newArray, ref newSize, this.Awards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x000FEC6C File Offset: 0x000FCE6C
		public virtual void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Awards = ArrayManager.ReadListBaseAwardEntry(data, ref num);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000180EA File Offset: 0x000162EA
		private void InitRefTypes()
		{
			this.Awards = new List<BaseAwardEntry>();
		}

		// Token: 0x04001AB6 RID: 6838
		public uint UniqueClassID;
	}
}
