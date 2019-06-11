using System;

namespace NetworkProtocols
{
	// Token: 0x020006F0 RID: 1776
	public class ServerPromoteNewLeader : BotNetMessage
	{
		// Token: 0x06003F5B RID: 16219 RVA: 0x00023D48 File Offset: 0x00021F48
		public ServerPromoteNewLeader()
		{
			this.InitRefTypes();
			base.PacketType = 2109342607u;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00023D61 File Offset: 0x00021F61
		public ServerPromoteNewLeader(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2109342607u;
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x00023D81 File Offset: 0x00021F81
		// (set) Token: 0x06003F5E RID: 16222 RVA: 0x00023D89 File Offset: 0x00021F89
		public ulong PartyID { get; set; }

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x00023D92 File Offset: 0x00021F92
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x00023D9A File Offset: 0x00021F9A
		public ulong AccountSUID { get; set; }

		// Token: 0x06003F61 RID: 16225 RVA: 0x0011B808 File Offset: 0x00119A08
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x0011B894 File Offset: 0x00119A94
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
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x00023DA3 File Offset: 0x00021FA3
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400214D RID: 8525
		public const uint cPacketType = 2109342607u;
	}
}
