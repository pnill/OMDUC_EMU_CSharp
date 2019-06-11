using System;

namespace NetworkProtocols
{
	// Token: 0x0200061C RID: 1564
	public class RequestReportTutorialProgressAnalytics : BotNetMessage
	{
		// Token: 0x0600368E RID: 13966 RVA: 0x0001DD34 File Offset: 0x0001BF34
		public RequestReportTutorialProgressAnalytics()
		{
			this.InitRefTypes();
			base.PacketType = 2077932908u;
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x0001DD4D File Offset: 0x0001BF4D
		public RequestReportTutorialProgressAnalytics(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2077932908u;
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x0001DD6D File Offset: 0x0001BF6D
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x0001DD75 File Offset: 0x0001BF75
		public string Message { get; set; }

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x0001DD7E File Offset: 0x0001BF7E
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x0001DD86 File Offset: 0x0001BF86
		public ulong MapID { get; set; }

		// Token: 0x06003694 RID: 13972 RVA: 0x0010B320 File Offset: 0x00109520
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Message);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x0010B3AC File Offset: 0x001095AC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Message = ArrayManager.ReadString(data, ref num);
			this.MapID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x0001DD8F File Offset: 0x0001BF8F
		private void InitRefTypes()
		{
			this.Message = string.Empty;
			this.MapID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D91 RID: 7569
		public const uint cPacketType = 2077932908u;
	}
}
