using System;

namespace NetworkProtocols
{
	// Token: 0x020006F6 RID: 1782
	public class RequestPartyChatID : BotNetMessage
	{
		// Token: 0x06003FA6 RID: 16294 RVA: 0x0002408E File Offset: 0x0002228E
		public RequestPartyChatID()
		{
			this.InitRefTypes();
			base.PacketType = 1957759188u;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000240A7 File Offset: 0x000222A7
		public RequestPartyChatID(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1957759188u;
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003FA8 RID: 16296 RVA: 0x000240C7 File Offset: 0x000222C7
		// (set) Token: 0x06003FA9 RID: 16297 RVA: 0x000240CF File Offset: 0x000222CF
		public ulong PartyID { get; set; }

		// Token: 0x06003FAA RID: 16298 RVA: 0x0011BF34 File Offset: 0x0011A134
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x0011BFB4 File Offset: 0x0011A1B4
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
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x000240D8 File Offset: 0x000222D8
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002169 RID: 8553
		public const uint cPacketType = 1957759188u;
	}
}
