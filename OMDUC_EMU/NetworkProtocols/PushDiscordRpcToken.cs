using System;

namespace NetworkProtocols
{
	// Token: 0x0200048F RID: 1167
	public class PushDiscordRpcToken : BotNetMessage
	{
		// Token: 0x06002A3F RID: 10815 RVA: 0x000160E9 File Offset: 0x000142E9
		public PushDiscordRpcToken()
		{
			this.InitRefTypes();
			base.PacketType = 4086459309u;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00016102 File Offset: 0x00014302
		public PushDiscordRpcToken(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4086459309u;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x00016122 File Offset: 0x00014322
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x0001612A File Offset: 0x0001432A
		public string RpcToken { get; set; }

		// Token: 0x06002A43 RID: 10819 RVA: 0x000FAFEC File Offset: 0x000F91EC
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.RpcToken);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000FB06C File Offset: 0x000F926C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.RpcToken = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00016133 File Offset: 0x00014333
		private void InitRefTypes()
		{
			this.RpcToken = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016DD RID: 5853
		public const uint cPacketType = 4086459309u;
	}
}
