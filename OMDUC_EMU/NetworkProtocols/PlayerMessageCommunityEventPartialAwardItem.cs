using System;

namespace NetworkProtocols
{
	// Token: 0x0200055E RID: 1374
	public class PlayerMessageCommunityEventPartialAwardItem : BaseAwardItem
	{
		// Token: 0x06002EBC RID: 11964 RVA: 0x00018C54 File Offset: 0x00016E54
		public PlayerMessageCommunityEventPartialAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 673919886u;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x00018C6D File Offset: 0x00016E6D
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00018C75 File Offset: 0x00016E75
		public ulong AccountSUID { get; set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x00018C7E File Offset: 0x00016E7E
		// (set) Token: 0x06002EC0 RID: 11968 RVA: 0x00018C86 File Offset: 0x00016E86
		public ulong EventID { get; set; }

		// Token: 0x06002EC1 RID: 11969 RVA: 0x0010019C File Offset: 0x000FE39C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
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

		// Token: 0x06002EC2 RID: 11970 RVA: 0x0010020C File Offset: 0x000FE40C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00018C8F File Offset: 0x00016E8F
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
		}
	}
}
