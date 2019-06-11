using System;

namespace NetworkProtocols
{
	// Token: 0x02000745 RID: 1861
	public class RequestCancelGuildInvite : BotNetMessage
	{
		// Token: 0x060041EC RID: 16876 RVA: 0x00025C77 File Offset: 0x00023E77
		public RequestCancelGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 2501474871u;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00025C90 File Offset: 0x00023E90
		public RequestCancelGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2501474871u;
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x00025CB0 File Offset: 0x00023EB0
		// (set) Token: 0x060041EF RID: 16879 RVA: 0x00025CB8 File Offset: 0x00023EB8
		public ulong InviteID { get; set; }

		// Token: 0x060041F0 RID: 16880 RVA: 0x0011FAF8 File Offset: 0x0011DCF8
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

		// Token: 0x060041F1 RID: 16881 RVA: 0x0011FB78 File Offset: 0x0011DD78
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

		// Token: 0x060041F2 RID: 16882 RVA: 0x00025CC1 File Offset: 0x00023EC1
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400228E RID: 8846
		public const uint cPacketType = 2501474871u;
	}
}
