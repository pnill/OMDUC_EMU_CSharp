using System;

namespace NetworkProtocols
{
	// Token: 0x020006BE RID: 1726
	public class RequestLobbySetDetails : BotNetMessage
	{
		// Token: 0x06003DE3 RID: 15843 RVA: 0x00022AFF File Offset: 0x00020CFF
		public RequestLobbySetDetails()
		{
			this.InitRefTypes();
			base.PacketType = 4005028566u;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00022B18 File Offset: 0x00020D18
		public RequestLobbySetDetails(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4005028566u;
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x00022B38 File Offset: 0x00020D38
		// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x00022B40 File Offset: 0x00020D40
		public ulong LobbyID { get; set; }

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06003DE7 RID: 15847 RVA: 0x00022B49 File Offset: 0x00020D49
		// (set) Token: 0x06003DE8 RID: 15848 RVA: 0x00022B51 File Offset: 0x00020D51
		public string Password { get; set; }

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06003DE9 RID: 15849 RVA: 0x00022B5A File Offset: 0x00020D5A
		// (set) Token: 0x06003DEA RID: 15850 RVA: 0x00022B62 File Offset: 0x00020D62
		public string Description { get; set; }

		// Token: 0x06003DEB RID: 15851 RVA: 0x00115DC8 File Offset: 0x00113FC8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00115E64 File Offset: 0x00114064
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
			this.Description = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00022B6B File Offset: 0x00020D6B
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.Password = string.Empty;
			this.Description = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400208F RID: 8335
		public const uint cPacketType = 4005028566u;
	}
}
