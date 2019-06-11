using System;

namespace NetworkProtocols
{
	// Token: 0x020006F4 RID: 1780
	public class RequestPartyStatus : BotNetMessage
	{
		// Token: 0x06003F92 RID: 16274 RVA: 0x00023F88 File Offset: 0x00022188
		public RequestPartyStatus()
		{
			this.InitRefTypes();
			base.PacketType = 423210044u;
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00023FA1 File Offset: 0x000221A1
		public RequestPartyStatus(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 423210044u;
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x00023FC1 File Offset: 0x000221C1
		// (set) Token: 0x06003F95 RID: 16277 RVA: 0x00023FC9 File Offset: 0x000221C9
		public ulong PartyID { get; set; }

		// Token: 0x06003F96 RID: 16278 RVA: 0x0011BD0C File Offset: 0x00119F0C
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

		// Token: 0x06003F97 RID: 16279 RVA: 0x0011BD8C File Offset: 0x00119F8C
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

		// Token: 0x06003F98 RID: 16280 RVA: 0x00023FD2 File Offset: 0x000221D2
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002162 RID: 8546
		public const uint cPacketType = 423210044u;
	}
}
