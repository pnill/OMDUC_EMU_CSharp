using System;

namespace NetworkProtocols
{
	// Token: 0x020005FE RID: 1534
	public class RequestOfflineTutorialCompleted : BotNetMessage
	{
		// Token: 0x06003564 RID: 13668 RVA: 0x0001CF28 File Offset: 0x0001B128
		public RequestOfflineTutorialCompleted()
		{
			this.InitRefTypes();
			base.PacketType = 3369131528u;
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x0001CF41 File Offset: 0x0001B141
		public RequestOfflineTutorialCompleted(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3369131528u;
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x0001CF61 File Offset: 0x0001B161
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x0001CF69 File Offset: 0x0001B169
		public ulong GameMapID { get; set; }

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x0001CF72 File Offset: 0x0001B172
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x0001CF7A File Offset: 0x0001B17A
		public ulong CampaignID { get; set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x0001CF83 File Offset: 0x0001B183
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x0001CF8B File Offset: 0x0001B18B
		public ulong MissionID { get; set; }

		// Token: 0x0600356C RID: 13676 RVA: 0x00109258 File Offset: 0x00107458
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CampaignID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MissionID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x001092F4 File Offset: 0x001074F4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.CampaignID = ArrayManager.ReadUInt64(data, ref num);
			this.MissionID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x0001CF94 File Offset: 0x0001B194
		private void InitRefTypes()
		{
			this.GameMapID = 0UL;
			this.CampaignID = 0UL;
			this.MissionID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D29 RID: 7465
		public const uint cPacketType = 3369131528u;
	}
}
