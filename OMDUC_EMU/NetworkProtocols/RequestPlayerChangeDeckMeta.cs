using System;

namespace NetworkProtocols
{
	// Token: 0x020004EA RID: 1258
	public class RequestPlayerChangeDeckMeta : BotNetMessage
	{
		// Token: 0x06002B8F RID: 11151 RVA: 0x00017087 File Offset: 0x00015287
		public RequestPlayerChangeDeckMeta()
		{
			this.InitRefTypes();
			base.PacketType = 1900803170u;
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x000170A0 File Offset: 0x000152A0
		public RequestPlayerChangeDeckMeta(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1900803170u;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000170C0 File Offset: 0x000152C0
		// (set) Token: 0x06002B92 RID: 11154 RVA: 0x000170C8 File Offset: 0x000152C8
		public ulong DeckGUID { get; set; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000170D1 File Offset: 0x000152D1
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x000170D9 File Offset: 0x000152D9
		public string DeckName { get; set; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000170E2 File Offset: 0x000152E2
		// (set) Token: 0x06002B96 RID: 11158 RVA: 0x000170EA File Offset: 0x000152EA
		public string DeckIcon { get; set; }

		// Token: 0x06002B97 RID: 11159 RVA: 0x000FCCB4 File Offset: 0x000FAEB4
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.DeckName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.DeckIcon);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000FCD50 File Offset: 0x000FAF50
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
			this.DeckName = ArrayManager.ReadString(data, ref num);
			this.DeckIcon = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000170F3 File Offset: 0x000152F3
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			this.DeckName = string.Empty;
			this.DeckIcon = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A43 RID: 6723
		public const uint cPacketType = 1900803170u;
	}
}
