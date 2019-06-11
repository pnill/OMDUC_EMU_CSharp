using System;

namespace NetworkProtocols
{
	// Token: 0x020006F7 RID: 1783
	public class ResponsePartyChatID : BotNetMessage
	{
		// Token: 0x06003FAD RID: 16301 RVA: 0x000240E9 File Offset: 0x000222E9
		public ResponsePartyChatID()
		{
			this.InitRefTypes();
			base.PacketType = 2490562218u;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00024102 File Offset: 0x00022302
		public ResponsePartyChatID(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2490562218u;
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x00024122 File Offset: 0x00022322
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x0002412A File Offset: 0x0002232A
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x00024133 File Offset: 0x00022333
		// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x0002413B File Offset: 0x0002233B
		public ulong PartyID { get; set; }

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x00024144 File Offset: 0x00022344
		// (set) Token: 0x06003FB4 RID: 16308 RVA: 0x0002414C File Offset: 0x0002234C
		public ulong ChatID { get; set; }

		// Token: 0x06003FB5 RID: 16309 RVA: 0x0011C01C File Offset: 0x0011A21C
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
			ArrayManager.WriteePartyOperationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x0011C0B8 File Offset: 0x0011A2B8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadePartyOperationStatus(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00024155 File Offset: 0x00022355
		private void InitRefTypes()
		{
			this.Status = ePartyOperationStatus.Failure;
			this.PartyID = 0UL;
			this.ChatID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400216B RID: 8555
		public const uint cPacketType = 2490562218u;
	}
}
