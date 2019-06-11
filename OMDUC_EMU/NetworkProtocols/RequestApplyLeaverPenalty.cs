using System;

namespace NetworkProtocols
{
	// Token: 0x020006A9 RID: 1705
	public class RequestApplyLeaverPenalty : BotNetMessage
	{
		// Token: 0x06003BCD RID: 15309 RVA: 0x000217A8 File Offset: 0x0001F9A8
		public RequestApplyLeaverPenalty()
		{
			this.InitRefTypes();
			base.PacketType = 3715818711u;
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x000217C1 File Offset: 0x0001F9C1
		public RequestApplyLeaverPenalty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3715818711u;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x000217E1 File Offset: 0x0001F9E1
		// (set) Token: 0x06003BD0 RID: 15312 RVA: 0x000217E9 File Offset: 0x0001F9E9
		public ulong LobbyID { get; set; }

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00113210 File Offset: 0x00111410
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00113290 File Offset: 0x00111490
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
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000217F2 File Offset: 0x0001F9F2
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FA7 RID: 8103
		public const uint cPacketType = 3715818711u;
	}
}
