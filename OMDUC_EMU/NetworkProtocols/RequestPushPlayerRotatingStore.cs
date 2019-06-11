using System;

namespace NetworkProtocols
{
	// Token: 0x02000656 RID: 1622
	public class RequestPushPlayerRotatingStore : BotNetMessage
	{
		// Token: 0x06003895 RID: 14485 RVA: 0x0001F2B9 File Offset: 0x0001D4B9
		public RequestPushPlayerRotatingStore()
		{
			this.InitRefTypes();
			base.PacketType = 3749518121u;
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x0001F2D2 File Offset: 0x0001D4D2
		public RequestPushPlayerRotatingStore(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3749518121u;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x0001F2F2 File Offset: 0x0001D4F2
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x0001F2FA File Offset: 0x0001D4FA
		public ulong AccountSUID { get; set; }

		// Token: 0x06003899 RID: 14489 RVA: 0x0010E2B8 File Offset: 0x0010C4B8
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x0010E338 File Offset: 0x0010C538
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
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x0001F303 File Offset: 0x0001D503
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E30 RID: 7728
		public const uint cPacketType = 3749518121u;
	}
}
