using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200064C RID: 1612
	public class PushPlayerBoostStatus : BotNetMessage
	{
		// Token: 0x06003838 RID: 14392 RVA: 0x0001EE9A File Offset: 0x0001D09A
		public PushPlayerBoostStatus()
		{
			this.InitRefTypes();
			base.PacketType = 1542079736u;
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0001EEB3 File Offset: 0x0001D0B3
		public PushPlayerBoostStatus(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1542079736u;
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		// (set) Token: 0x0600383B RID: 14395 RVA: 0x0001EEDB File Offset: 0x0001D0DB
		public List<PlayerBoostStatus> PlayerBoosts { get; set; }

		// Token: 0x0600383C RID: 14396 RVA: 0x0010D9B8 File Offset: 0x0010BBB8
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
			ArrayManager.WriteListPlayerBoostStatus(ref newArray, ref newSize, this.PlayerBoosts);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0010DA38 File Offset: 0x0010BC38
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerBoosts = ArrayManager.ReadListPlayerBoostStatus(data, ref num);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		private void InitRefTypes()
		{
			this.PlayerBoosts = new List<PlayerBoostStatus>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E12 RID: 7698
		public const uint cPacketType = 1542079736u;
	}
}
