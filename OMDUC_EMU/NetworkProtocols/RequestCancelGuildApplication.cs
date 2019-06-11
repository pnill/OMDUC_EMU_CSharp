using System;

namespace NetworkProtocols
{
	// Token: 0x02000743 RID: 1859
	public class RequestCancelGuildApplication : BotNetMessage
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x00025BA9 File Offset: 0x00023DA9
		public RequestCancelGuildApplication()
		{
			this.InitRefTypes();
			base.PacketType = 3909660318u;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00025BC2 File Offset: 0x00023DC2
		public RequestCancelGuildApplication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3909660318u;
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x00025BE2 File Offset: 0x00023DE2
		// (set) Token: 0x060041DF RID: 16863 RVA: 0x00025BEA File Offset: 0x00023DEA
		public ulong ApplicationID { get; set; }

		// Token: 0x060041E0 RID: 16864 RVA: 0x0011F90C File Offset: 0x0011DB0C
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x0011F98C File Offset: 0x0011DB8C
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
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00025BF3 File Offset: 0x00023DF3
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002289 RID: 8841
		public const uint cPacketType = 3909660318u;
	}
}
