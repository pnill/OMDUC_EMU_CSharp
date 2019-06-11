using System;

namespace NetworkProtocols
{
	// Token: 0x0200073A RID: 1850
	public class GuildInvite
	{
		// Token: 0x0600418E RID: 16782 RVA: 0x0002581B File Offset: 0x00023A1B
		public GuildInvite()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x00025829 File Offset: 0x00023A29
		// (set) Token: 0x06004190 RID: 16784 RVA: 0x00025831 File Offset: 0x00023A31
		public ulong InviteID { get; set; }

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x0002583A File Offset: 0x00023A3A
		// (set) Token: 0x06004192 RID: 16786 RVA: 0x00025842 File Offset: 0x00023A42
		public ulong PlayerAccountID { get; set; }

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x0002584B File Offset: 0x00023A4B
		// (set) Token: 0x06004194 RID: 16788 RVA: 0x00025853 File Offset: 0x00023A53
		public ulong GuildID { get; set; }

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x0002585C File Offset: 0x00023A5C
		// (set) Token: 0x06004196 RID: 16790 RVA: 0x00025864 File Offset: 0x00023A64
		public string PlayerName { get; set; }

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06004197 RID: 16791 RVA: 0x0002586D File Offset: 0x00023A6D
		// (set) Token: 0x06004198 RID: 16792 RVA: 0x00025875 File Offset: 0x00023A75
		public string GuildName { get; set; }

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06004199 RID: 16793 RVA: 0x0002587E File Offset: 0x00023A7E
		// (set) Token: 0x0600419A RID: 16794 RVA: 0x00025886 File Offset: 0x00023A86
		public string GuildTag { get; set; }

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x0002588F File Offset: 0x00023A8F
		// (set) Token: 0x0600419C RID: 16796 RVA: 0x00025897 File Offset: 0x00023A97
		public DateTime RequestDate { get; set; }

		// Token: 0x0600419D RID: 16797 RVA: 0x0011F10C File Offset: 0x0011D30C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InviteID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerAccountID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.RequestDate);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x0011F194 File Offset: 0x0011D394
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.InviteID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerAccountID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.RequestDate = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x0011F208 File Offset: 0x0011D408
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			this.PlayerAccountID = 0UL;
			this.GuildID = 0UL;
			this.PlayerName = string.Empty;
			this.GuildName = string.Empty;
			this.GuildTag = string.Empty;
			this.RequestDate = default(DateTime);
		}
	}
}
