using System;

namespace NetworkProtocols
{
	// Token: 0x0200048C RID: 1164
	public class RequestChatFilterOptionChange : BotNetMessage
	{
		// Token: 0x06002A26 RID: 10790 RVA: 0x00015FA7 File Offset: 0x000141A7
		public RequestChatFilterOptionChange()
		{
			this.InitRefTypes();
			base.PacketType = 1350491743u;
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00015FC0 File Offset: 0x000141C0
		public RequestChatFilterOptionChange(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1350491743u;
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00015FE0 File Offset: 0x000141E0
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x00015FE8 File Offset: 0x000141E8
		public bool DisableChatFilter { get; set; }

		// Token: 0x06002A2A RID: 10794 RVA: 0x000FACFC File Offset: 0x000F8EFC
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.DisableChatFilter);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000FAD7C File Offset: 0x000F8F7C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.DisableChatFilter = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00015FF1 File Offset: 0x000141F1
		private void InitRefTypes()
		{
			this.DisableChatFilter = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016D5 RID: 5845
		public const uint cPacketType = 1350491743u;
	}
}
