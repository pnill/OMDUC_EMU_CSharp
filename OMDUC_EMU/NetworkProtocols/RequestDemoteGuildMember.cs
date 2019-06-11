using System;

namespace NetworkProtocols
{
	// Token: 0x02000733 RID: 1843
	public class RequestDemoteGuildMember : BotNetMessage
	{
		// Token: 0x0600414A RID: 16714 RVA: 0x00025520 File Offset: 0x00023720
		public RequestDemoteGuildMember()
		{
			this.InitRefTypes();
			base.PacketType = 420224718u;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00025539 File Offset: 0x00023739
		public RequestDemoteGuildMember(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 420224718u;
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x00025559 File Offset: 0x00023759
		// (set) Token: 0x0600414D RID: 16717 RVA: 0x00025561 File Offset: 0x00023761
		public ulong TargetAccountSUID { get; set; }

		// Token: 0x0600414E RID: 16718 RVA: 0x0011EA90 File Offset: 0x0011CC90
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TargetAccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x0011EB10 File Offset: 0x0011CD10
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TargetAccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x0002556A File Offset: 0x0002376A
		private void InitRefTypes()
		{
			this.TargetAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002259 RID: 8793
		public const uint cPacketType = 420224718u;
	}
}
