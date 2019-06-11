using System;

namespace NetworkProtocols
{
	// Token: 0x02000699 RID: 1689
	public class RequestLobbyJoin : BotNetMessage
	{
		// Token: 0x06003B2F RID: 15151 RVA: 0x00020FB4 File Offset: 0x0001F1B4
		public RequestLobbyJoin()
		{
			this.InitRefTypes();
			base.PacketType = 528372036u;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00020FCD File Offset: 0x0001F1CD
		public RequestLobbyJoin(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 528372036u;
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x00020FED File Offset: 0x0001F1ED
		// (set) Token: 0x06003B32 RID: 15154 RVA: 0x00020FF5 File Offset: 0x0001F1F5
		public ulong LobbyID { get; set; }

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x00020FFE File Offset: 0x0001F1FE
		// (set) Token: 0x06003B34 RID: 15156 RVA: 0x00021006 File Offset: 0x0001F206
		public string Password { get; set; }

		// Token: 0x06003B35 RID: 15157 RVA: 0x00112108 File Offset: 0x00110308
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LobbyID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Password);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00112194 File Offset: 0x00110394
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LobbyID = ArrayManager.ReadUInt64(data, ref num);
			this.Password = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x0002100F File Offset: 0x0001F20F
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.Password = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F70 RID: 8048
		public const uint cPacketType = 528372036u;
	}
}
