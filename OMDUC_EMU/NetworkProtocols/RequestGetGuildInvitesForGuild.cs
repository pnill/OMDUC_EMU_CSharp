using System;

namespace NetworkProtocols
{
	// Token: 0x0200073B RID: 1851
	public class RequestGetGuildInvitesForGuild : BotNetMessage
	{
		// Token: 0x060041A0 RID: 16800 RVA: 0x000258A0 File Offset: 0x00023AA0
		public RequestGetGuildInvitesForGuild()
		{
			this.InitRefTypes();
			base.PacketType = 549982933u;
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x000258B9 File Offset: 0x00023AB9
		public RequestGetGuildInvitesForGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 549982933u;
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x000FBC5C File Offset: 0x000F9E5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002277 RID: 8823
		public const uint cPacketType = 549982933u;
	}
}
