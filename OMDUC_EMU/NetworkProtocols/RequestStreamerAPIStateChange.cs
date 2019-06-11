using System;

namespace NetworkProtocols
{
	// Token: 0x02000670 RID: 1648
	public class RequestStreamerAPIStateChange : BotNetMessage
	{
		// Token: 0x060039D3 RID: 14803 RVA: 0x0001FFE6 File Offset: 0x0001E1E6
		public RequestStreamerAPIStateChange()
		{
			this.InitRefTypes();
			base.PacketType = 1374619617u;
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x0001FFFF File Offset: 0x0001E1FF
		public RequestStreamerAPIStateChange(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1374619617u;
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x0002001F File Offset: 0x0001E21F
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x00020027 File Offset: 0x0001E227
		public bool EnableStreamingAPI { get; set; }

		// Token: 0x060039D7 RID: 14807 RVA: 0x0010FFAC File Offset: 0x0010E1AC
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.EnableStreamingAPI);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x0011002C File Offset: 0x0010E22C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EnableStreamingAPI = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00020030 File Offset: 0x0001E230
		private void InitRefTypes()
		{
			this.EnableStreamingAPI = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EA5 RID: 7845
		public const uint cPacketType = 1374619617u;
	}
}
