using System;

namespace NetworkProtocols
{
	// Token: 0x02000726 RID: 1830
	public class GuildPresenceChanged : BotNetMessage
	{
		// Token: 0x060040E1 RID: 16609 RVA: 0x00024FC4 File Offset: 0x000231C4
		public GuildPresenceChanged()
		{
			this.InitRefTypes();
			base.PacketType = 2928865514u;
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00024FDD File Offset: 0x000231DD
		public GuildPresenceChanged(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2928865514u;
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060040E3 RID: 16611 RVA: 0x00024FFD File Offset: 0x000231FD
		// (set) Token: 0x060040E4 RID: 16612 RVA: 0x00025005 File Offset: 0x00023205
		public ulong AccountSUID { get; set; }

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060040E5 RID: 16613 RVA: 0x0002500E File Offset: 0x0002320E
		// (set) Token: 0x060040E6 RID: 16614 RVA: 0x00025016 File Offset: 0x00023216
		public string PlayerName { get; set; }

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060040E7 RID: 16615 RVA: 0x0002501F File Offset: 0x0002321F
		// (set) Token: 0x060040E8 RID: 16616 RVA: 0x00025027 File Offset: 0x00023227
		public ePlayerPresence Presence { get; set; }

		// Token: 0x060040E9 RID: 16617 RVA: 0x0011DE04 File Offset: 0x0011C004
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteePlayerPresence(ref newArray, ref newSize, this.Presence);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0011DEA0 File Offset: 0x0011C0A0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.Presence = ArrayManager.ReadePlayerPresence(data, ref num);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x00025030 File Offset: 0x00023230
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			this.Presence = ePlayerPresence.PlayerPresence_None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002238 RID: 8760
		public const uint cPacketType = 2928865514u;
	}
}
