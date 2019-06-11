using System;

namespace NetworkProtocols
{
	// Token: 0x0200061A RID: 1562
	public class RequestFinalizeSteamTransaction : BotNetMessage
	{
		// Token: 0x0600367C RID: 13948 RVA: 0x0001DC4D File Offset: 0x0001BE4D
		public RequestFinalizeSteamTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 4238955084u;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0001DC66 File Offset: 0x0001BE66
		public RequestFinalizeSteamTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4238955084u;
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x0001DC86 File Offset: 0x0001BE86
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x0001DC8E File Offset: 0x0001BE8E
		public ulong SteamID { get; set; }

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x0001DC97 File Offset: 0x0001BE97
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x0001DC9F File Offset: 0x0001BE9F
		public ulong TransactionID { get; set; }

		// Token: 0x06003682 RID: 13954 RVA: 0x0010B118 File Offset: 0x00109318
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TransactionID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x0010B1A4 File Offset: 0x001093A4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
			this.TransactionID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x0001DCA8 File Offset: 0x0001BEA8
		private void InitRefTypes()
		{
			this.SteamID = 0UL;
			this.TransactionID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D8B RID: 7563
		public const uint cPacketType = 4238955084u;
	}
}
