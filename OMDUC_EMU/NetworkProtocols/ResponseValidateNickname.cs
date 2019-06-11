using System;

namespace NetworkProtocols
{
	// Token: 0x02000615 RID: 1557
	public class ResponseValidateNickname : BotNetMessage
	{
		// Token: 0x0600364F RID: 13903 RVA: 0x0001DA04 File Offset: 0x0001BC04
		public ResponseValidateNickname()
		{
			this.InitRefTypes();
			base.PacketType = 1825981010u;
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0001DA1D File Offset: 0x0001BC1D
		public ResponseValidateNickname(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1825981010u;
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x0001DA3D File Offset: 0x0001BC3D
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x0001DA45 File Offset: 0x0001BC45
		public eRegistrationStatus Status { get; set; }

		// Token: 0x06003653 RID: 13907 RVA: 0x0010AC00 File Offset: 0x00108E00
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

		// Token: 0x06003654 RID: 13908 RVA: 0x0010AC80 File Offset: 0x00108E80
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

		// Token: 0x06003655 RID: 13909 RVA: 0x0001DA4E File Offset: 0x0001BC4E
		private void InitRefTypes()
		{
			this.Status = eRegistrationStatus.eRegistrationStatus_Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D7C RID: 7548
		public const uint cPacketType = 1825981010u;
	}
}
