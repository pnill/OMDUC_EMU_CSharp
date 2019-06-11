using System;

namespace NetworkProtocols
{
	// Token: 0x02000646 RID: 1606
	public class ResponseStartCampaignMission : BotNetMessage
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x0001EC93 File Offset: 0x0001CE93
		public ResponseStartCampaignMission()
		{
			this.InitRefTypes();
			base.PacketType = 897501723u;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		public ResponseStartCampaignMission(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 897501723u;
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x0001ECCC File Offset: 0x0001CECC
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x0001ECD4 File Offset: 0x0001CED4
		public eCampaignOperationStatus Status { get; set; }

		// Token: 0x0600380F RID: 14351 RVA: 0x0010D47C File Offset: 0x0010B67C
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
			ArrayManager.WriteeCampaignOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x0010D4FC File Offset: 0x0010B6FC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeCampaignOperationStatus(data, ref num);
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x0001ECDD File Offset: 0x0001CEDD
		private void InitRefTypes()
		{
			this.Status = eCampaignOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E05 RID: 7685
		public const uint cPacketType = 897501723u;
	}
}
