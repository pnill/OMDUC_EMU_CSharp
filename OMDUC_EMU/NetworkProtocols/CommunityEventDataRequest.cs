using System;

namespace NetworkProtocols
{
	// Token: 0x02000669 RID: 1641
	public class CommunityEventDataRequest : BotNetMessage
	{
		// Token: 0x06003992 RID: 14738 RVA: 0x0001FC91 File Offset: 0x0001DE91
		public CommunityEventDataRequest()
		{
			this.InitRefTypes();
			base.PacketType = 3136810884u;
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x0001FCAA File Offset: 0x0001DEAA
		public CommunityEventDataRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3136810884u;
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x0001FCCA File Offset: 0x0001DECA
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x0001FCD2 File Offset: 0x0001DED2
		public ulong CommunityEventID { get; set; }

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x0001FCDB File Offset: 0x0001DEDB
		// (set) Token: 0x06003997 RID: 14743 RVA: 0x0001FCE3 File Offset: 0x0001DEE3
		public string PlayerLocale { get; set; }

		// Token: 0x06003998 RID: 14744 RVA: 0x0010F870 File Offset: 0x0010DA70
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CommunityEventID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerLocale);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0010F8FC File Offset: 0x0010DAFC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CommunityEventID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerLocale = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0001FCEC File Offset: 0x0001DEEC
		private void InitRefTypes()
		{
			this.CommunityEventID = 0UL;
			this.PlayerLocale = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E8F RID: 7823
		public const uint cPacketType = 3136810884u;
	}
}
