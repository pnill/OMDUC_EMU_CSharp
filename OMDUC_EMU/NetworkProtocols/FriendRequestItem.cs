using System;

namespace NetworkProtocols
{
	// Token: 0x02000710 RID: 1808
	public class FriendRequestItem
	{
		// Token: 0x06004017 RID: 16407 RVA: 0x0002462F File Offset: 0x0002282F
		public FriendRequestItem()
		{
			this.InitRefTypes();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x0002463D File Offset: 0x0002283D
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x00024645 File Offset: 0x00022845
		public ulong AccountSUID { get; set; }

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x0002464E File Offset: 0x0002284E
		// (set) Token: 0x0600401B RID: 16411 RVA: 0x00024656 File Offset: 0x00022856
		public string PlayerName { get; set; }

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x0002465F File Offset: 0x0002285F
		// (set) Token: 0x0600401D RID: 16413 RVA: 0x00024667 File Offset: 0x00022867
		public string GuildTag { get; set; }

		// Token: 0x0600401E RID: 16414 RVA: 0x0011C9AC File Offset: 0x0011ABAC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x0011C9F8 File Offset: 0x0011ABF8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x00024670 File Offset: 0x00022870
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			this.GuildTag = string.Empty;
		}
	}
}
