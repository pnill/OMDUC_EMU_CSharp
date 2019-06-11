using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200065F RID: 1631
	public class PushPlayerMMR : BotNetMessage
	{
		// Token: 0x060038E9 RID: 14569 RVA: 0x0001F692 File Offset: 0x0001D892
		public PushPlayerMMR()
		{
			this.InitRefTypes();
			base.PacketType = 3272185746u;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0001F6AB File Offset: 0x0001D8AB
		public PushPlayerMMR(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3272185746u;
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x0001F6CB File Offset: 0x0001D8CB
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0001F6D3 File Offset: 0x0001D8D3
		public List<MMREntry> PlayerMMR { get; set; }

		// Token: 0x060038ED RID: 14573 RVA: 0x0010EB0C File Offset: 0x0010CD0C
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
			ArrayManager.WriteListMMREntry(ref newArray, ref newSize, this.PlayerMMR);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0010EB8C File Offset: 0x0010CD8C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerMMR = ArrayManager.ReadListMMREntry(data, ref num);
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0001F6DC File Offset: 0x0001D8DC
		private void InitRefTypes()
		{
			this.PlayerMMR = new List<MMREntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E4C RID: 7756
		public const uint cPacketType = 3272185746u;
	}
}
