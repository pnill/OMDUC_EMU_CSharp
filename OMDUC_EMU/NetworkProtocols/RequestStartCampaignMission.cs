using System;

namespace NetworkProtocols
{
	// Token: 0x02000645 RID: 1605
	public class RequestStartCampaignMission : BotNetMessage
	{
		// Token: 0x06003802 RID: 14338 RVA: 0x0001EC1F File Offset: 0x0001CE1F
		public RequestStartCampaignMission()
		{
			this.InitRefTypes();
			base.PacketType = 206523056u;
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x0001EC38 File Offset: 0x0001CE38
		public RequestStartCampaignMission(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 206523056u;
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x0001EC58 File Offset: 0x0001CE58
		// (set) Token: 0x06003805 RID: 14341 RVA: 0x0001EC60 File Offset: 0x0001CE60
		public ulong CampaignID { get; set; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x0001EC69 File Offset: 0x0001CE69
		// (set) Token: 0x06003807 RID: 14343 RVA: 0x0001EC71 File Offset: 0x0001CE71
		public ulong MissionID { get; set; }

		// Token: 0x06003808 RID: 14344 RVA: 0x0010D378 File Offset: 0x0010B578
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MissionID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x0010D404 File Offset: 0x0010B604
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
			this.MissionID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x0001EC7A File Offset: 0x0001CE7A
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			this.MissionID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E02 RID: 7682
		public const uint cPacketType = 206523056u;
	}
}
