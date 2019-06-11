using System;

namespace NetworkProtocols
{
	// Token: 0x02000724 RID: 1828
	public class FriendPresenceChanged : BotNetMessage
	{
		// Token: 0x060040CF RID: 16591 RVA: 0x00024ED7 File Offset: 0x000230D7
		public FriendPresenceChanged()
		{
			this.InitRefTypes();
			base.PacketType = 140578634u;
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00024EF0 File Offset: 0x000230F0
		public FriendPresenceChanged(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 140578634u;
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x00024F10 File Offset: 0x00023110
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x00024F18 File Offset: 0x00023118
		public ulong AccountSUID { get; set; }

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x00024F21 File Offset: 0x00023121
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x00024F29 File Offset: 0x00023129
		public string PlayerName { get; set; }

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x00024F32 File Offset: 0x00023132
		// (set) Token: 0x060040D6 RID: 16598 RVA: 0x00024F3A File Offset: 0x0002313A
		public ePlayerPresence Presence { get; set; }

		// Token: 0x060040D7 RID: 16599 RVA: 0x0011DBFC File Offset: 0x0011BDFC
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

		// Token: 0x060040D8 RID: 16600 RVA: 0x0011DC98 File Offset: 0x0011BE98
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

		// Token: 0x060040D9 RID: 16601 RVA: 0x00024F43 File Offset: 0x00023143
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			this.Presence = ePlayerPresence.PlayerPresence_None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002232 RID: 8754
		public const uint cPacketType = 140578634u;
	}
}
