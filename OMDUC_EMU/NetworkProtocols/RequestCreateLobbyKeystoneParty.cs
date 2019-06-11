using System;

namespace NetworkProtocols
{
	// Token: 0x020006BB RID: 1723
	public class RequestCreateLobbyKeystoneParty : BotNetMessage
	{
		// Token: 0x06003DC6 RID: 15814 RVA: 0x00022988 File Offset: 0x00020B88
		public RequestCreateLobbyKeystoneParty()
		{
			this.InitRefTypes();
			base.PacketType = 1694706661u;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x000229A1 File Offset: 0x00020BA1
		public RequestCreateLobbyKeystoneParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1694706661u;
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x000229C1 File Offset: 0x00020BC1
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x000229C9 File Offset: 0x00020BC9
		public ulong PartyID { get; set; }

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x000229D2 File Offset: 0x00020BD2
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x000229DA File Offset: 0x00020BDA
		public ulong KeystoneID { get; set; }

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x000229E3 File Offset: 0x00020BE3
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x000229EB File Offset: 0x00020BEB
		public string LobbyName { get; set; }

		// Token: 0x06003DCE RID: 15822 RVA: 0x00115AA0 File Offset: 0x00113CA0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LobbyName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00115B3C File Offset: 0x00113D3C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
			this.LobbyName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x000229F4 File Offset: 0x00020BF4
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.KeystoneID = 0UL;
			this.LobbyName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002085 RID: 8325
		public const uint cPacketType = 1694706661u;
	}
}
