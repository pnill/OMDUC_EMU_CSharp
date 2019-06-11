using System;

namespace NetworkProtocols
{
	// Token: 0x020004E5 RID: 1253
	public class RequestPlayerChangePortraitIndex : BotNetMessage
	{
		// Token: 0x06002B6A RID: 11114 RVA: 0x00016EAA File Offset: 0x000150AA
		public RequestPlayerChangePortraitIndex()
		{
			this.InitRefTypes();
			base.PacketType = 3861597650u;
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00016EC3 File Offset: 0x000150C3
		public RequestPlayerChangePortraitIndex(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3861597650u;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x00016EE3 File Offset: 0x000150E3
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x00016EEB File Offset: 0x000150EB
		public ulong PortraitIndex { get; set; }

		// Token: 0x06002B6E RID: 11118 RVA: 0x000FC8DC File Offset: 0x000FAADC
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PortraitIndex);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000FC95C File Offset: 0x000FAB5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PortraitIndex = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00016EF4 File Offset: 0x000150F4
		private void InitRefTypes()
		{
			this.PortraitIndex = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A38 RID: 6712
		public const uint cPacketType = 3861597650u;
	}
}
