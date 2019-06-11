using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000650 RID: 1616
	public class ResponseLobbyDeckList : BotNetMessage
	{
		// Token: 0x06003859 RID: 14425 RVA: 0x0001F023 File Offset: 0x0001D223
		public ResponseLobbyDeckList()
		{
			this.InitRefTypes();
			base.PacketType = 2457735052u;
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x0001F03C File Offset: 0x0001D23C
		public ResponseLobbyDeckList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2457735052u;
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x0001F05C File Offset: 0x0001D25C
		// (set) Token: 0x0600385C RID: 14428 RVA: 0x0001F064 File Offset: 0x0001D264
		public eLobbyRequestResult Result { get; set; }

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x0001F06D File Offset: 0x0001D26D
		// (set) Token: 0x0600385E RID: 14430 RVA: 0x0001F075 File Offset: 0x0001D275
		public List<DeckEntry> Decks { get; set; }

		// Token: 0x0600385F RID: 14431 RVA: 0x0010DD14 File Offset: 0x0010BF14
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
			ArrayManager.WriteeLobbyRequestResult(ref newArray, ref newSize, this.Result);
			ArrayManager.WriteListDeckEntry(ref newArray, ref newSize, this.Decks);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0010DDA0 File Offset: 0x0010BFA0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Result = ArrayManager.ReadeLobbyRequestResult(data, ref num);
			this.Decks = ArrayManager.ReadListDeckEntry(data, ref num);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0001F07E File Offset: 0x0001D27E
		private void InitRefTypes()
		{
			this.Result = eLobbyRequestResult.LobbyRequest_Succeeded;
			this.Decks = new List<DeckEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E1C RID: 7708
		public const uint cPacketType = 2457735052u;
	}
}
