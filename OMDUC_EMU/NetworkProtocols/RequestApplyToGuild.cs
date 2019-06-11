using System;

namespace NetworkProtocols
{
	// Token: 0x02000735 RID: 1845
	public class RequestApplyToGuild : BotNetMessage
	{
		// Token: 0x06004158 RID: 16728 RVA: 0x000255D5 File Offset: 0x000237D5
		public RequestApplyToGuild()
		{
			this.InitRefTypes();
			base.PacketType = 3731792054u;
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x000255EE File Offset: 0x000237EE
		public RequestApplyToGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3731792054u;
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x0002560E File Offset: 0x0002380E
		// (set) Token: 0x0600415B RID: 16731 RVA: 0x00025616 File Offset: 0x00023816
		public string GuildName { get; set; }

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x0002561F File Offset: 0x0002381F
		// (set) Token: 0x0600415D RID: 16733 RVA: 0x00025627 File Offset: 0x00023827
		public string Message { get; set; }

		// Token: 0x0600415E RID: 16734 RVA: 0x0011EC60 File Offset: 0x0011CE60
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Message);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x0011ECEC File Offset: 0x0011CEEC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Message = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00025630 File Offset: 0x00023830
		private void InitRefTypes()
		{
			this.GuildName = string.Empty;
			this.Message = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400225D RID: 8797
		public const uint cPacketType = 3731792054u;
	}
}
