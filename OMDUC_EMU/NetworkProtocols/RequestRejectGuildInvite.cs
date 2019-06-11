using System;

namespace NetworkProtocols
{
	// Token: 0x02000729 RID: 1833
	public class RequestRejectGuildInvite : BotNetMessage
	{
		// Token: 0x060040FC RID: 16636 RVA: 0x00025121 File Offset: 0x00023321
		public RequestRejectGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 160435844u;
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x0002513A File Offset: 0x0002333A
		public RequestRejectGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 160435844u;
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060040FE RID: 16638 RVA: 0x0002515A File Offset: 0x0002335A
		// (set) Token: 0x060040FF RID: 16639 RVA: 0x00025162 File Offset: 0x00023362
		public ulong InviteID { get; set; }

		// Token: 0x06004100 RID: 16640 RVA: 0x0011E110 File Offset: 0x0011C310
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InviteID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x0011E190 File Offset: 0x0011C390
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.InviteID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x0002516B File Offset: 0x0002336B
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002241 RID: 8769
		public const uint cPacketType = 160435844u;
	}
}
