using System;

namespace NetworkProtocols
{
	// Token: 0x020006BF RID: 1727
	public class ServerInviteToLobby : BotNetMessage
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x00022B92 File Offset: 0x00020D92
		public ServerInviteToLobby()
		{
			this.InitRefTypes();
			base.PacketType = 1921477382u;
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00022BAB File Offset: 0x00020DAB
		public ServerInviteToLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1921477382u;
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x00022BCB File Offset: 0x00020DCB
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x00022BD3 File Offset: 0x00020DD3
		public ulong AccountSUID { get; set; }

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x00022BDC File Offset: 0x00020DDC
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x00022BE4 File Offset: 0x00020DE4
		public string PlayerName { get; set; }

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00115EE8 File Offset: 0x001140E8
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

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00115F74 File Offset: 0x00114174
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

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00022BED File Offset: 0x00020DED
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PlayerName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002093 RID: 8339
		public const uint cPacketType = 1921477382u;
	}
}
