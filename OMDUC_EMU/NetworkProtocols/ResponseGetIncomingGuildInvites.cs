using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000783 RID: 1923
	public class ResponseGetIncomingGuildInvites : BotNetMessage
	{
		// Token: 0x06004409 RID: 17417 RVA: 0x00027324 File Offset: 0x00025524
		public ResponseGetIncomingGuildInvites()
		{
			this.InitRefTypes();
			base.PacketType = 3091555472u;
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x0002733D File Offset: 0x0002553D
		public ResponseGetIncomingGuildInvites(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3091555472u;
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x0002735D File Offset: 0x0002555D
		// (set) Token: 0x0600440C RID: 17420 RVA: 0x00027365 File Offset: 0x00025565
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x0002736E File Offset: 0x0002556E
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x00027376 File Offset: 0x00025576
		public List<GuildInvite> Invites { get; set; }

		// Token: 0x0600440F RID: 17423 RVA: 0x00122C64 File Offset: 0x00120E64
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
			ArrayManager.WriteListGuildInvite(ref newArray, ref newSize, this.Invites);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00122CF0 File Offset: 0x00120EF0
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
			this.Invites = ArrayManager.ReadListGuildInvite(data, ref num);
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x0002737F File Offset: 0x0002557F
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.Invites = new List<GuildInvite>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002336 RID: 9014
		public const uint cPacketType = 3091555472u;
	}
}
