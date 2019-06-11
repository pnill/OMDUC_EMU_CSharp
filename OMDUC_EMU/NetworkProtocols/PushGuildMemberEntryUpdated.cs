using System;

namespace NetworkProtocols
{
	// Token: 0x02000767 RID: 1895
	public class PushGuildMemberEntryUpdated : BotNetMessage
	{
		// Token: 0x06004336 RID: 17206 RVA: 0x00026AB9 File Offset: 0x00024CB9
		public PushGuildMemberEntryUpdated()
		{
			this.InitRefTypes();
			base.PacketType = 3091527972u;
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00026AD2 File Offset: 0x00024CD2
		public PushGuildMemberEntryUpdated(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3091527972u;
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x00026AF2 File Offset: 0x00024CF2
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x00026AFA File Offset: 0x00024CFA
		public GuildMemberEntry MemberEntry { get; set; }

		// Token: 0x0600433A RID: 17210 RVA: 0x00121C00 File Offset: 0x0011FE00
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

		// Token: 0x0600433B RID: 17211 RVA: 0x00121C80 File Offset: 0x0011FE80
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

		// Token: 0x0600433C RID: 17212 RVA: 0x00026B03 File Offset: 0x00024D03
		private void InitRefTypes()
		{
			this.MemberEntry = new GuildMemberEntry();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022FD RID: 8957
		public const uint cPacketType = 3091527972u;
	}
}
