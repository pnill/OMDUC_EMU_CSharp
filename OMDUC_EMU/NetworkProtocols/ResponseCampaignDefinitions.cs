using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200063E RID: 1598
	public class ResponseCampaignDefinitions : BotNetMessage
	{
		// Token: 0x060037A8 RID: 14248 RVA: 0x0001E86B File Offset: 0x0001CA6B
		public ResponseCampaignDefinitions()
		{
			this.InitRefTypes();
			base.PacketType = 2660770430u;
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0001E884 File Offset: 0x0001CA84
		public ResponseCampaignDefinitions(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2660770430u;
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x0001E8A4 File Offset: 0x0001CAA4
		// (set) Token: 0x060037AB RID: 14251 RVA: 0x0001E8AC File Offset: 0x0001CAAC
		public List<PacketCampaign> Campaigns { get; set; }

		// Token: 0x060037AC RID: 14252 RVA: 0x0010CBF4 File Offset: 0x0010ADF4
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
			ArrayManager.WriteListPacketCampaign(ref newArray, ref newSize, this.Campaigns);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0010CC74 File Offset: 0x0010AE74
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Campaigns = ArrayManager.ReadListPacketCampaign(data, ref num);
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x0001E8B5 File Offset: 0x0001CAB5
		private void InitRefTypes()
		{
			this.Campaigns = new List<PacketCampaign>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DE1 RID: 7649
		public const uint cPacketType = 2660770430u;
	}
}
