using System;

namespace NetworkProtocols
{
	// Token: 0x02000487 RID: 1159
	public class RequestLeaveChatRoom : BotNetMessage
	{
		// Token: 0x060029F5 RID: 10741 RVA: 0x00015D2A File Offset: 0x00013F2A
		public RequestLeaveChatRoom()
		{
			this.InitRefTypes();
			base.PacketType = 2627607225u;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00015D43 File Offset: 0x00013F43
		public RequestLeaveChatRoom(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2627607225u;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x00015D63 File Offset: 0x00013F63
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00015D6B File Offset: 0x00013F6B
		public ulong ChatID { get; set; }

		// Token: 0x060029F9 RID: 10745 RVA: 0x000FA7A8 File Offset: 0x000F89A8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000FA828 File Offset: 0x000F8A28
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00015D74 File Offset: 0x00013F74
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016C4 RID: 5828
		public const uint cPacketType = 2627607225u;
	}
}
