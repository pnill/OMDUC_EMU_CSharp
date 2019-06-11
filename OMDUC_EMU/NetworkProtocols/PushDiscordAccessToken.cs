using System;

namespace NetworkProtocols
{
	// Token: 0x02000490 RID: 1168
	public class PushDiscordAccessToken : BotNetMessage
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x00016147 File Offset: 0x00014347
		public PushDiscordAccessToken()
		{
			this.InitRefTypes();
			base.PacketType = 2567433079u;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00016160 File Offset: 0x00014360
		public PushDiscordAccessToken(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2567433079u;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x00016180 File Offset: 0x00014380
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00016188 File Offset: 0x00014388
		public string AccessToken { get; set; }

		// Token: 0x06002A4A RID: 10826 RVA: 0x000FB0D4 File Offset: 0x000F92D4
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.AccessToken);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000FB154 File Offset: 0x000F9354
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccessToken = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00016191 File Offset: 0x00014391
		private void InitRefTypes()
		{
			this.AccessToken = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016DF RID: 5855
		public const uint cPacketType = 2567433079u;
	}
}
