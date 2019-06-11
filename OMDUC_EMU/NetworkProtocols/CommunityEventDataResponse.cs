using System;

namespace NetworkProtocols
{
	// Token: 0x0200066A RID: 1642
	public class CommunityEventDataResponse : BotNetMessage
	{
		// Token: 0x0600399B RID: 14747 RVA: 0x0001FD08 File Offset: 0x0001DF08
		public CommunityEventDataResponse()
		{
			this.InitRefTypes();
			base.PacketType = 3030360695u;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0001FD21 File Offset: 0x0001DF21
		public CommunityEventDataResponse(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3030360695u;
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x0001FD41 File Offset: 0x0001DF41
		// (set) Token: 0x0600399E RID: 14750 RVA: 0x0001FD49 File Offset: 0x0001DF49
		public PlayerCommunityEventsForNetwork CommunityEventData { get; set; }

		// Token: 0x0600399F RID: 14751 RVA: 0x0010F974 File Offset: 0x0010DB74
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
			ArrayManager.WritePlayerCommunityEventsForNetwork(ref newArray, ref newSize, this.CommunityEventData);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x0010F9F4 File Offset: 0x0010DBF4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CommunityEventData = ArrayManager.ReadPlayerCommunityEventsForNetwork(data, ref num);
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x0001FD52 File Offset: 0x0001DF52
		private void InitRefTypes()
		{
			this.CommunityEventData = new PlayerCommunityEventsForNetwork();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E92 RID: 7826
		public const uint cPacketType = 3030360695u;
	}
}
