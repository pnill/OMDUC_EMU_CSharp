using System;

namespace NetworkProtocols
{
	// Token: 0x02000567 RID: 1383
	public class CommunityEventPartialAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002F18 RID: 12056 RVA: 0x00019003 File Offset: 0x00017203
		public CommunityEventPartialAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3796955822u;
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x0001901C File Offset: 0x0001721C
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00019024 File Offset: 0x00017224
		public ulong AccountSUID { get; set; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x0001902D File Offset: 0x0001722D
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00019035 File Offset: 0x00017235
		public ulong EventID { get; set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x0001903E File Offset: 0x0001723E
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00019046 File Offset: 0x00017246
		public ulong EventChestID { get; set; }

		// Token: 0x06002F1F RID: 12063 RVA: 0x00100950 File Offset: 0x000FEB50
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestID);
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

		// Token: 0x06002F20 RID: 12064 RVA: 0x001009D0 File Offset: 0x000FEBD0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x0001904F File Offset: 0x0001724F
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
