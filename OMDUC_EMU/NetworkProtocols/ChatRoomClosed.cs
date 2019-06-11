using System;

namespace NetworkProtocols
{
	// Token: 0x0200048A RID: 1162
	public class ChatRoomClosed : BotNetMessage
	{
		// Token: 0x06002A16 RID: 10774 RVA: 0x00015ED5 File Offset: 0x000140D5
		public ChatRoomClosed()
		{
			this.InitRefTypes();
			base.PacketType = 715640203u;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00015EEE File Offset: 0x000140EE
		public ChatRoomClosed(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 715640203u;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x00015F0E File Offset: 0x0001410E
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x00015F16 File Offset: 0x00014116
		public ulong ChatID { get; set; }

		// Token: 0x06002A1A RID: 10778 RVA: 0x000FAB10 File Offset: 0x000F8D10
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

		// Token: 0x06002A1B RID: 10779 RVA: 0x000FAB90 File Offset: 0x000F8D90
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

		// Token: 0x06002A1C RID: 10780 RVA: 0x00015F1F File Offset: 0x0001411F
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016D0 RID: 5840
		public const uint cPacketType = 715640203u;
	}
}
