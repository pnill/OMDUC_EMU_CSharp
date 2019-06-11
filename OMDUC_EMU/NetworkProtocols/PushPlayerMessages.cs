using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000626 RID: 1574
	public class PushPlayerMessages : BotNetMessage
	{
		// Token: 0x060036D6 RID: 14038 RVA: 0x0001E088 File Offset: 0x0001C288
		public PushPlayerMessages()
		{
			this.InitRefTypes();
			base.PacketType = 857812130u;
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x0001E0A1 File Offset: 0x0001C2A1
		public PushPlayerMessages(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 857812130u;
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x0001E0C1 File Offset: 0x0001C2C1
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x0001E0C9 File Offset: 0x0001C2C9
		public List<NetworkPlayerMessage> Messages { get; set; }

		// Token: 0x060036DA RID: 14042 RVA: 0x0010B998 File Offset: 0x00109B98
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

		// Token: 0x060036DB RID: 14043 RVA: 0x0010BA18 File Offset: 0x00109C18
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

		// Token: 0x060036DC RID: 14044 RVA: 0x0001E0D2 File Offset: 0x0001C2D2
		private void InitRefTypes()
		{
			this.Messages = new List<NetworkPlayerMessage>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DA6 RID: 7590
		public const uint cPacketType = 857812130u;
	}
}
