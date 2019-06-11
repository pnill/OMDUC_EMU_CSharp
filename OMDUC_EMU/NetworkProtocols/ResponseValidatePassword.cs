using System;

namespace NetworkProtocols
{
	// Token: 0x02000617 RID: 1559
	public class ResponseValidatePassword : BotNetMessage
	{
		// Token: 0x0600365F RID: 13919 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		public ResponseValidatePassword()
		{
			this.InitRefTypes();
			base.PacketType = 4171037411u;
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0001DAF1 File Offset: 0x0001BCF1
		public ResponseValidatePassword(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4171037411u;
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x0001DB11 File Offset: 0x0001BD11
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x0001DB19 File Offset: 0x0001BD19
		public eRegistrationStatus Status { get; set; }

		// Token: 0x06003663 RID: 13923 RVA: 0x0010ADEC File Offset: 0x00108FEC
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
			ArrayManager.WriteeRegistrationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x0010AE6C File Offset: 0x0010906C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeRegistrationStatus(data, ref num);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0001DB22 File Offset: 0x0001BD22
		private void InitRefTypes()
		{
			this.Status = eRegistrationStatus.eRegistrationStatus_Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D81 RID: 7553
		public const uint cPacketType = 4171037411u;
	}
}
