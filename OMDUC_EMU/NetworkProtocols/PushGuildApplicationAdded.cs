using System;

namespace NetworkProtocols
{
	// Token: 0x02000762 RID: 1890
	public class PushGuildApplicationAdded : BotNetMessage
	{
		// Token: 0x06004313 RID: 17171 RVA: 0x000268ED File Offset: 0x00024AED
		public PushGuildApplicationAdded()
		{
			this.InitRefTypes();
			base.PacketType = 2733645551u;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00026906 File Offset: 0x00024B06
		public PushGuildApplicationAdded(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2733645551u;
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x00026926 File Offset: 0x00024B26
		// (set) Token: 0x06004316 RID: 17174 RVA: 0x0002692E File Offset: 0x00024B2E
		public GuildApplication AddedApplication { get; set; }

		// Token: 0x06004317 RID: 17175 RVA: 0x00121778 File Offset: 0x0011F978
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
			ArrayManager.WriteGuildApplication(ref newArray, ref newSize, this.AddedApplication);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x001217F8 File Offset: 0x0011F9F8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AddedApplication = ArrayManager.ReadGuildApplication(data, ref num);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00026937 File Offset: 0x00024B37
		private void InitRefTypes()
		{
			this.AddedApplication = new GuildApplication();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022F3 RID: 8947
		public const uint cPacketType = 2733645551u;
	}
}
