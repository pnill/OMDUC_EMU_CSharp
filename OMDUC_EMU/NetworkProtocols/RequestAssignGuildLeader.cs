using System;

namespace NetworkProtocols
{
	// Token: 0x02000765 RID: 1893
	public class RequestAssignGuildLeader : BotNetMessage
	{
		// Token: 0x06004328 RID: 17192 RVA: 0x00026A04 File Offset: 0x00024C04
		public RequestAssignGuildLeader()
		{
			this.InitRefTypes();
			base.PacketType = 4104066817u;
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00026A1D File Offset: 0x00024C1D
		public RequestAssignGuildLeader(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4104066817u;
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x00026A3D File Offset: 0x00024C3D
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x00026A45 File Offset: 0x00024C45
		public ulong TargetAccountSUID { get; set; }

		// Token: 0x0600432C RID: 17196 RVA: 0x00121A30 File Offset: 0x0011FC30
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

		// Token: 0x0600432D RID: 17197 RVA: 0x00121AB0 File Offset: 0x0011FCB0
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

		// Token: 0x0600432E RID: 17198 RVA: 0x00026A4E File Offset: 0x00024C4E
		private void InitRefTypes()
		{
			this.TargetAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022F9 RID: 8953
		public const uint cPacketType = 4104066817u;
	}
}
