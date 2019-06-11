using System;

namespace NetworkProtocols
{
	// Token: 0x020005FF RID: 1535
	public class ResponseOfflineTutorialStatus : BotNetMessage
	{
		// Token: 0x0600356F RID: 13679 RVA: 0x0001CFB5 File Offset: 0x0001B1B5
		public ResponseOfflineTutorialStatus()
		{
			this.InitRefTypes();
			base.PacketType = 3744745478u;
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0001CFCE File Offset: 0x0001B1CE
		public ResponseOfflineTutorialStatus(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3744745478u;
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06003571 RID: 13681 RVA: 0x0001CFEE File Offset: 0x0001B1EE
		// (set) Token: 0x06003572 RID: 13682 RVA: 0x0001CFF6 File Offset: 0x0001B1F6
		public eAccountDataEventCodes ResponseCode { get; set; }

		// Token: 0x06003573 RID: 13683 RVA: 0x00109378 File Offset: 0x00107578
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
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.ResponseCode);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x001093F8 File Offset: 0x001075F8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ResponseCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0001CFFF File Offset: 0x0001B1FF
		private void InitRefTypes()
		{
			this.ResponseCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D2D RID: 7469
		public const uint cPacketType = 3744745478u;
	}
}
