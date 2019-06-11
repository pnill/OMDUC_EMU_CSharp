using System;

namespace NetworkProtocols
{
	// Token: 0x020004A9 RID: 1193
	public class ClientPingRequest : BotNetMessage
	{
		// Token: 0x06002AD0 RID: 10960 RVA: 0x00016740 File Offset: 0x00014940
		public ClientPingRequest()
		{
			this.InitRefTypes();
			base.PacketType = 3300795992u;
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00016759 File Offset: 0x00014959
		public ClientPingRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3300795992u;
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x00016779 File Offset: 0x00014979
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x00016781 File Offset: 0x00014981
		public uint LastAvgPing { get; set; }

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000FBB04 File Offset: 0x000F9D04
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
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.LastAvgPing);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000FBB84 File Offset: 0x000F9D84
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LastAvgPing = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0001678A File Offset: 0x0001498A
		private void InitRefTypes()
		{
			this.LastAvgPing = 0u;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400179A RID: 6042
		public const uint cPacketType = 3300795992u;
	}
}
