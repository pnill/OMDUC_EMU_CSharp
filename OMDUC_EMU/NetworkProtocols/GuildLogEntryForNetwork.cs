using System;

namespace NetworkProtocols
{
	// Token: 0x02000774 RID: 1908
	public class GuildLogEntryForNetwork
	{
		// Token: 0x060043B6 RID: 17334 RVA: 0x000270A9 File Offset: 0x000252A9
		public GuildLogEntryForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x000270B7 File Offset: 0x000252B7
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x000270BF File Offset: 0x000252BF
		public ulong GuildID { get; set; }

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x000270C8 File Offset: 0x000252C8
		// (set) Token: 0x060043BA RID: 17338 RVA: 0x000270D0 File Offset: 0x000252D0
		public DateTime CreatedOn { get; set; }

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x000270D9 File Offset: 0x000252D9
		// (set) Token: 0x060043BC RID: 17340 RVA: 0x000270E1 File Offset: 0x000252E1
		public ulong ActorAccountSUID { get; set; }

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x000270EA File Offset: 0x000252EA
		// (set) Token: 0x060043BE RID: 17342 RVA: 0x000270F2 File Offset: 0x000252F2
		public ulong TargetAccountSUID { get; set; }

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x000270FB File Offset: 0x000252FB
		// (set) Token: 0x060043C0 RID: 17344 RVA: 0x00027103 File Offset: 0x00025303
		public eGuildTransactionLogEvent EventType { get; set; }

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x0002710C File Offset: 0x0002530C
		// (set) Token: 0x060043C2 RID: 17346 RVA: 0x00027114 File Offset: 0x00025314
		public string ActorPlayerName { get; set; }

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x0002711D File Offset: 0x0002531D
		// (set) Token: 0x060043C4 RID: 17348 RVA: 0x00027125 File Offset: 0x00025325
		public string TargetPlayerName { get; set; }

		// Token: 0x060043C5 RID: 17349 RVA: 0x00122824 File Offset: 0x00120A24
		public virtual byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.CreatedOn);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ActorAccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TargetAccountSUID);
			ArrayManager.WriteeGuildTransactionLogEvent(ref newArray, ref newSize, this.EventType);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ActorPlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.TargetPlayerName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x001228AC File Offset: 0x00120AAC
		public virtual void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.CreatedOn = ArrayManager.ReadDateTime(data, ref num);
			this.ActorAccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.TargetAccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventType = ArrayManager.ReadeGuildTransactionLogEvent(data, ref num);
			this.ActorPlayerName = ArrayManager.ReadString(data, ref num);
			this.TargetPlayerName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00122920 File Offset: 0x00120B20
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
			this.CreatedOn = default(DateTime);
			this.ActorAccountSUID = 0UL;
			this.TargetAccountSUID = 0UL;
			this.EventType = eGuildTransactionLogEvent.None;
			this.ActorPlayerName = string.Empty;
			this.TargetPlayerName = string.Empty;
		}

		// Token: 0x04002329 RID: 9001
		public uint UniqueClassID;
	}
}
