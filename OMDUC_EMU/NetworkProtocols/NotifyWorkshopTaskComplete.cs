using System;

namespace NetworkProtocols
{
	// Token: 0x0200064A RID: 1610
	public class NotifyWorkshopTaskComplete : BotNetMessage
	{
		// Token: 0x06003827 RID: 14375 RVA: 0x0001EDFE File Offset: 0x0001CFFE
		public NotifyWorkshopTaskComplete()
		{
			this.InitRefTypes();
			base.PacketType = 2795266388u;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x0001EE17 File Offset: 0x0001D017
		public NotifyWorkshopTaskComplete(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2795266388u;
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x0001EE37 File Offset: 0x0001D037
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x0001EE3F File Offset: 0x0001D03F
		public ulong CampaignID { get; set; }

		// Token: 0x0600382B RID: 14379 RVA: 0x0010D81C File Offset: 0x0010BA1C
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

		// Token: 0x0600382C RID: 14380 RVA: 0x0010D89C File Offset: 0x0010BA9C
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

		// Token: 0x0600382D RID: 14381 RVA: 0x0001EE48 File Offset: 0x0001D048
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E0D RID: 7693
		public const uint cPacketType = 2795266388u;
	}
}
