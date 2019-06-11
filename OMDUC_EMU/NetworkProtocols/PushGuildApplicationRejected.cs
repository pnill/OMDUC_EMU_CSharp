using System;

namespace NetworkProtocols
{
	// Token: 0x02000760 RID: 1888
	public class PushGuildApplicationRejected : BotNetMessage
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x0002681F File Offset: 0x00024A1F
		public PushGuildApplicationRejected()
		{
			this.InitRefTypes();
			base.PacketType = 3325042036u;
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00026838 File Offset: 0x00024A38
		public PushGuildApplicationRejected(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3325042036u;
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x00026858 File Offset: 0x00024A58
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x00026860 File Offset: 0x00024A60
		public ulong ApplicationID { get; set; }

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x00026869 File Offset: 0x00024A69
		// (set) Token: 0x06004308 RID: 17160 RVA: 0x00026871 File Offset: 0x00024A71
		public eApplicationStatus Status { get; set; }

		// Token: 0x06004309 RID: 17161 RVA: 0x0012158C File Offset: 0x0011F78C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ApplicationID);
			ArrayManager.WriteeApplicationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x00121618 File Offset: 0x0011F818
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ApplicationID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeApplicationStatus(data, ref num);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x0002687A File Offset: 0x00024A7A
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			this.Status = eApplicationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022EE RID: 8942
		public const uint cPacketType = 3325042036u;
	}
}
