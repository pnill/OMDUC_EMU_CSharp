using System;

namespace NetworkProtocols
{
	// Token: 0x0200075D RID: 1885
	public class RequestPushGuildMOTD : BotNetMessage
	{
		// Token: 0x060042EE RID: 17134 RVA: 0x00026708 File Offset: 0x00024908
		public RequestPushGuildMOTD()
		{
			this.InitRefTypes();
			base.PacketType = 2858233215u;
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00026721 File Offset: 0x00024921
		public RequestPushGuildMOTD(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2858233215u;
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x00026741 File Offset: 0x00024941
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00026749 File Offset: 0x00024949
		public ulong AccountSUID { get; set; }

		// Token: 0x060042F2 RID: 17138 RVA: 0x001212D4 File Offset: 0x0011F4D4
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

		// Token: 0x060042F3 RID: 17139 RVA: 0x00121354 File Offset: 0x0011F554
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

		// Token: 0x060042F4 RID: 17140 RVA: 0x00026752 File Offset: 0x00024952
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022E8 RID: 8936
		public const uint cPacketType = 2858233215u;
	}
}
