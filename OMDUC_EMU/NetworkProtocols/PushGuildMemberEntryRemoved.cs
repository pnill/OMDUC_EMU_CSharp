using System;

namespace NetworkProtocols
{
	// Token: 0x02000769 RID: 1897
	public class PushGuildMemberEntryRemoved : BotNetMessage
	{
		// Token: 0x06004344 RID: 17220 RVA: 0x00026B75 File Offset: 0x00024D75
		public PushGuildMemberEntryRemoved()
		{
			this.InitRefTypes();
			base.PacketType = 3232994734u;
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00026B8E File Offset: 0x00024D8E
		public PushGuildMemberEntryRemoved(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3232994734u;
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00026BAE File Offset: 0x00024DAE
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x00026BB6 File Offset: 0x00024DB6
		public ulong RemovedPlayerAccountSUID { get; set; }

		// Token: 0x06004348 RID: 17224 RVA: 0x00121DD0 File Offset: 0x0011FFD0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RemovedPlayerAccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00121E50 File Offset: 0x00120050
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.RemovedPlayerAccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00026BBF File Offset: 0x00024DBF
		private void InitRefTypes()
		{
			this.RemovedPlayerAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002301 RID: 8961
		public const uint cPacketType = 3232994734u;
	}
}
