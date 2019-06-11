using System;

namespace NetworkProtocols
{
	// Token: 0x02000766 RID: 1894
	public class ResponseAssignGuildLeader : BotNetMessage
	{
		// Token: 0x0600432F RID: 17199 RVA: 0x00026A5F File Offset: 0x00024C5F
		public ResponseAssignGuildLeader()
		{
			this.InitRefTypes();
			base.PacketType = 4289266884u;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00026A78 File Offset: 0x00024C78
		public ResponseAssignGuildLeader(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4289266884u;
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x00026A98 File Offset: 0x00024C98
		// (set) Token: 0x06004332 RID: 17202 RVA: 0x00026AA0 File Offset: 0x00024CA0
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x06004333 RID: 17203 RVA: 0x00121B18 File Offset: 0x0011FD18
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x00121B98 File Offset: 0x0011FD98
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
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00026AA9 File Offset: 0x00024CA9
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022FB RID: 8955
		public const uint cPacketType = 4289266884u;
	}
}
