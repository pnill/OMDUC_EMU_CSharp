using System;

namespace NetworkProtocols
{
	// Token: 0x02000763 RID: 1891
	public class PushGuildInviteRemoved : BotNetMessage
	{
		// Token: 0x0600431A RID: 17178 RVA: 0x0002694B File Offset: 0x00024B4B
		public PushGuildInviteRemoved()
		{
			this.InitRefTypes();
			base.PacketType = 3370528924u;
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00026964 File Offset: 0x00024B64
		public PushGuildInviteRemoved(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3370528924u;
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x00026984 File Offset: 0x00024B84
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x0002698C File Offset: 0x00024B8C
		public ulong InviteID { get; set; }

		// Token: 0x0600431E RID: 17182 RVA: 0x00121860 File Offset: 0x0011FA60
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

		// Token: 0x0600431F RID: 17183 RVA: 0x001218E0 File Offset: 0x0011FAE0
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

		// Token: 0x06004320 RID: 17184 RVA: 0x00026995 File Offset: 0x00024B95
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022F5 RID: 8949
		public const uint cPacketType = 3370528924u;
	}
}
