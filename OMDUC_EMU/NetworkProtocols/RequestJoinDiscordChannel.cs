using System;

namespace NetworkProtocols
{
	// Token: 0x02000491 RID: 1169
	public class RequestJoinDiscordChannel : BotNetMessage
	{
		// Token: 0x06002A4D RID: 10829 RVA: 0x000161A5 File Offset: 0x000143A5
		public RequestJoinDiscordChannel()
		{
			this.InitRefTypes();
			base.PacketType = 3477421501u;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000161BE File Offset: 0x000143BE
		public RequestJoinDiscordChannel(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3477421501u;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000161DE File Offset: 0x000143DE
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x000161E6 File Offset: 0x000143E6
		public ulong ChatID { get; set; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000161EF File Offset: 0x000143EF
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x000161F7 File Offset: 0x000143F7
		public uint Team { get; set; }

		// Token: 0x06002A53 RID: 10835 RVA: 0x000FB1BC File Offset: 0x000F93BC
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Team);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000FB248 File Offset: 0x000F9448
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
			this.Team = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00016200 File Offset: 0x00014400
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.Team = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016E1 RID: 5857
		public const uint cPacketType = 3477421501u;
	}
}
