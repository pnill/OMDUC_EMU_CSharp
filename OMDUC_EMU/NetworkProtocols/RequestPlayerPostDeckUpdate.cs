using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004EC RID: 1260
	public class RequestPlayerPostDeckUpdate : BotNetMessage
	{
		// Token: 0x06002BA2 RID: 11170 RVA: 0x0001715B File Offset: 0x0001535B
		public RequestPlayerPostDeckUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 2772066866u;
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00017174 File Offset: 0x00015374
		public RequestPlayerPostDeckUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2772066866u;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x00017194 File Offset: 0x00015394
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x0001719C File Offset: 0x0001539C
		public ulong DeckGUID { get; set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000171A5 File Offset: 0x000153A5
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x000171AD File Offset: 0x000153AD
		public List<RequestPlayerPostDeckUpdateDetail> Items { get; set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000171B6 File Offset: 0x000153B6
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x000171BE File Offset: 0x000153BE
		public bool ForceUpdate { get; set; }

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000171C7 File Offset: 0x000153C7
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x000171CF File Offset: 0x000153CF
		public string Name { get; set; }

		// Token: 0x06002BAC RID: 11180 RVA: 0x000FCE3C File Offset: 0x000FB03C
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
			ArrayManager.WriteListRequestPlayerPostDeckUpdateDetail(ref newArray, ref newSize, this.Items);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ForceUpdate);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000FCEE8 File Offset: 0x000FB0E8
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
			this.Items = ArrayManager.ReadListRequestPlayerPostDeckUpdateDetail(data, ref num);
			this.ForceUpdate = ArrayManager.ReadBoolean(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000171D8 File Offset: 0x000153D8
		private void InitRefTypes()
		{
			this.DeckGUID = 0UL;
			this.Items = new List<RequestPlayerPostDeckUpdateDetail>();
			this.ForceUpdate = false;
			this.Name = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A49 RID: 6729
		public const uint cPacketType = 2772066866u;
	}
}
