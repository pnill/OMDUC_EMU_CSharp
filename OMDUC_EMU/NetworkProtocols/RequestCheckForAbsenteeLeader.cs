using System;

namespace NetworkProtocols
{
	// Token: 0x02000787 RID: 1927
	public class RequestCheckForAbsenteeLeader : BotNetMessage
	{
		// Token: 0x06004427 RID: 17447 RVA: 0x000274A4 File Offset: 0x000256A4
		public RequestCheckForAbsenteeLeader()
		{
			this.InitRefTypes();
			base.PacketType = 4012652900u;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x000274BD File Offset: 0x000256BD
		public RequestCheckForAbsenteeLeader(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4012652900u;
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x000274DD File Offset: 0x000256DD
		// (set) Token: 0x0600442A RID: 17450 RVA: 0x000274E5 File Offset: 0x000256E5
		public ulong GuildID { get; set; }

		// Token: 0x0600442B RID: 17451 RVA: 0x00122F54 File Offset: 0x00121154
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00122FD4 File Offset: 0x001211D4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x000274EE File Offset: 0x000256EE
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400233F RID: 9023
		public const uint cPacketType = 4012652900u;
	}
}
