using System;

namespace NetworkProtocols
{
	// Token: 0x02000671 RID: 1649
	public class ResponseStreamerAPIStateChange : BotNetMessage
	{
		// Token: 0x060039DA RID: 14810 RVA: 0x00020040 File Offset: 0x0001E240
		public ResponseStreamerAPIStateChange()
		{
			this.InitRefTypes();
			base.PacketType = 4054112466u;
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00020059 File Offset: 0x0001E259
		public ResponseStreamerAPIStateChange(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4054112466u;
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x00020079 File Offset: 0x0001E279
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x00020081 File Offset: 0x0001E281
		public eStreamerAPIResponseStatus Status { get; set; }

		// Token: 0x060039DE RID: 14814 RVA: 0x00110094 File Offset: 0x0010E294
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
			ArrayManager.WriteeStreamerAPIResponseStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00110114 File Offset: 0x0010E314
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeStreamerAPIResponseStatus(data, ref num);
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x0002008A File Offset: 0x0001E28A
		private void InitRefTypes()
		{
			this.Status = eStreamerAPIResponseStatus.Success;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EA7 RID: 7847
		public const uint cPacketType = 4054112466u;
	}
}
