using System;

namespace NetworkProtocols
{
	// Token: 0x02000493 RID: 1171
	public class RequestLeaveDiscordChannel : BotNetMessage
	{
		// Token: 0x06002A61 RID: 10849 RVA: 0x000162A7 File Offset: 0x000144A7
		public RequestLeaveDiscordChannel()
		{
			this.InitRefTypes();
			base.PacketType = 1473617704u;
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000162C0 File Offset: 0x000144C0
		public RequestLeaveDiscordChannel(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1473617704u;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x000162E0 File Offset: 0x000144E0
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x000162E8 File Offset: 0x000144E8
		public ulong ChatID { get; set; }

		// Token: 0x06002A65 RID: 10853 RVA: 0x000FB3E0 File Offset: 0x000F95E0
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000FB460 File Offset: 0x000F9660
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
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000162F1 File Offset: 0x000144F1
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016E8 RID: 5864
		public const uint cPacketType = 1473617704u;
	}
}
