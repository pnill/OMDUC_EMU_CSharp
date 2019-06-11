using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000785 RID: 1925
	public class ResponseGetOutgoingGuildApplications : BotNetMessage
	{
		// Token: 0x06004417 RID: 17431 RVA: 0x000273D3 File Offset: 0x000255D3
		public ResponseGetOutgoingGuildApplications()
		{
			this.InitRefTypes();
			base.PacketType = 20082191u;
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x000273EC File Offset: 0x000255EC
		public ResponseGetOutgoingGuildApplications(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 20082191u;
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x0002740C File Offset: 0x0002560C
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x00027414 File Offset: 0x00025614
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x0002741D File Offset: 0x0002561D
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x00027425 File Offset: 0x00025625
		public List<GuildApplication> Applications { get; set; }

		// Token: 0x0600441D RID: 17437 RVA: 0x00122D68 File Offset: 0x00120F68
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListGuildApplication(ref newArray, ref newSize, this.Applications);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00122DF4 File Offset: 0x00120FF4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
			this.Applications = ArrayManager.ReadListGuildApplication(data, ref num);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x0002742E File Offset: 0x0002562E
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.Applications = new List<GuildApplication>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400233A RID: 9018
		public const uint cPacketType = 20082191u;
	}
}
