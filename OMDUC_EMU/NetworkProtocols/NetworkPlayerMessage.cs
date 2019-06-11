using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000625 RID: 1573
	public class NetworkPlayerMessage
	{
		// Token: 0x060036CE RID: 14030 RVA: 0x0001E043 File Offset: 0x0001C243
		public NetworkPlayerMessage()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x0001E051 File Offset: 0x0001C251
		// (set) Token: 0x060036D0 RID: 14032 RVA: 0x0001E059 File Offset: 0x0001C259
		public ulong PlayerMessageID { get; set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x0001E062 File Offset: 0x0001C262
		// (set) Token: 0x060036D2 RID: 14034 RVA: 0x0001E06A File Offset: 0x0001C26A
		public List<BaseAwardItem> Items { get; set; }

		// Token: 0x060036D3 RID: 14035 RVA: 0x0010B930 File Offset: 0x00109B30
		public virtual byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerMessageID);
			ArrayManager.WriteListBaseAwardItem(ref newArray, ref newSize, this.Items);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x0010B96C File Offset: 0x00109B6C
		public virtual void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.PlayerMessageID = ArrayManager.ReadUInt64(data, ref num);
			this.Items = ArrayManager.ReadListBaseAwardItem(data, ref num);
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0001E073 File Offset: 0x0001C273
		private void InitRefTypes()
		{
			this.PlayerMessageID = 0UL;
			this.Items = new List<BaseAwardItem>();
		}

		// Token: 0x04001DA3 RID: 7587
		public uint UniqueClassID;
	}
}
