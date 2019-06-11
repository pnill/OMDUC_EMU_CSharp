using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006B9 RID: 1721
	public class RequestLobbyUpdateDeck : BotNetMessage
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x00022831 File Offset: 0x00020A31
		public RequestLobbyUpdateDeck()
		{
			this.InitRefTypes();
			base.PacketType = 2076770114u;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x0002284A File Offset: 0x00020A4A
		public RequestLobbyUpdateDeck(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2076770114u;
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x0002286A File Offset: 0x00020A6A
		// (set) Token: 0x06003DAF RID: 15791 RVA: 0x00022872 File Offset: 0x00020A72
		public ulong LobbyID { get; set; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x0002287B File Offset: 0x00020A7B
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x00022883 File Offset: 0x00020A83
		public ulong DeckGUID { get; set; }

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x0002288C File Offset: 0x00020A8C
		// (set) Token: 0x06003DB3 RID: 15795 RVA: 0x00022894 File Offset: 0x00020A94
		public List<RequestPlayerPostDeckUpdateDetail> Items { get; set; }

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x0002289D File Offset: 0x00020A9D
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x000228A5 File Offset: 0x00020AA5
		public bool ForceUpdate { get; set; }

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x000228AE File Offset: 0x00020AAE
		// (set) Token: 0x06003DB7 RID: 15799 RVA: 0x000228B6 File Offset: 0x00020AB6
		public string Name { get; set; }

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00115824 File Offset: 0x00113A24
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LobbyID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.DeckGUID);
			ArrayManager.WriteListRequestPlayerPostDeckUpdateDetail(ref newArray, ref newSize, this.Items);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ForceUpdate);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001158E0 File Offset: 0x00113AE0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LobbyID = ArrayManager.ReadUInt64(data, ref num);
			this.DeckGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Items = ArrayManager.ReadListRequestPlayerPostDeckUpdateDetail(data, ref num);
			this.ForceUpdate = ArrayManager.ReadBoolean(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x000228BF File Offset: 0x00020ABF
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.DeckGUID = 0UL;
			this.Items = new List<RequestPlayerPostDeckUpdateDetail>();
			this.ForceUpdate = false;
			this.Name = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400207B RID: 8315
		public const uint cPacketType = 2076770114u;
	}
}
