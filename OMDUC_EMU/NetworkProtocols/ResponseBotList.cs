using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006B8 RID: 1720
	public class ResponseBotList : BotNetMessage
	{
		// Token: 0x06003DA5 RID: 15781 RVA: 0x000227D3 File Offset: 0x000209D3
		public ResponseBotList()
		{
			this.InitRefTypes();
			base.PacketType = 1681602214u;
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x000227EC File Offset: 0x000209EC
		public ResponseBotList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1681602214u;
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x0002280C File Offset: 0x00020A0C
		// (set) Token: 0x06003DA8 RID: 15784 RVA: 0x00022814 File Offset: 0x00020A14
		public List<BotDetail> BotDetails { get; set; }

		// Token: 0x06003DA9 RID: 15785 RVA: 0x0011573C File Offset: 0x0011393C
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
			ArrayManager.WriteListBotDetail(ref newArray, ref newSize, this.BotDetails);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x001157BC File Offset: 0x001139BC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.BotDetails = ArrayManager.ReadListBotDetail(data, ref num);
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x0002281D File Offset: 0x00020A1D
		private void InitRefTypes()
		{
			this.BotDetails = new List<BotDetail>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002079 RID: 8313
		public const uint cPacketType = 1681602214u;
	}
}
