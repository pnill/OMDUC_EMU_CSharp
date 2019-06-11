using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004DF RID: 1247
	public class RequestRemoveNewInventoryFlag : BotNetMessage
	{
		// Token: 0x06002B38 RID: 11064 RVA: 0x00016C76 File Offset: 0x00014E76
		public RequestRemoveNewInventoryFlag()
		{
			this.InitRefTypes();
			base.PacketType = 2491272374u;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00016C8F File Offset: 0x00014E8F
		public RequestRemoveNewInventoryFlag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2491272374u;
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x00016CAF File Offset: 0x00014EAF
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x00016CB7 File Offset: 0x00014EB7
		public ulong AccountSUID { get; set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x00016CC0 File Offset: 0x00014EC0
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x00016CC8 File Offset: 0x00014EC8
		public List<ulong> NonNewInventoryList { get; set; }

		// Token: 0x06002B3E RID: 11070 RVA: 0x000FC5A8 File Offset: 0x000FA7A8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.NonNewInventoryList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000FC634 File Offset: 0x000FA834
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.NonNewInventoryList = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00016CD1 File Offset: 0x00014ED1
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.NonNewInventoryList = new List<ulong>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A29 RID: 6697
		public const uint cPacketType = 2491272374u;
	}
}
