using System;

namespace NetworkProtocols
{
	// Token: 0x02000483 RID: 1155
	public class RequestCreateWhisperChatRoom : BotNetMessage
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x00015B1D File Offset: 0x00013D1D
		public RequestCreateWhisperChatRoom()
		{
			this.InitRefTypes();
			base.PacketType = 3746523256u;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00015B36 File Offset: 0x00013D36
		public RequestCreateWhisperChatRoom(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3746523256u;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x00015B56 File Offset: 0x00013D56
		// (set) Token: 0x060029CA RID: 10698 RVA: 0x00015B5E File Offset: 0x00013D5E
		public ulong AccountSUID { get; set; }

		// Token: 0x060029CB RID: 10699 RVA: 0x000FA2B0 File Offset: 0x000F84B0
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

		// Token: 0x060029CC RID: 10700 RVA: 0x000FA330 File Offset: 0x000F8530
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

		// Token: 0x060029CD RID: 10701 RVA: 0x00015B67 File Offset: 0x00013D67
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016B3 RID: 5811
		public const uint cPacketType = 3746523256u;
	}
}
