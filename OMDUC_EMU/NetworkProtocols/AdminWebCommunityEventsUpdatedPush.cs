using System;

namespace NetworkProtocols
{
	// Token: 0x020004DA RID: 1242
	public class AdminWebCommunityEventsUpdatedPush : BotNetMessage
	{
		// Token: 0x06002B0D RID: 11021 RVA: 0x00016A4D File Offset: 0x00014C4D
		public AdminWebCommunityEventsUpdatedPush()
		{
			this.InitRefTypes();
			base.PacketType = 4116074322u;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00016A66 File Offset: 0x00014C66
		public AdminWebCommunityEventsUpdatedPush(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4116074322u;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x00016A86 File Offset: 0x00014C86
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00016A8E File Offset: 0x00014C8E
		public ulong CommunityEventsID { get; set; }

		// Token: 0x06002B11 RID: 11025 RVA: 0x000FC178 File Offset: 0x000FA378
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CommunityEventsID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000FC1F8 File Offset: 0x000FA3F8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CommunityEventsID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00016A97 File Offset: 0x00014C97
		private void InitRefTypes()
		{
			this.CommunityEventsID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A1B RID: 6683
		public const uint cPacketType = 4116074322u;
	}
}
