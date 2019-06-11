using System;

namespace NetworkProtocols
{
	// Token: 0x02000768 RID: 1896
	public class PushGuildMemberEntryAdded : BotNetMessage
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00026B17 File Offset: 0x00024D17
		public PushGuildMemberEntryAdded()
		{
			this.InitRefTypes();
			base.PacketType = 3017243260u;
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00026B30 File Offset: 0x00024D30
		public PushGuildMemberEntryAdded(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3017243260u;
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x00026B50 File Offset: 0x00024D50
		// (set) Token: 0x06004340 RID: 17216 RVA: 0x00026B58 File Offset: 0x00024D58
		public GuildMemberEntry MemberEntry { get; set; }

		// Token: 0x06004341 RID: 17217 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteGuildMemberEntry(ref newArray, ref newSize, this.MemberEntry);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00121D68 File Offset: 0x0011FF68
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MemberEntry = ArrayManager.ReadGuildMemberEntry(data, ref num);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00026B61 File Offset: 0x00024D61
		private void InitRefTypes()
		{
			this.MemberEntry = new GuildMemberEntry();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022FF RID: 8959
		public const uint cPacketType = 3017243260u;
	}
}
