using System;

namespace NetworkProtocols
{
	// Token: 0x02000647 RID: 1607
	public class NotifyCampaignStarted : BotNetMessage
	{
		// Token: 0x06003812 RID: 14354 RVA: 0x0001ECED File Offset: 0x0001CEED
		public NotifyCampaignStarted()
		{
			this.InitRefTypes();
			base.PacketType = 1834887503u;
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0001ED06 File Offset: 0x0001CF06
		public NotifyCampaignStarted(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1834887503u;
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x0001ED26 File Offset: 0x0001CF26
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x0001ED2E File Offset: 0x0001CF2E
		public ulong CampaignID { get; set; }

		// Token: 0x06003816 RID: 14358 RVA: 0x0010D564 File Offset: 0x0010B764
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

		// Token: 0x06003817 RID: 14359 RVA: 0x0010D5E4 File Offset: 0x0010B7E4
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

		// Token: 0x06003818 RID: 14360 RVA: 0x0001ED37 File Offset: 0x0001CF37
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E07 RID: 7687
		public const uint cPacketType = 1834887503u;
	}
}
