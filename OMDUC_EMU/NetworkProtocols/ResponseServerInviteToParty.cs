using System;

namespace NetworkProtocols
{
	// Token: 0x020006E7 RID: 1767
	public class ResponseServerInviteToParty : BotNetMessage
	{
		// Token: 0x06003F0A RID: 16138 RVA: 0x0002392C File Offset: 0x00021B2C
		public ResponseServerInviteToParty()
		{
			this.InitRefTypes();
			base.PacketType = 1044700862u;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00023945 File Offset: 0x00021B45
		public ResponseServerInviteToParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1044700862u;
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x00023965 File Offset: 0x00021B65
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x0002396D File Offset: 0x00021B6D
		public ulong PartyID { get; set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x00023976 File Offset: 0x00021B76
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x0002397E File Offset: 0x00021B7E
		public bool DidJoin { get; set; }

		// Token: 0x06003F10 RID: 16144 RVA: 0x0011AEE0 File Offset: 0x001190E0
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DidJoin);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0011AF6C File Offset: 0x0011916C
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
			this.DidJoin = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00023987 File Offset: 0x00021B87
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.DidJoin = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002132 RID: 8498
		public const uint cPacketType = 1044700862u;
	}
}
