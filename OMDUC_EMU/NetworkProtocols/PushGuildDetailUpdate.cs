using System;

namespace NetworkProtocols
{
	// Token: 0x0200076A RID: 1898
	public class PushGuildDetailUpdate : BotNetMessage
	{
		// Token: 0x0600434B RID: 17227 RVA: 0x00026BD0 File Offset: 0x00024DD0
		public PushGuildDetailUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 3190542750u;
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00026BE9 File Offset: 0x00024DE9
		public PushGuildDetailUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3190542750u;
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x00026C09 File Offset: 0x00024E09
		// (set) Token: 0x0600434E RID: 17230 RVA: 0x00026C11 File Offset: 0x00024E11
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x00026C1A File Offset: 0x00024E1A
		// (set) Token: 0x06004350 RID: 17232 RVA: 0x00026C22 File Offset: 0x00024E22
		public GuildDetail GuildDetail { get; set; }

		// Token: 0x06004351 RID: 17233 RVA: 0x00121EB8 File Offset: 0x001200B8
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteGuildDetail(ref newArray, ref newSize, this.GuildDetail);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00121F44 File Offset: 0x00120144
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
			this.GuildDetail = ArrayManager.ReadGuildDetail(data, ref num);
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x00026C2B File Offset: 0x00024E2B
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.GuildDetail = new GuildDetail();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002303 RID: 8963
		public const uint cPacketType = 3190542750u;
	}
}
