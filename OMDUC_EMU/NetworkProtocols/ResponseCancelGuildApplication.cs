using System;

namespace NetworkProtocols
{
	// Token: 0x02000744 RID: 1860
	public class ResponseCancelGuildApplication : BotNetMessage
	{
		// Token: 0x060041E3 RID: 16867 RVA: 0x00025C04 File Offset: 0x00023E04
		public ResponseCancelGuildApplication()
		{
			this.InitRefTypes();
			base.PacketType = 1229156781u;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00025C1D File Offset: 0x00023E1D
		public ResponseCancelGuildApplication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1229156781u;
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00025C3D File Offset: 0x00023E3D
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x00025C45 File Offset: 0x00023E45
		public ulong ApplicationID { get; set; }

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00025C4E File Offset: 0x00023E4E
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x00025C56 File Offset: 0x00023E56
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x060041E9 RID: 16873 RVA: 0x0011F9F4 File Offset: 0x0011DBF4
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x0011FA80 File Offset: 0x0011DC80
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
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x00025C5F File Offset: 0x00023E5F
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400228B RID: 8843
		public const uint cPacketType = 1229156781u;
	}
}
