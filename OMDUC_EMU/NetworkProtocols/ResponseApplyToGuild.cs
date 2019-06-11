using System;

namespace NetworkProtocols
{
	// Token: 0x02000736 RID: 1846
	public class ResponseApplyToGuild : BotNetMessage
	{
		// Token: 0x06004161 RID: 16737 RVA: 0x0002564F File Offset: 0x0002384F
		public ResponseApplyToGuild()
		{
			this.InitRefTypes();
			base.PacketType = 1764966259u;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x00025668 File Offset: 0x00023868
		public ResponseApplyToGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1764966259u;
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00025688 File Offset: 0x00023888
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x00025690 File Offset: 0x00023890
		public GuildApplication Application { get; set; }

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x00025699 File Offset: 0x00023899
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x000256A1 File Offset: 0x000238A1
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004167 RID: 16743 RVA: 0x0011ED64 File Offset: 0x0011CF64
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
			ArrayManager.WriteGuildApplication(ref newArray, ref newSize, this.Application);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0011EDF0 File Offset: 0x0011CFF0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Application = ArrayManager.ReadGuildApplication(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x000256AA File Offset: 0x000238AA
		private void InitRefTypes()
		{
			this.Application = new GuildApplication();
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002260 RID: 8800
		public const uint cPacketType = 1764966259u;
	}
}
