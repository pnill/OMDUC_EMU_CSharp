using System;

namespace NetworkProtocols
{
	// Token: 0x02000697 RID: 1687
	public class RequestCreateSpecialLobby : BotNetMessage
	{
		// Token: 0x06003B1F RID: 15135 RVA: 0x00020EE7 File Offset: 0x0001F0E7
		public RequestCreateSpecialLobby()
		{
			this.InitRefTypes();
			base.PacketType = 2165191942u;
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00020F00 File Offset: 0x0001F100
		public RequestCreateSpecialLobby(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2165191942u;
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x00020F20 File Offset: 0x0001F120
		// (set) Token: 0x06003B22 RID: 15138 RVA: 0x00020F28 File Offset: 0x0001F128
		public ulong MapGUID { get; set; }

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x00020F31 File Offset: 0x0001F131
		// (set) Token: 0x06003B24 RID: 15140 RVA: 0x00020F39 File Offset: 0x0001F139
		public eGameType GameType { get; set; }

		// Token: 0x06003B25 RID: 15141 RVA: 0x00111F1C File Offset: 0x0011011C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapGUID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00111FA8 File Offset: 0x001101A8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00020F42 File Offset: 0x0001F142
		private void InitRefTypes()
		{
			this.MapGUID = 0UL;
			this.GameType = eGameType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F6B RID: 8043
		public const uint cPacketType = 2165191942u;
	}
}
