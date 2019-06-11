using System;

namespace NetworkProtocols
{
	// Token: 0x0200074C RID: 1868
	public class ResponseDisbandGuild : BotNetMessage
	{
		// Token: 0x0600421B RID: 16923 RVA: 0x00025EC6 File Offset: 0x000240C6
		public ResponseDisbandGuild()
		{
			this.InitRefTypes();
			base.PacketType = 3461673725u;
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00025EDF File Offset: 0x000240DF
		public ResponseDisbandGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3461673725u;
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x00025EFF File Offset: 0x000240FF
		// (set) Token: 0x0600421E RID: 16926 RVA: 0x00025F07 File Offset: 0x00024107
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x0600421F RID: 16927 RVA: 0x0011FF9C File Offset: 0x0011E19C
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

		// Token: 0x06004220 RID: 16928 RVA: 0x0012001C File Offset: 0x0011E21C
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

		// Token: 0x06004221 RID: 16929 RVA: 0x00025F10 File Offset: 0x00024110
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400229B RID: 8859
		public const uint cPacketType = 3461673725u;
	}
}
