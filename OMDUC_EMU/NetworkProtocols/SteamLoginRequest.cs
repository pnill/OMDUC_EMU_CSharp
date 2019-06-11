using System;

namespace NetworkProtocols
{
	// Token: 0x02000603 RID: 1539
	public class SteamLoginRequest : BotNetMessage
	{
		// Token: 0x0600358D RID: 13709 RVA: 0x0001D135 File Offset: 0x0001B335
		public SteamLoginRequest()
		{
			this.InitRefTypes();
			base.PacketType = 1796795828u;
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0001D14E File Offset: 0x0001B34E
		public SteamLoginRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1796795828u;
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x0001D16E File Offset: 0x0001B36E
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x0001D176 File Offset: 0x0001B376
		public string AuthToken { get; set; }

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x0001D17F File Offset: 0x0001B37F
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x0001D187 File Offset: 0x0001B387
		public ulong SteamID { get; set; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x0001D190 File Offset: 0x0001B390
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x0001D198 File Offset: 0x0001B398
		public string RemoteEndpoint { get; set; }

		// Token: 0x06003595 RID: 13717 RVA: 0x00109668 File Offset: 0x00107868
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.AuthToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00109704 File Offset: 0x00107904
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AuthToken = ArrayManager.ReadString(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x0001D1A1 File Offset: 0x0001B3A1
		private void InitRefTypes()
		{
			this.AuthToken = string.Empty;
			this.SteamID = 0UL;
			this.RemoteEndpoint = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D36 RID: 7478
		public const uint cPacketType = 1796795828u;
	}
}
