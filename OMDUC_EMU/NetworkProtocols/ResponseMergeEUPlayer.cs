using System;

namespace NetworkProtocols
{
	// Token: 0x0200065E RID: 1630
	public class ResponseMergeEUPlayer : BotNetMessage
	{
		// Token: 0x060038E0 RID: 14560 RVA: 0x0001F61F File Offset: 0x0001D81F
		public ResponseMergeEUPlayer()
		{
			this.InitRefTypes();
			base.PacketType = 1215711276u;
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0001F638 File Offset: 0x0001D838
		public ResponseMergeEUPlayer(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1215711276u;
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x0001F658 File Offset: 0x0001D858
		// (set) Token: 0x060038E3 RID: 14563 RVA: 0x0001F660 File Offset: 0x0001D860
		public ulong AccountSUID { get; set; }

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x0001F669 File Offset: 0x0001D869
		// (set) Token: 0x060038E5 RID: 14565 RVA: 0x0001F671 File Offset: 0x0001D871
		public eAuthLoginUserStatus Status { get; set; }

		// Token: 0x060038E6 RID: 14566 RVA: 0x0010EA08 File Offset: 0x0010CC08
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteeAuthLoginUserStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0010EA94 File Offset: 0x0010CC94
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeAuthLoginUserStatus(data, ref num);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0001F67A File Offset: 0x0001D87A
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E49 RID: 7753
		public const uint cPacketType = 1215711276u;
	}
}
