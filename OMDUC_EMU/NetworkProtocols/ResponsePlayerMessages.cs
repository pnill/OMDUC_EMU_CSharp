using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200063B RID: 1595
	public class ResponsePlayerMessages : BotNetMessage
	{
		// Token: 0x0600377D RID: 14205 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
		public ResponsePlayerMessages()
		{
			this.InitRefTypes();
			base.PacketType = 2618955242u;
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0001E6F1 File Offset: 0x0001C8F1
		public ResponsePlayerMessages(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2618955242u;
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x0001E711 File Offset: 0x0001C911
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x0001E719 File Offset: 0x0001C919
		public List<NetworkPlayerMessage> Messages { get; set; }

		// Token: 0x06003781 RID: 14209 RVA: 0x0010C8B0 File Offset: 0x0010AAB0
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
			ArrayManager.WriteListNetworkPlayerMessage(ref newArray, ref newSize, this.Messages);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0010C930 File Offset: 0x0010AB30
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Messages = ArrayManager.ReadListNetworkPlayerMessage(data, ref num);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0001E722 File Offset: 0x0001C922
		private void InitRefTypes()
		{
			this.Messages = new List<NetworkPlayerMessage>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DD1 RID: 7633
		public const uint cPacketType = 2618955242u;
	}
}
