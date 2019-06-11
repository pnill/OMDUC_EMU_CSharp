using System;

namespace NetworkProtocols
{
	// Token: 0x020005C7 RID: 1479
	public class QuestTaskForNetwork
	{
		// Token: 0x06003393 RID: 13203 RVA: 0x0001BDEA File Offset: 0x00019FEA
		public QuestTaskForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x0001BE00 File Offset: 0x0001A000
		public bool Cumulative { get; set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x0001BE09 File Offset: 0x0001A009
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x0001BE11 File Offset: 0x0001A011
		public bool Completed { get; set; }

		// Token: 0x06003398 RID: 13208 RVA: 0x0010691C File Offset: 0x00104B1C
		public virtual byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Cumulative);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Completed);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00106958 File Offset: 0x00104B58
		public virtual void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Cumulative = ArrayManager.ReadBoolean(data, ref num);
			this.Completed = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0001BE1A File Offset: 0x0001A01A
		private void InitRefTypes()
		{
			this.Cumulative = false;
			this.Completed = false;
		}

		// Token: 0x04001CAC RID: 7340
		public uint UniqueClassID;
	}
}
