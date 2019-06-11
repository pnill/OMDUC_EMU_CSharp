using System;

namespace NetworkProtocols
{
	// Token: 0x02000723 RID: 1827
	public class FriendRemoved : BotNetMessage
	{
		// Token: 0x060040C6 RID: 16582 RVA: 0x00024E60 File Offset: 0x00023060
		public FriendRemoved()
		{
			this.InitRefTypes();
			base.PacketType = 3934755070u;
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00024E79 File Offset: 0x00023079
		public FriendRemoved(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3934755070u;
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x00024E99 File Offset: 0x00023099
		// (set) Token: 0x060040C9 RID: 16585 RVA: 0x00024EA1 File Offset: 0x000230A1
		public ulong FriendAccountSUID { get; set; }

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x00024EAA File Offset: 0x000230AA
		// (set) Token: 0x060040CB RID: 16587 RVA: 0x00024EB2 File Offset: 0x000230B2
		public string FriendName { get; set; }

		// Token: 0x060040CC RID: 16588 RVA: 0x0011DAF8 File Offset: 0x0011BCF8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.FriendAccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.FriendName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x0011DB84 File Offset: 0x0011BD84
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.FriendAccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.FriendName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x00024EBB File Offset: 0x000230BB
		private void InitRefTypes()
		{
			this.FriendAccountSUID = 0UL;
			this.FriendName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400222F RID: 8751
		public const uint cPacketType = 3934755070u;
	}
}
