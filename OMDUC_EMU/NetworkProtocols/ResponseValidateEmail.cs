using System;

namespace NetworkProtocols
{
	// Token: 0x02000611 RID: 1553
	public class ResponseValidateEmail : BotNetMessage
	{
		// Token: 0x06003633 RID: 13875 RVA: 0x0001D894 File Offset: 0x0001BA94
		public ResponseValidateEmail()
		{
			this.InitRefTypes();
			base.PacketType = 1866800103u;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0001D8AD File Offset: 0x0001BAAD
		public ResponseValidateEmail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1866800103u;
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x0001D8CD File Offset: 0x0001BACD
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x0001D8D5 File Offset: 0x0001BAD5
		public eRegistrationStatus Status { get; set; }

		// Token: 0x06003637 RID: 13879 RVA: 0x0010A860 File Offset: 0x00108A60
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

		// Token: 0x06003638 RID: 13880 RVA: 0x0010A8E0 File Offset: 0x00108AE0
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

		// Token: 0x06003639 RID: 13881 RVA: 0x0001D8DE File Offset: 0x0001BADE
		private void InitRefTypes()
		{
			this.Status = eRegistrationStatus.eRegistrationStatus_Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D74 RID: 7540
		public const uint cPacketType = 1866800103u;
	}
}
