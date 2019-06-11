using System;

namespace NetworkProtocols
{
	// Token: 0x02000608 RID: 1544
	public class ResponseSubmitConfirmationCode : BotNetMessage
	{
		// Token: 0x060035D8 RID: 13784 RVA: 0x0001D472 File Offset: 0x0001B672
		public ResponseSubmitConfirmationCode()
		{
			this.InitRefTypes();
			base.PacketType = 3133373011u;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0001D48B File Offset: 0x0001B68B
		public ResponseSubmitConfirmationCode(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3133373011u;
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x0001D4AB File Offset: 0x0001B6AB
		// (set) Token: 0x060035DB RID: 13787 RVA: 0x0001D4B3 File Offset: 0x0001B6B3
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x060035DC RID: 13788 RVA: 0x00109DF0 File Offset: 0x00107FF0
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
			ArrayManager.WriteeAuthLoginUserStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00109E70 File Offset: 0x00108070
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeAuthLoginUserStatus(data, ref num);
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0001D4BC File Offset: 0x0001B6BC
		private void InitRefTypes()
		{
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D54 RID: 7508
		public const uint cPacketType = 3133373011u;
	}
}
