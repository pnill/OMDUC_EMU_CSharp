using System;

namespace NetworkProtocols
{
	// Token: 0x0200074E RID: 1870
	public class RequestGetGuildDetail : BotNetMessage
	{
		// Token: 0x06004234 RID: 16948 RVA: 0x00025FA5 File Offset: 0x000241A5
		public RequestGetGuildDetail()
		{
			this.InitRefTypes();
			base.PacketType = 248680754u;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x00025FBE File Offset: 0x000241BE
		public RequestGetGuildDetail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 248680754u;
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x00025FDE File Offset: 0x000241DE
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x00025FE6 File Offset: 0x000241E6
		public ulong GuildID { get; set; }

		// Token: 0x06004238 RID: 16952 RVA: 0x001201D0 File Offset: 0x0011E3D0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x00120250 File Offset: 0x0011E450
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00025FEF File Offset: 0x000241EF
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022A4 RID: 8868
		public const uint cPacketType = 248680754u;
	}
}
