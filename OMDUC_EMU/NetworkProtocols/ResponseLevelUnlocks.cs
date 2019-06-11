using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005A6 RID: 1446
	public class ResponseLevelUnlocks : BotNetMessage
	{
		// Token: 0x06003249 RID: 12873 RVA: 0x0001B0C2 File Offset: 0x000192C2
		public ResponseLevelUnlocks()
		{
			this.InitRefTypes();
			base.PacketType = 2554349678u;
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x0001B0DB File Offset: 0x000192DB
		public ResponseLevelUnlocks(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2554349678u;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x0001B0FB File Offset: 0x000192FB
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x0001B103 File Offset: 0x00019303
		public List<PacketLevelUnlock> Unlocks { get; set; }

		// Token: 0x0600324D RID: 12877 RVA: 0x00104F2C File Offset: 0x0010312C
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
			ArrayManager.WriteListPacketLevelUnlock(ref newArray, ref newSize, this.Unlocks);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00104FAC File Offset: 0x001031AC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Unlocks = ArrayManager.ReadListPacketLevelUnlock(data, ref num);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x0001B10C File Offset: 0x0001930C
		private void InitRefTypes()
		{
			this.Unlocks = new List<PacketLevelUnlock>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C41 RID: 7233
		public const uint cPacketType = 2554349678u;
	}
}
