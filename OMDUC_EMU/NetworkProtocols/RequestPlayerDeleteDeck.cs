using System;

namespace NetworkProtocols
{
	// Token: 0x020004E8 RID: 1256
	public class RequestPlayerDeleteDeck : BotNetMessage
	{
		// Token: 0x06002B7D RID: 11133 RVA: 0x00016F99 File Offset: 0x00015199
		public RequestPlayerDeleteDeck()
		{
			this.InitRefTypes();
			base.PacketType = 2241291131u;
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00016FB2 File Offset: 0x000151B2
		public RequestPlayerDeleteDeck(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2241291131u;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x00016FD2 File Offset: 0x000151D2
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x00016FDA File Offset: 0x000151DA
		public ulong DeckGUID { get; set; }

		// Token: 0x06002B81 RID: 11137 RVA: 0x000FCAAC File Offset: 0x000FACAC
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckGUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000FCB2C File Offset: 0x000FAD2C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.DeckGUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00016FE3 File Offset: 0x000151E3
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A3D RID: 6717
		public const uint cPacketType = 2241291131u;
	}
}
