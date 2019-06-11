using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000758 RID: 1880
	public class ResponseGuildCreationRequirements : BotNetMessage
	{
		// Token: 0x060042C9 RID: 17097 RVA: 0x0002651E File Offset: 0x0002471E
		public ResponseGuildCreationRequirements()
		{
			this.InitRefTypes();
			base.PacketType = 1699053877u;
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00026537 File Offset: 0x00024737
		public ResponseGuildCreationRequirements(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1699053877u;
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x00026557 File Offset: 0x00024757
		// (set) Token: 0x060042CC RID: 17100 RVA: 0x0002655F File Offset: 0x0002475F
		public GuildCreationRequirements CreationRequirements { get; set; }

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x00026568 File Offset: 0x00024768
		// (set) Token: 0x060042CE RID: 17102 RVA: 0x00026570 File Offset: 0x00024770
		public List<GuildCreationRegex> GuildCreationRegexes { get; set; }

		// Token: 0x060042CF RID: 17103 RVA: 0x00120E30 File Offset: 0x0011F030
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
			ArrayManager.WriteGuildCreationRequirements(ref newArray, ref newSize, this.CreationRequirements);
			ArrayManager.WriteListGuildCreationRegex(ref newArray, ref newSize, this.GuildCreationRegexes);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00120EBC File Offset: 0x0011F0BC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CreationRequirements = ArrayManager.ReadGuildCreationRequirements(data, ref num);
			this.GuildCreationRegexes = ArrayManager.ReadListGuildCreationRegex(data, ref num);
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00026579 File Offset: 0x00024779
		private void InitRefTypes()
		{
			this.CreationRequirements = new GuildCreationRequirements();
			this.GuildCreationRegexes = new List<GuildCreationRegex>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022DD RID: 8925
		public const uint cPacketType = 1699053877u;
	}
}
