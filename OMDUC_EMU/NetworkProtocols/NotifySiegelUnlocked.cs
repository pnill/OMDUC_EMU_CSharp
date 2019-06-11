using System;

namespace NetworkProtocols
{
	// Token: 0x02000649 RID: 1609
	public class NotifySiegelUnlocked : BotNetMessage
	{
		// Token: 0x06003820 RID: 14368 RVA: 0x0001EDA3 File Offset: 0x0001CFA3
		public NotifySiegelUnlocked()
		{
			this.InitRefTypes();
			base.PacketType = 3397352908u;
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0001EDBC File Offset: 0x0001CFBC
		public NotifySiegelUnlocked(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3397352908u;
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x0001EDDC File Offset: 0x0001CFDC
		// (set) Token: 0x06003823 RID: 14371 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		public ulong CampaignID { get; set; }

		// Token: 0x06003824 RID: 14372 RVA: 0x0010D734 File Offset: 0x0010B934
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

		// Token: 0x06003825 RID: 14373 RVA: 0x0010D7B4 File Offset: 0x0010B9B4
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

		// Token: 0x06003826 RID: 14374 RVA: 0x0001EDED File Offset: 0x0001CFED
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E0B RID: 7691
		public const uint cPacketType = 3397352908u;
	}
}
