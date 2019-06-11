using System;

namespace NetworkProtocols
{
	// Token: 0x0200074F RID: 1871
	public class RequestGetGuildDetailByTag : BotNetMessage
	{
		// Token: 0x0600423B RID: 16955 RVA: 0x00026000 File Offset: 0x00024200
		public RequestGetGuildDetailByTag()
		{
			this.InitRefTypes();
			base.PacketType = 4163934884u;
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x00026019 File Offset: 0x00024219
		public RequestGetGuildDetailByTag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4163934884u;
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x00026039 File Offset: 0x00024239
		// (set) Token: 0x0600423E RID: 16958 RVA: 0x00026041 File Offset: 0x00024241
		public string GuildTag { get; set; }

		// Token: 0x0600423F RID: 16959 RVA: 0x001202B8 File Offset: 0x0011E4B8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00120338 File Offset: 0x0011E538
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x0002604A File Offset: 0x0002424A
		private void InitRefTypes()
		{
			this.GuildTag = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022A6 RID: 8870
		public const uint cPacketType = 4163934884u;
	}
}
