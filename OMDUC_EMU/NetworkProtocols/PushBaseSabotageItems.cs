using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005AC RID: 1452
	public class PushBaseSabotageItems : BotNetMessage
	{
		// Token: 0x06003285 RID: 12933 RVA: 0x0001B2EB File Offset: 0x000194EB
		public PushBaseSabotageItems()
		{
			this.InitRefTypes();
			base.PacketType = 1585384496u;
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x0001B304 File Offset: 0x00019504
		public PushBaseSabotageItems(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1585384496u;
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x0001B324 File Offset: 0x00019524
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x0001B32C File Offset: 0x0001952C
		public List<ulong> ItemGUIDs { get; set; }

		// Token: 0x06003289 RID: 12937 RVA: 0x001053D4 File Offset: 0x001035D4
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
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.ItemGUIDs);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00105454 File Offset: 0x00103654
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ItemGUIDs = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x0001B335 File Offset: 0x00019535
		private void InitRefTypes()
		{
			this.ItemGUIDs = new List<ulong>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C54 RID: 7252
		public const uint cPacketType = 1585384496u;
	}
}
