using System;

namespace NetworkProtocols
{
	// Token: 0x02000764 RID: 1892
	public class PushGuildInviteAdded : BotNetMessage
	{
		// Token: 0x06004321 RID: 17185 RVA: 0x000269A6 File Offset: 0x00024BA6
		public PushGuildInviteAdded()
		{
			this.InitRefTypes();
			base.PacketType = 4077581278u;
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000269BF File Offset: 0x00024BBF
		public PushGuildInviteAdded(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4077581278u;
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06004323 RID: 17187 RVA: 0x000269DF File Offset: 0x00024BDF
		// (set) Token: 0x06004324 RID: 17188 RVA: 0x000269E7 File Offset: 0x00024BE7
		public GuildInvite AddedInvite { get; set; }

		// Token: 0x06004325 RID: 17189 RVA: 0x00121948 File Offset: 0x0011FB48
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
			ArrayManager.WriteGuildInvite(ref newArray, ref newSize, this.AddedInvite);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x001219C8 File Offset: 0x0011FBC8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AddedInvite = ArrayManager.ReadGuildInvite(data, ref num);
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000269F0 File Offset: 0x00024BF0
		private void InitRefTypes()
		{
			this.AddedInvite = new GuildInvite();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022F7 RID: 8951
		public const uint cPacketType = 4077581278u;
	}
}
