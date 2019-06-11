using System;

namespace NetworkProtocols
{
	// Token: 0x020006E5 RID: 1765
	public class ServerInviteToParty : BotNetMessage
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x00023829 File Offset: 0x00021A29
		public ServerInviteToParty()
		{
			this.InitRefTypes();
			base.PacketType = 938897425u;
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x00023842 File Offset: 0x00021A42
		public ServerInviteToParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 938897425u;
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x00023862 File Offset: 0x00021A62
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x0002386A File Offset: 0x00021A6A
		public ulong AccountSUID { get; set; }

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x00023873 File Offset: 0x00021A73
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x0002387B File Offset: 0x00021A7B
		public string PlayerName { get; set; }

		// Token: 0x06003EFC RID: 16124 RVA: 0x0011ACBC File Offset: 0x00118EBC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0011AD48 File Offset: 0x00118F48
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
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00023884 File Offset: 0x00021A84
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400212B RID: 8491
		public const uint cPacketType = 938897425u;
	}
}
