using System;

namespace NetworkProtocols
{
	// Token: 0x02000648 RID: 1608
	public class NotifySurvivalUnlocked : BotNetMessage
	{
		// Token: 0x06003819 RID: 14361 RVA: 0x0001ED48 File Offset: 0x0001CF48
		public NotifySurvivalUnlocked()
		{
			this.InitRefTypes();
			base.PacketType = 564608164u;
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x0001ED61 File Offset: 0x0001CF61
		public NotifySurvivalUnlocked(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 564608164u;
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x0001ED81 File Offset: 0x0001CF81
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x0001ED89 File Offset: 0x0001CF89
		public ulong CampaignID { get; set; }

		// Token: 0x0600381D RID: 14365 RVA: 0x0010D64C File Offset: 0x0010B84C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CampaignID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x0010D6CC File Offset: 0x0010B8CC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CampaignID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x0001ED92 File Offset: 0x0001CF92
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E09 RID: 7689
		public const uint cPacketType = 564608164u;
	}
}
