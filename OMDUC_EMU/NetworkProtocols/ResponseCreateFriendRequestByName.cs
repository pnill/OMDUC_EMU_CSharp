using System;

namespace NetworkProtocols
{
	// Token: 0x02000714 RID: 1812
	public class ResponseCreateFriendRequestByName : BotNetMessage
	{
		// Token: 0x0600404D RID: 16461 RVA: 0x0002484A File Offset: 0x00022A4A
		public ResponseCreateFriendRequestByName()
		{
			this.InitRefTypes();
			base.PacketType = 3038667611u;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00024863 File Offset: 0x00022A63
		public ResponseCreateFriendRequestByName(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3038667611u;
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x00024883 File Offset: 0x00022A83
		// (set) Token: 0x06004050 RID: 16464 RVA: 0x0002488B File Offset: 0x00022A8B
		public eCreateFriendRequestStatus Status { get; set; }

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x00024894 File Offset: 0x00022A94
		// (set) Token: 0x06004052 RID: 16466 RVA: 0x0002489C File Offset: 0x00022A9C
		public string PlayerName { get; set; }

		// Token: 0x06004053 RID: 16467 RVA: 0x0011CE18 File Offset: 0x0011B018
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
			ArrayManager.WriteeCreateFriendRequestStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0011CEA4 File Offset: 0x0011B0A4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeCreateFriendRequestStatus(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x000248A5 File Offset: 0x00022AA5
		private void InitRefTypes()
		{
			this.Status = eCreateFriendRequestStatus.CreateFriendRequestStatus_Failure;
			this.PlayerName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002209 RID: 8713
		public const uint cPacketType = 3038667611u;
	}
}
